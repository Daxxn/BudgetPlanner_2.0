using BudgetModels;
using BudgetModels.Models_V1.PaystubModels;
using BudgetModels.Models_V1.PaystubModels.Interfaces;
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
    public class PaystubViewModel : ViewModelBase, IViewModel
	{
		#region - Fields & Properties

		#region Nested ViewModels
		public AddPaystubViewModel AddPaystubVM { get; set; }
		#endregion

		private ObservableCollection<IPaystub> _paystuDataList;

		private decimal _totalGross;
		private decimal _totalNet;
		private decimal _totalTax;

		private decimal _averageGross;
		private decimal _averageNet;
		private decimal _averageTax;
		#endregion

		#region - Constructors
		public PaystubViewModel( )
		{
			#region Paystub Testing
			PaystubDataList = new ObservableCollection<IPaystub>(PaystubFactory.BuildTestPaystubs());
			#endregion
		}
		#endregion

		#region - Methods

		#region Event Handlers
		public void AddManyEvent( object sender, RoutedEventArgs e )
		{
			AddPaystubVM = new AddPaystubViewModel();
		}

		public void AddOneEvent( object sender, RoutedEventArgs e )
		{

		}

		public void DeleteOne( object sender, RoutedEventArgs e )
		{

		}
		#endregion

		#endregion

		#region - Full Properties
		public ObservableCollection<IPaystub> PaystubDataList
		{
			get { return _paystuDataList; }
			set
			{
				_paystuDataList = value;
				OnPropertyChanged(nameof(PaystubDataList));
			}
		}

		public decimal TotalGross
		{
			get { return _totalGross; }
			set
			{
				_totalGross = value;
				OnPropertyChanged(nameof(TotalGross));
			}
		}

		public decimal TotalNet
		{
			get { return _totalNet; }
			set
			{
				_totalNet = value;
				OnPropertyChanged(nameof(TotalNet));
			}
		}

		public decimal TotalTax
		{
			get { return _totalTax; }
			set
			{
				_totalTax = value;
				OnPropertyChanged(nameof(TotalTax));
			}
		}

		public decimal AverageGross
		{
			get { return _averageGross; }
			set
			{
				_averageGross = value;
				OnPropertyChanged(nameof(AverageGross));
			}
		}

		public decimal AverageNet
		{
			get { return _averageNet; }
			set
			{
				_averageNet = value;
				OnPropertyChanged(nameof(AverageNet));
			}
		}

		public decimal AverageTax
		{
			get { return _averageTax; }
			set
			{
				_averageTax = value;
				OnPropertyChanged(nameof(AverageTax));
			}
		}
		#endregion
	}
}
