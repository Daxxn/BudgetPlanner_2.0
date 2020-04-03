using BudgetModels;
using BudgetModels.Models_V1.PaystubModels.Interfaces;
using BudgetPlanner_UI.CustomEventArgs;
using BudgetPlanner_UI.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BudgetPlanner_UI.ViewModels
{
    public class AddPaystubViewModel : ViewModelBase, IViewModel
	{
		#region - Fields & Properties

		#region Events
		public event EventHandler<FinishAddNewPaystubEventArgs> FinishEvent;
		#endregion

		private ObservableCollection<IPaystub> _newPaystubs;
		private IPaystub _selectedPaystub;

		private IPaystub _newPaystub;

		private bool _replaceOldPaystubs;
		#endregion

		#region - Constructors
		public AddPaystubViewModel( )
		{
			NewPaystubs = new ObservableCollection<IPaystub>();
			NewPaystub = PaystubFactory.BuildPaystub();
			FinishEvent += ShellViewModel.Instance.PaystubVM.FinishEvent;
		}
		#endregion

		#region - Methods

		#region Event Handlers
		public void AddNetPaystubEvent( object sender, RoutedEventArgs e )
		{
			NewPaystubs.Add(NewPaystub);
			NewPaystub = PaystubFactory.BuildPaystub();
		}

		public void FinishCloseEvent( object sender, RoutedEventArgs e )
		{
			FinishEvent?.Invoke(this, new FinishAddNewPaystubEventArgs(NewPaystubs, ReplaceOldPaystubs));
		}
		#endregion
		
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

		public IPaystub SelectedPaystub
		{
			get { return _selectedPaystub; }
			set
			{
				_selectedPaystub = value;
				OnPropertyChanged(nameof(SelectedPaystub));
			}
		}

		public IPaystub NewPaystub
		{
			get { return _newPaystub; }
			set
			{
				_newPaystub = value;
				OnPropertyChanged(nameof(NewPaystub));
			}
		}

		public bool ReplaceOldPaystubs
		{
			get { return _replaceOldPaystubs; }
			set
			{
				_replaceOldPaystubs = value;
				OnPropertyChanged(nameof(ReplaceOldPaystubs));
			}
		}
		#endregion
	}
}
