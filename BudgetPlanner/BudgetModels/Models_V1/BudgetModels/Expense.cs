using BudgetModels.Models_V1.BudgetInterfaces;
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
		public decimal RemainingAmount { get; set; }
		public decimal AmountPayed { get; set; }
		public bool IsPayedOff { get; set; }
		public bool IsPayedOnce { get; set; }
		//public DateTime DueDate { get; set; }
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

		#endregion
	}
}
