using BudgetModels.Models_V1.BudgetModels;
using BudgetModels.Models_V1.BudgetModels.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetModels
{
    public static class BudgetFactory
	{
		#region - Fields & Properties

		#endregion

		#region - Methods
		public static IIncome BuildIncome(  )
		{
			return new Income();
		}

		public static IExpense BuildExpense(  )
		{
			return new Expense();
		}

		public static TBudget BuildBudgetItem<TBudget>(  ) where TBudget : IBudget, new()
		{
			return new TBudget();
		}
		#endregion

		#region - Full Properties

		#endregion
	}
}
