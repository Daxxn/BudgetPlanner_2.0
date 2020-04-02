using BudgetModels.Models_V1.BudgetModels.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateControl.States
{
    public class BudgetState
	{
		#region - Fields & Properties
		public List<IIncome> IncomeData { get; set; }
		public List<IExpense> ExpenseData { get; set; }
		#endregion

		#region - Constructors
		public BudgetState( IEnumerable<IIncome> incomeData, IEnumerable<IExpense> expenseData )
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
