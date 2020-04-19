using BudgetModels.Models_V1.BudgetModels;
using BudgetModels.Models_V1.BudgetModels.Interfaces;
using StateControl.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateControl.States
{
    public class BudgetState : IState
	{
		#region - Fields & Properties
		public List<Income> IncomeData { get; set; }
		public List<Expense> ExpenseData { get; set; }
		#endregion

		#region - Constructors
		public BudgetState( IEnumerable<Income> incomeData, IEnumerable<Expense> expenseData )
		{
			IncomeData = incomeData.ToList();
			ExpenseData = expenseData.ToList();
		}
		#endregion

		#region - Methods

		#endregion

		#region - Full Properties

		#endregion
	}
}
