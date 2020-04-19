using BudgetModels;
using BudgetModels.Models_V1.BudgetModels;
using BudgetModels.Models_V1.BudgetModels.Interfaces;
using BudgetPlanner_UI.Interfaces;
using StateControl.Interfaces;
using StateControl.States;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace BudgetPlanner_UI.ViewModels
{
    public class BudgetViewModel : ViewModelBase, IViewModel
	{
		#region - Fields & Properties
		private ObservableCollection<IIncome> _incomeDataList;
		private ObservableCollection<IExpense> _expenseDataList;

		private ObservableCollection<IIncome> _upcomingIncome;
		private ObservableCollection<IExpense> _upcomingExpenses;

		public IIncome _selectedIncome;
		public IExpense _selectedExpense;

		private decimal _incomeTotal;
		private decimal _expenseTotal;
		private decimal _incomeRecTotal;
		private decimal _expenseRecTotal;
		private decimal _totalsDiff;
		private bool _isDiffNeg;
		#endregion

		#region - Constructors
		public BudgetViewModel( )
		{
			#region Quick Binding Test
			IncomeDataList = new ObservableCollection<IIncome>()
			{
				new Income
				{
					IDNumber = 1,
					Title = "test 1",
					Amount = 42.4M,
					AmountRecieved = 22.7M,
					Description = "test Income 1",
					IsRecieved = false,
					Period = PayPeriod.Once,

					DueDate = new DateTime(2020, 2, 5)
				},
				new Income
				{
					IDNumber = 2,
					Title = "test 2",
					Amount = 38.55M,
					AmountRecieved = 0.43M,
					Description = "test Income 2",
					IsRecieved = false,
					Period = PayPeriod.Once
				},
				new Income
				{
					IDNumber = 3,
					Title = "test 3",
					Amount = 4000.48M,
					AmountRecieved = 0,
					Description = "test Income 3",
					IsRecieved = true,
					Period = PayPeriod.Month
				}
			};

			ExpenseDataList = new ObservableCollection<IExpense>()
			{
				new Expense
				{
					IDNumber = 1,
					Title = "Test 1",
					Amount = 42.42M,
					AmountPayed = 24.24M,
					Description = "Test Expense 1",
					IsPayedOff = false,
					IsPayedOnce = false,
					DueDate = DateTime.Now.AddMonths(2)
				},
				new Expense
				{
					IDNumber = 2,
					Title = "Test 2",
					Amount = 1200,
					AmountPayed = 383.40M,
					Description = "Test Expense 2",
					IsPayedOff = false,
					IsPayedOnce = false,
					DueDate = DateTime.Now.AddMonths(3)
				},
				new Expense
				{
					IDNumber = 3,
					Title = "Test 3 Behind",
					Amount = 350,
					AmountPayed = 100,
					Description = "Test Expense Behind 1",
					IsPayedOff = false,
					DueDate = new DateTime(2020,2,10)
				}
			};
			#endregion
		}
		#endregion

		#region - Methods
		#region Event Handlers
		public void IncomeCellChangedEvent( object sender, EventArgs e )
		{
			CalculateAmountTotal(true);
			CalculateAmountRecievedTotal();
			CalculateDifference();
		}

		public void ExpenseCellChangedEvent( object sender, EventArgs e )
		{
			CalculateAmountTotal(false);
			CalculateRemainingFromPayedAmount();
			CalculateRemainingAmountTotal();
			GetUpcomingExpenses();
			CalculateDifference();
		}

		public void KeyUpEvent( object sender, KeyEventArgs e )
		{
			if (e.Key == Key.F5)
			{
				IncomeCellChangedEvent(sender, e);
				ExpenseCellChangedEvent(sender, e);
			}
		}

		#region Buttons
		public void AddIncomeEvent( object sender, EventArgs e )
		{
			AddIncome();
		}

		public void AddExpenseEvent( object sender, EventArgs e )
		{
			AddExpense();
		}

		public void DeleteIncomeEvent( object sender, EventArgs e )
		{
			if (SelectedIncome != null)
			{
				IncomeDataList.Remove(SelectedIncome);
			}
		}

		public void DeleteExpenseEvent( object sender, EventArgs e )
		{
			if (SelectedExpense != null)
			{
				ExpenseDataList.Remove(SelectedExpense);
			}
		}
		#endregion
		#endregion

		#region Calculate Income/Expense Data
		/// <summary>
		/// Calculate the total for income or expense based on the bool given.
		/// </summary>
		public void CalculateAmountTotal( bool isIncome )
		{
			if (isIncome)
			{
				IncomeTotal = 0;
				if (IncomeDataList != null)
				{
					foreach (var amount in IncomeDataList)
					{
						IncomeTotal += amount.Amount;
					}
				}
			}
			else
			{
				if (ExpenseDataList != null)
				{
					ExpenseTotal = 0;
					foreach (var amount in ExpenseDataList)
					{
						ExpenseTotal += amount.Amount;
					}
				}
			}
		}

		public void CalculateAmountRecievedTotal( )
		{
			if (IncomeDataList != null)
			{
				IncomeRecievedTotal = 0;
				foreach (var recAmount in IncomeDataList)
				{
					IncomeRecievedTotal += recAmount.AmountRecieved;
				}
			}
		}

		public void CalculateRemainingAmountTotal( )
		{
			if (ExpenseDataList != null)
			{
				ExpenseRemainingTotal = 0;
				foreach (var exp in ExpenseDataList)
				{
					ExpenseRemainingTotal += exp.RemainingAmount;
				}
			}
		}

		public void CalculateRemainingFromPayedAmount(  )
		{
			if (ExpenseDataList != null)
			{
				foreach (var exp in ExpenseDataList)
				{
					exp.CalcRemainingFromPayed();
				}
			}
		}

		public void CalculateDifference(  )
		{
			TotalsDifference = IncomeTotal - ExpenseTotal;
		}
		#endregion

		#region Get Upcoming Income/Expenses
		public void GetUpcomingExpenses(  )
		{
			if (ExpenseDataList != null)
			{
				UpcomingExpenses = new ObservableCollection<IExpense>(BudgetController.SortDueExpenses(ExpenseDataList, true));
			}
		}

		public void GetUpcomingIncome(  )
		{
			if (IncomeDataList != null)
			{
				UpcomingIncome = new ObservableCollection<IIncome>(BudgetController.SortDueIncome(IncomeDataList, true));
			}
		}
		#endregion

		public override void OpenData( IState data )
		{
			var budgetData = data as BudgetState;
			IncomeDataList = new ObservableCollection<IIncome>(budgetData.IncomeData);
			ExpenseDataList = new ObservableCollection<IExpense>(budgetData.ExpenseData);
		}

		public override void Clear( )
		{
			IncomeDataList = null;
			ExpenseDataList = null;

			UpcomingIncome = null;
			UpcomingExpenses = null;

			SelectedIncome = null;
			SelectedExpense = null;

			IncomeTotal = 0;
			ExpenseTotal = 0;

			IncomeRecievedTotal = 0;
			ExpenseRemainingTotal = 0;

			TotalsDifference = 0;
			IsDiffNegative = false;
		}

        public override void New( )
		{
			Clear();
			IncomeDataList = new ObservableCollection<IIncome>();
			AddIncome();
			ExpenseDataList = new ObservableCollection<IExpense>();
			AddExpense();
		}

		private void AddIncome( )
		{
			IncomeDataList.Add(BudgetFactory.BuildIncome());
		}

		private void AddExpense( )
		{
			ExpenseDataList.Add(BudgetFactory.BuildExpense());
		}
		#endregion

		#region - Full Properties
		public ObservableCollection<IIncome> IncomeDataList
		{
			get { return _incomeDataList; }
			set
			{
				_incomeDataList = value;
				OnPropertyChanged(nameof(IncomeDataList));
			}
		}

		public ObservableCollection<IExpense> ExpenseDataList
		{
			get { return _expenseDataList; }
			set
			{
				_expenseDataList = value;
				OnPropertyChanged(nameof(ExpenseDataList));
			}
		}

		public ObservableCollection<IIncome> UpcomingIncome
		{
			get { return _upcomingIncome; }
			set
			{
				_upcomingIncome = value;
				OnPropertyChanged(nameof(UpcomingIncome));
			}
		}

		public ObservableCollection<IExpense> UpcomingExpenses
		{
			get { return _upcomingExpenses; }
			set
			{
				_upcomingExpenses = value;
				OnPropertyChanged(nameof(UpcomingExpenses));
			}
		}

		public IIncome SelectedIncome
		{
			get { return _selectedIncome; }
			set
			{
				_selectedIncome = value;
				OnPropertyChanged(nameof(SelectedIncome));
			}
		}

		public IExpense SelectedExpense
		{
			get { return _selectedExpense; }
			set
			{
				_selectedExpense = value;
				OnPropertyChanged(nameof(SelectedExpense));
			}
		}

		public decimal IncomeTotal
		{
			get { return _incomeTotal; }
			set
			{
				_incomeTotal = value;
				OnPropertyChanged(nameof(IncomeTotal));
			}
		}

		public decimal ExpenseTotal
		{
			get { return _expenseTotal; }
			set
			{
				_expenseTotal = value;
				OnPropertyChanged(nameof(ExpenseTotal));
			}
		}

		public decimal IncomeRecievedTotal
		{
			get { return _incomeRecTotal; }
			set
			{
				_incomeRecTotal = value;
				OnPropertyChanged(nameof(IncomeRecievedTotal));
			}
		}

		public decimal ExpenseRemainingTotal
		{
			get { return _expenseRecTotal; }
			set
			{
				_expenseRecTotal = value;
				OnPropertyChanged(nameof(ExpenseRemainingTotal));
			}
		}

		public decimal TotalsDifference
		{
			get { return _totalsDiff; }
			set
			{
				if (value < (decimal)0)
				{
					_isDiffNeg = true;
				}
				else
				{
					_isDiffNeg = false;
				}
				_totalsDiff = value;
				OnPropertyChanged(nameof(TotalsDifference));
				OnPropertyChanged(nameof(IsDiffNegative));
			}
		}

		public bool IsDiffNegative
		{
			get { return _isDiffNeg; }
			set
			{
				_isDiffNeg = value;
				OnPropertyChanged(nameof(IsDiffNegative));
			}
		}
		#endregion
	}
}
