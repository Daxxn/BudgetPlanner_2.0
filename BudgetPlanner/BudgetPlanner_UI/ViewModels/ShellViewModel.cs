using BudgetPlanner_UI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using StateControl.FileControl;
using StateControl.StateControl;
using BudgetModels.Models_V1.BudgetModels;

namespace BudgetPlanner_UI.ViewModels
{
    public class ShellViewModel : ViewModelBase, IViewModel
	{
		#region - Fields & Properties
		private static ShellViewModel _instance;
		private string _currentPath;

		// Test Path:
		// C:\Users\Cody\Desktop\BudgetPlannerFileTesting\BudgetPlanner2Tests
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

		public void NewEvent( object sender, EventArgs e )
		{
			BudgetVM.New();
			PaystubVM.New();
			DebtVM.New();
		}

		public void OpenEvent( object sender, RoutedEventArgs e )
		{
			string openPath = OpenFileController.OpenFile();

			(string message, SaveState state) openFile = OpenController.Open(openPath);

			if (openFile.message != null)
			{
				MessageBox.Show(openFile.message);
			}

			if (openFile.state != null)
			{
				OpenModels(openFile.state);
			}
		}

		public void SaveEvent( object sender, RoutedEventArgs e )
		{
			if (String.IsNullOrEmpty(CurrentPath))
			{
				CurrentPath = SaveFileController.SaveDialog();
			}

			SaveState state = SaveController.BuildSaveState(
				Instance.BudgetVM.IncomeDataList,
				Instance.BudgetVM.ExpenseDataList,
				Instance.PaystubVM.PaystubDataList,
				Instance.DebtVM.DebtDataList
				);

			string errorMessage = SaveController.Save(CurrentPath, state);

			if (errorMessage != null)
			{
				MessageBox.Show(errorMessage);
			}
		}

		public void SaveAsEvent( object sender, RoutedEventArgs e )
		{
			CurrentPath = SaveFileController.SaveDialog();

			SaveState state = SaveController.BuildSaveState(
				Instance.BudgetVM.IncomeDataList,
				Instance.BudgetVM.ExpenseDataList,
				Instance.PaystubVM.PaystubDataList,
				Instance.DebtVM.DebtDataList
				);

			string errorMessage = SaveController.Save(CurrentPath, state);

			if (errorMessage != null)
			{
				MessageBox.Show(errorMessage);
			}
		}
		#endregion

		private void OpenModels( SaveState state )
		{
			BudgetVM.OpenData(state.Budget);
			PaystubVM.OpenData(state.Paystub);
			DebtVM.OpenData(state.Debt);
		}

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

		public string CurrentPath
		{
			get { return _currentPath; }
			set
			{
				_currentPath = value;
				OnPropertyChanged(nameof(CurrentPath));
			}
		}
		#endregion
	}
}
