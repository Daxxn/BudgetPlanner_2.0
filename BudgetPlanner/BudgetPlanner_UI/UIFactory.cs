using BudgetPlanner_UI.Interfaces;
using BudgetPlanner_UI.ViewModels;
using BudgetPlanner_UI.Views;
using System.Reflection;
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
		public static TView BuildView<TView, TViewModel>( TViewModel vm ) where TView : IView
		{
			var viewType = typeof(TView);
			var ctor = viewType.GetConstructor(new Type[] { typeof(TViewModel) });
			return (TView)ctor.Invoke(new object[] { vm });
		}
		
		public static TViewModel BuildViewModel<TViewModel>( ) where TViewModel : IViewModel
		{
			var type = typeof(TViewModel);
			var ctor = type.GetConstructor(Type.EmptyTypes);
			return (TViewModel)ctor.Invoke(null);
		}
		#endregion

		#region - Full Properties

		#endregion
	}
}
