using BudgetPlanner_UI.ViewModels;
using BudgetPlanner_UI.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetPlanner_UI
{
    public static class UIFactory
	{
		#region - Fields & Properties

		#endregion

		#region - Methods
		public static ShellView BuildShellView( ShellViewModel vm )
		{
			return new ShellView(vm);
		}

		public static ShellViewModel BuildShellViewModel(  )
		{
			return new ShellViewModel();
		}
		#endregion

		#region - Full Properties

		#endregion
	}
}
