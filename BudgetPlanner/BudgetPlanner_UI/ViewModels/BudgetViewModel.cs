using BudgetModels.Models_V1.BudgetModels;
using BudgetPlanner_UI.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace BudgetPlanner_UI.ViewModels
{
    public class BudgetViewModel : ViewModelBase, IViewModel
	{
		#region - Fields & Properties
		public ObservableCollection<Income> _incomeDataList;
		public ObservableCollection<Expense> _expenseDataList;

		public Income _selectedIncome;
		public Expense _selectedExpense;

		private decimal _incomeTotal;
		private decimal _expenseTotal;
		private decimal _incomeRecTotal;
		private decimal _expenseRecTotal;
		#endregion

		#region - Constructors
		public BudgetViewModel( )
		{
			#region Quick Binding Test
			IncomeDataList = new ObservableCollection<Income>()
			{
				new Income
				{
					IDNumber = 1,
					Title = "test 1",
					Amount = 42.4M,
					AmountRecieved = 22.7M,
					Description = "test Income 1",
					IsRecieved = false,
					Period = PayPeriod.Once
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

			ExpenseDataList = new ObservableCollection<Expense>()
			{
				new Expense
				{
					IDNumber = 1,
					Title = "Test 1",
					Amount = 42.42M,
					RemainingAmount = 24.24M,
					Description = "Test Expense 1",
					IsPayedOff = false,
					IsPayedInFull = false,
					DueDate = DateTime.Now.AddMonths(2)
				},
				new Expense
				{
					IDNumber = 2,
					Title = "Test 2",
					Amount = 1200,
					RemainingAmount = 383.40M,
					Description = "Test Expense 2",
					IsPayedOff = false,
					IsPayedInFull = false,
					DueDate = DateTime.Now.AddDays(7)
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
		}

		public void ExpenseCellChangedEvent( object sender, EventArgs e )
		{
			CalculateAmountTotal(false);
			CalculateRemainingAmountTotal();
		}
		#endregion
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
        #endregion

        #region - Full Properties
        public ObservableCollection<Income> IncomeDataList
		{
			get { return _incomeDataList; }
			set
			{
				_incomeDataList = value;
				OnPropertyChanged(nameof(IncomeDataList));
			}
		}

		public ObservableCollection<Expense> ExpenseDataList
		{
			get { return _expenseDataList; }
			set
			{
				_expenseDataList = value;
				OnPropertyChanged(nameof(ExpenseDataList));
			}
		}

		public Income SelectedIncome
		{
			get { return _selectedIncome; }
			set
			{
				_selectedIncome = value;
				OnPropertyChanged(nameof(SelectedIncome));
			}
		}

		public Expense SelectedExpense
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
		#endregion
	}
}
