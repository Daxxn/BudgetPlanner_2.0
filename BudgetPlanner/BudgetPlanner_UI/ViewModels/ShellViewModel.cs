﻿using BudgetPlanner_UI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetPlanner_UI.ViewModels
{
    public class ShellViewModel : ViewModelBase, IViewModel
	{
		#region - Fields & Properties
		private static ShellViewModel _instance;

		#region Nested Views
		public BudgetViewModel BudgetVM { get; set; }
		public PaystubViewModel PaystubVM { get; set; }
		public DebtViewModel DebtVM { get; set; }
		#endregion

		#endregion

		#region - Constructors
		private ShellViewModel( )
		{
			BudgetVM = UIFactory.BuildViewModel<BudgetViewModel>();
			PaystubVM = UIFactory.BuildViewModel<PaystubViewModel>();
			DebtVM = UIFactory.BuildViewModel<DebtViewModel>();
		}
		#endregion

		#region - Methods

		#endregion

		#region - Full Properties
		public static ShellViewModel Instance
		{
			get
			{
				if (_instance is null)
				{
					_instance = new ShellViewModel();
				}
				return _instance;
			}
		}
		#endregion
	}
}