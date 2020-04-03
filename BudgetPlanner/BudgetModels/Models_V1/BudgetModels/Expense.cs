using BudgetModels.Models_V1.BudgetModels.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetModels.Models_V1.BudgetModels
{
	public class Expense : BudgetBase, IExpense
	{
		#region - Fields & Properties
		private decimal _remainingAmount;
		private decimal _amountPayed;
		private bool _isPayedOff;
		private bool _isPayedOnce;
		#endregion

		#region - Constructors
		public Expense( ) { }
		#endregion

		#region - Methods
		public void CalcRemainingFromPayed(  )
		{
			decimal tempRem = Amount - AmountPayed;

			if (tempRem <= 0)
			{
				IsPayedOff = true;
				RemainingAmount = 0;
			}
			else
			{
				IsPayedOff = false;
				RemainingAmount = tempRem;
			}
		}
		#endregion

		#region - Full Properties
		public decimal RemainingAmount
		{
			get { return _remainingAmount; }
			set
			{
				_remainingAmount = value;
				OnPropertyChanged(nameof(RemainingAmount));
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

		public bool IsPayedOff
		{
			get { return _isPayedOff; }
			set
			{
				_isPayedOff = value;
				OnPropertyChanged(nameof(IsPayedOff));
			}
		}

		public bool IsPayedOnce
		{
			get { return _isPayedOnce; }
			set
			{
				_isPayedOnce = value;
				OnPropertyChanged(nameof(IsPayedOnce));
			}
		}
		#endregion
	}
}
