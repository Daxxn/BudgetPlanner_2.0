using BudgetModels.Models_V1.DebtModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetModels
{
    public static class DebtFactory
	{
		#region - Fields & Properties

		#endregion

		#region - Methods
		public static IDebt BuildDebt( )
		{
			return new Debt
			{
				DebtHistory = new ObservableCollection<IDebtItem>()
			};
		}

		public static IDebtItem BuildDebtItem( )
		{
			return new DebtItem();
		}

		public static IEnumerable<IDebt> BuildTestDebts( int count = 5 )
		{
			return new List<IDebt>()
			{
				new Debt
				{
					Debter = "Test Debt 1",
					AmountOwed = 1100,
					DueDate = null,
					DebtHistory = new ObservableCollection<IDebtItem>()
					{
						new DebtItem
						{
							AmountPayed = 383.40M,
							DatePayed = new DateTime(2020,3,24).Date
						},
						new DebtItem
						{
							AmountPayed = 36.46M,
							DatePayed = new DateTime(2020,3,27).Date
						},
						new DebtItem
						{
							AmountPayed = 362.40M,
							DatePayed = new DateTime(2020,4,1).Date
						}
					}
				},
				new Debt
				{
					Debter = "Test Debt 2",
					AmountOwed = 3060,
					DueDate = DateTime.Now.AddDays(90),
					DebtHistory = new ObservableCollection<IDebtItem>()
					{
						new DebtItem
						{
							AmountPayed = 400,
							DatePayed = DateTime.Now.Date
						}
					}
				}
			};
		}
		#endregion

		#region - Full Properties

		#endregion
	}
}
