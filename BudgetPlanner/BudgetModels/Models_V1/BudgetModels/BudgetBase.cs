using BudgetModels.Models_V1.BudgetModels.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetModels.Models_V1.BudgetModels
{
	public class BudgetBase : IBudgetBase
	{
		#region - Fields & Properties
		public int IDNumber { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public decimal Amount { get; set; }
		public DateTime DueDate { get; set; }
		#endregion

		#region - Constructors
		public BudgetBase( ) { }
		#endregion

		#region - Methods

		#endregion

		#region - Full Properties

		#endregion
	}
}
