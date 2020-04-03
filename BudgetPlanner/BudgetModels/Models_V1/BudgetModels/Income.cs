using BudgetModels.Models_V1.BudgetModels.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetModels.Models_V1.BudgetModels
{
	public class Income : BudgetBase, IIncome
	{
		#region - Fields & Properties
		private PayPeriod _period;
		private decimal _amountRecieved;
		private bool _isRecieved;
		#endregion

		#region - Constructors
		public Income( ) { }
		#endregion

		#region - Methods

		#endregion

		#region - Full Properties
		public PayPeriod Period
		{
			get { return _period; }
			set
			{
				_period = value;
				OnPropertyChanged(nameof(Period));
			}
		}

		public decimal AmountRecieved
		{
			get { return _amountRecieved; }
			set
			{
				_amountRecieved = value;
				OnPropertyChanged(nameof(AmountRecieved));
			}
		}

		public bool IsRecieved
		{
			get { return _isRecieved; }
			set
			{
				_isRecieved = value;
				OnPropertyChanged(nameof(IsRecieved));
			}
		}
		#endregion
	}
}
