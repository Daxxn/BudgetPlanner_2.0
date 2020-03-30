﻿using BudgetModels.Models_V1.BudgetInterfaces;
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
		public bool IsPayedOff { get; set; }
		public bool IsPayedInFull { get; set; }
		#endregion

		#region - Constructors
		public Expense( ) { }
		#endregion

		#region - Methods

		#endregion

		#region - Full Properties

		#endregion
	}
}
