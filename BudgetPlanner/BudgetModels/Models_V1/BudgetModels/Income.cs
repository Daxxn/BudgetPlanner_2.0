using BudgetModels.Models_V1.BudgetInterfaces;
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
		public PayPeriod Period { get; set; }
		public decimal AmountRecieved { get; set; }
		public bool IsRecieved { get; set; }
		#endregion

		#region - Constructors
		public Income( ) { }
		#endregion

		#region - Methods

		#endregion

		#region - Full Properties

		#endregion
	}
}
