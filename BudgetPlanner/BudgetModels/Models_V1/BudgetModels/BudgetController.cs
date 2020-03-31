using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetModels.Models_V1.BudgetModels
{
    public static class BudgetController
	{
		#region - Fields & Properties

		#endregion

		#region - Methods
		public static IEnumerable<Expense> SortDueExpenses( IEnumerable<Expense> expenses )
		{
			List<Expense> output = new List<Expense>();

			foreach (var d in expenses)
			{
				if (d.DueDate.CompareTo(DateTime.Today) > 0)
				{
					output.Add(d);
				}
			}

			return output.OrderBy(x => x.DueDate.Date);
		}

		public static IEnumerable<TBudget> SortDueExpenses<TBudget>( IEnumerable<TBudget> budgetData, bool isFuture ) where TBudget : BudgetBase
		{
			List<TBudget> output = new List<TBudget>();

			if (isFuture)
			{
				foreach (var d in budgetData)
				{
					if (d.DueDate.CompareTo(DateTime.Today) >= 0)
					{
						output.Add(d);
					}
				}
				return output.OrderBy(x => x.DueDate.Date);
			}
			else
			{
				foreach (var d in budgetData)
				{
					if (d.DueDate.CompareTo(DateTime.Today) < 0)
					{
						output.Add(d);
					}
				}
				return output.OrderByDescending(x => x.DueDate.Date);
			}

			//return output.OrderBy(x => x.DueDate.Date);
		}

		#region Example
		public static IEnumerable<DateTime> OrderSortDates( IEnumerable<DateTime> dates )
		{

			List<DateTime> output = new List<DateTime>();

			foreach (var d in dates)
			{
				if (d.CompareTo(DateTime.Today) > 0)
				{
					output.Add(d);
				}
			}

			return output.OrderBy(x => x.Date);
		}
		#endregion
		#endregion

		#region - Full Properties

		#endregion
	}
}
