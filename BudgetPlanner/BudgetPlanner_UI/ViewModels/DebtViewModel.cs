using BudgetModels;
using BudgetModels.Models_V1.DebtModels;
using BudgetPlanner_UI.Interfaces;
using StateControl.Interfaces;
using StateControl.States;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BudgetPlanner_UI.ViewModels
{
    public class DebtViewModel : ViewModelBase, IViewModel
	{
		#region - Fields & Properties
		private ObservableCollection<IDebt> _debtDataList;
		private IDebt _selectedDebt;
		private IDebtItem _selectedDebtHist;
		#endregion

		#region - Constructors
		public DebtViewModel( )
		{
			#region Testing
			DebtDataList = new ObservableCollection<IDebt>( DebtFactory.BuildTestDebts() );
			#endregion
		}
		#endregion

		#region - Methods
		#region Event Handlers
		public void AddDebtEvent( object sender, RoutedEventArgs e )
		{
			AddDebt();
		}

		public void DeleteDebtEvent( object sender, RoutedEventArgs e )
		{
			DeleteDebt();
		}

		public void AddDebtItemEvent( object sender, RoutedEventArgs e )
		{
			AddDebtItem();
		}

		public void DeleteDebtItemEvent( object sender, RoutedEventArgs e )
		{
			DeleteDebtItem();
		}

		public void SelectedMainValueChangedEvent( object sender, RoutedPropertyChangedEventArgs<object> e )
		{
			if (e.NewValue != null)
			{
				SelectedDebt = e.NewValue as IDebt;
			}
		}
		#endregion

		public void AddDebt( )
		{
			IDebt temp = DebtFactory.BuildDebt();
			DebtDataList.Add(temp);
			SelectedDebt = temp;

			AddDebtItem();
		}

		public void DeleteDebt( )
		{
			DebtDataList.Remove(SelectedDebt);
		}

		public void AddDebtItem( )
		{
			if (SelectedDebt != null)
			{
				IDebtItem temp = DebtFactory.BuildDebtItem();
				SelectedDebt.DebtHistory.Add(temp);
				SelectedDebt.SelectedDebtHistory = temp;
			}
		}

		public void DeleteDebtItem( )
		{
			SelectedDebt.DebtHistory.Remove(SelectedDebt.SelectedDebtHistory);
		}

		public override void OpenData( IState data )
		{
			var debtData = data as DebtState;
			DebtDataList = new ObservableCollection<IDebt>( debtData.DebtData);
		}

		public override void Clear( )
		{
			DebtDataList = null;
			SelectedDebt = null;
			SelectedDebtHistory = null;
		}

		public override void New( )
		{
			Clear();
			DebtDataList = new ObservableCollection<IDebt>();
			AddDebt();
		}
		#endregion

		#region - Full Properties
		public ObservableCollection<IDebt> DebtDataList
		{
			get { return _debtDataList; }
			set
			{
				_debtDataList = value;
				OnPropertyChanged(nameof(DebtDataList));
			}
		}

		public IDebt SelectedDebt
		{
			get { return _selectedDebt; }
			set
			{
				_selectedDebt = value;
				OnPropertyChanged(nameof(SelectedDebt));
			}
		}

		public IDebtItem SelectedDebtHistory
		{
			get { return _selectedDebtHist; }
			set
			{
				_selectedDebtHist = value;
				OnPropertyChanged(nameof(SelectedDebtHistory));
			}
		}
		#endregion
	}
}
