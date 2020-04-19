using BudgetModels.Models_V1.BudgetModels.Interfaces;
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
		public static IEnumerable<IExpense> SortDueExpenses( IEnumerable<IExpense> expenses, bool isFuture )
		{
			List<IExpense> output = new List<IExpense>();

			if (isFuture)
			{
				foreach (var d in expenses)
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
				foreach (var d in expenses)
				{
					if (d.DueDate.CompareTo(DateTime.Today) < 0)
					{
						output.Add(d);
					}
				}
			}

			return output.OrderBy(x => x.DueDate.Date);
		}
		public static IEnumerable<IIncome> SortDueIncome( IEnumerable<IIncome> incomes, bool isFuture )
		{
			List<IIncome> output = new List<IIncome>();

			if (isFuture)
			{
				foreach (var d in incomes)
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
				foreach (var d in incomes)
				{
					if (d.DueDate.CompareTo(DateTime.Today) < 0)
					{
						output.Add(d);
					}
				}
				return output.OrderBy(x => x.DueDate.Date);
			}
		}

		//public static IEnumerable<TBudget> SortDueExpenses<TBudget>( IEnumerable<TBudget> budgetData, bool isFuture ) where TBudget : IBudgetBase
		//{
		//	List<TBudget> output = new List<TBudget>();

		//	if (isFuture)
		//	{
		//		foreach (var d in budgetData)
		//		{
		//			if (d.DueDate.CompareTo(DateTime.Today) >= 0)
		//			{
		//				output.Add(d);
		//			}
		//		}
		//		return output.OrderBy(x => x.DueDate.Date);
		//	}
		//	else
		//	{
		//		foreach (var d in budgetData)
		//		{
		//			if (d.DueDate.CompareTo(DateTime.Today) < 0)
		//			{
		//				output.Add(d);
		//			}
		//		}
		//		return output.OrderByDescending(x => x.DueDate.Date);
		//	}

		//	//return output.OrderBy(x => x.DueDate.Date);
		//}

		//public static IEnumerable<IExpense> SortDueExpenses( IEnumerable<IExpense> expenses )
		//{
		//	List<Expense> output = new List<Expense>();

		//	foreach (var d in expenses)
		//	{
		//		if (d.DueDate.CompareTo(DateTime.Today) > 0)
		//		{
		//			output.Add((Expense)d);
		//		}
		//	}

		//	return output.OrderBy(x => x.DueDate.Date);
		//}
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
