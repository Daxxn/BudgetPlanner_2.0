using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetModels.Models_V1.DebtModels
{
	public class DebtItem : BaseModel, IDebtItem
	{
		#region - Fields & Properties
		private IDebt _parent;
		private decimal _amountPayed;
		private DateTime _datePayed;
		#endregion

		#region - Constructors
		public DebtItem( ) { }
		#endregion

		#region - Methods

		#endregion

		#region - Full Properties
		public IDebt Parent
		{
			get { return _parent; }
			set
			{
				_parent = value;
				OnPropertyChanged(nameof(Parent));
			}
		}

		public decimal AmountPayed
		{
			get { return _amountPayed; }
			set
			{
				_amountPayed = value;
				OnPropertyChanged(nameof(AmountPayed));
			}
		}

		public DateTime DatePayed
		{
			get { return _datePayed; }
			set
			{
				_datePayed = value;
				OnPropertyChanged(nameof(DatePayed));
			}
		}
		#endregion
	}
}
