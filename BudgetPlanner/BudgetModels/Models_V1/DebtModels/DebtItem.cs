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
		private decimal _amountPayed { get; set; }
		private DateTime _datePayed { get; set; }
		#endregion

		#region - Constructors
		public DebtItem( ) { }
		#endregion

		#region - Methods

		#endregion

		#region - Full Properties
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
