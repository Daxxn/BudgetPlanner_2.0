using BudgetPlanner_UI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BudgetPlanner_UI.ViewModels
{
    public class ShellViewModel : ViewModelBase, IViewModel
	{
		#region - Fields & Properties
		private static ShellViewModel _instance;
		public static double WindowWidth { get; set; }

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

		#region Event Handlers
		public void KeyUpEvent( object sender, KeyEventArgs e )
		{
			BudgetVM.KeyUpEvent(sender, e);
		}
		#endregion

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
