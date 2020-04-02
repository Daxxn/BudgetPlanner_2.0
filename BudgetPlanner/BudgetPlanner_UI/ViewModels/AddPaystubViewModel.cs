using BudgetModels.Models_V1.PaystubModels.Interfaces;
using BudgetPlanner_UI.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetPlanner_UI.ViewModels
{
    public class AddPaystubViewModel : ViewModelBase, IViewModel
	{
		#region - Fields & Properties
		private double _screenWidthPos;
		public ObservableCollection<IPaystub> _newPaystubs;
		#endregion

		#region - Constructors
		public AddPaystubViewModel( )
		{
			ScreenWidthPos = ShellViewModel.WindowWidth / 2;
		}
		#endregion

		#region - Methods

		#endregion

		#region - Full Properties
		public ObservableCollection<IPaystub> NewPaystubs
		{
			get { return _newPaystubs; }
			set
			{
				_newPaystubs = value;
				OnPropertyChanged(nameof(NewPaystubs));
			}
		}

		public double ScreenWidthPos
		{
			get { return _screenWidthPos; }
			set
			{
				_screenWidthPos = value;
				OnPropertyChanged(nameof(ScreenWidthPos));
			}
		}
		#endregion
	}
}
