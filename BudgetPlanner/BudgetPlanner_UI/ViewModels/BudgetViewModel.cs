using BudgetPlanner_UI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetPlanner_UI.ViewModels
{
    public class BudgetViewModel : ViewModelBase, IViewModel
	{
		#region - Fields & Properties
		public int _test = 42;
		#endregion

		#region - Constructors
		public BudgetViewModel( ) { }
		#endregion

		#region - Methods

		#endregion

		#region - Full Properties
		public int Test
		{
			get { return _test; }
			set
			{
				_test = value;
				OnPropertyChanged(nameof(Test));
			}
		}
		#endregion
	}
}
