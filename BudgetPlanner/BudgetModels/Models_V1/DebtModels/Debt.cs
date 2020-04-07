using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetModels.Models_V1.DebtModels
{
	public class Debt : BaseModel, IDebt
	{
		#region - Fields & Properties
		private string _debter;
		private decimal _amountOwed;
		private DateTime? _dueDate;
		private ObservableCollection<IDebtItem> _debtHistory;
		private IDebtItem _selectedDebtHistory;
		#endregion

		#region - Constructors
		public Debt( ) { }
		#endregion

		#region - Methods

		#endregion

		#region - Full Properties
		public string Debter
		{
			get { return _debter; }
			set
			{
				_debter = value;
				OnPropertyChanged(nameof(Debter));
			}
		}

		public decimal AmountOwed
		{
			get { return _amountOwed; }
			set
			{
				_amountOwed = value;
				OnPropertyChanged(nameof(AmountOwed));
			}
		}

		public DateTime? DueDate
		{
			get { return _dueDate; }
			set
			{
				_dueDate = value;
				OnPropertyChanged(nameof(DueDate));
			}
		}

		public ObservableCollection<IDebtItem> DebtHistory
		{
			get { return _debtHistory; }
			set
			{
				_debtHistory = value;
				OnPropertyChanged(nameof(DebtHistory));
			}
		}

		public IDebtItem SelectedDebtHistory
		{
			get { return _selectedDebtHistory; }
			set
			{
				_selectedDebtHistory = value;
				OnPropertyChanged(nameof(SelectedDebtHistory));
			}
		}
		#endregion
	}
}
