using BudgetModels;
using BudgetModels.Models_V1.PaystubModels;
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
    public class PaystubViewModel : ViewModelBase, IViewModel
	{
		#region - Fields & Properties

		#region Events

		#endregion

		#region Nested ViewModels
		public AddPaystubViewModel AddPaystubVM { get; set; }
		#endregion

		private ObservableCollection<IPaystub> _paystubDataList;
		private IPaystub _selectedPaystub;

		private decimal _totalGross;
		private decimal _totalNet;
		private decimal _totalTax;

		private decimal _averageGross;
		private decimal _averageNet;
		private decimal _averageTax;
		private decimal _averageTaxPercent;
		#endregion

		#region - Constructors
		public PaystubViewModel( )
		{
			#region Paystub Testing
			PaystubDataList = new ObservableCollection<IPaystub>(PaystubFactory.BuildTestPaystubs_2());
			#endregion
		}

		#endregion

		#region - Methods

		#region Event Handlers
		public void FinishEvent( object sender, FinishAddNewPaystubEventArgs e )
		{
			if (e.ReplaceOld)
			{
				PaystubDataList = new ObservableCollection<IPaystub>(e.Paystubs);
			}
			else
			{
				AddToPaystubDataList(e.Paystubs);
			}
			DataListUpdateEvent(this, null);
		}

		public void AddManyEvent( object sender, RoutedEventArgs e )
		{
			AddPaystubVM = new AddPaystubViewModel();
		}

		public void AddOneEvent( object sender, RoutedEventArgs e )
		{
			PaystubDataList.Add(PaystubFactory.BuildPaystub());
		}

		public void DeleteOneEvent( object sender, RoutedEventArgs e )
		{
			if (SelectedPaystub != null)
			{
				PaystubDataList.Remove(SelectedPaystub);
			}
		}

		public void DataListUpdateEvent( object sender, EventArgs e )
		{
			SetTotals(PaystubCalculator.CalculateTotals(PaystubDataList));
		}
		#endregion

		private void AddToPaystubDataList( IEnumerable<IPaystub> paystubs )
		{
			foreach (var paystub in paystubs)
			{
				PaystubDataList.Add(paystub);
			}
		}

        public void RunEstimateEvent( object sender, TaxEstimateEventArgs e )
		{
			RunEstimate(e.SelectionIndex);
		}

		public void RunAveragesEvent( object sender, RoutedEventArgs e )
		{
			RunAverages();
		}

		#region Caclulations
		private void RunEstimate( int selection )
		{
			SetTotals(PaystubCalculator.CalculateTotals(PaystubDataList));
			SetAverages(PaystubCalculator.CalculateAverages(PaystubDataList));

			PaystubCalculator.EstimatePercentage(
				selection,
				PaystubDataList,
				AverageGross,
				AverageNet,
				AverageTax
			);
		}

		private void RunAverages( )
		{
			SetTotals(PaystubCalculator.CalculateTotals(PaystubDataList));
			SetAverages(PaystubCalculator.CalculateAverages(PaystubDataList));
		}
		#endregion

		#region Other Methods
		private void SetTotals( (decimal gross, decimal net, decimal tax) result )
		{
			TotalGross = result.gross;
			TotalNet = result.net;
			TotalTax = result.tax;
		}

		private void SetAverages( (decimal gross, decimal net, decimal tax) result )
		{
			AverageGross = result.gross;
			AverageNet = result.net;
			AverageTax = result.tax;
		}
		#endregion
		#endregion

		#region - Full Properties
		public ObservableCollection<IPaystub> PaystubDataList
		{
			get { return _paystubDataList; }
			set
			{
				_paystubDataList = value;
				OnPropertyChanged(nameof(PaystubDataList));
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

		public decimal AverageTaxPercent
		{
			get { return _averageTaxPercent; }
			set
			{
				_averageTaxPercent = value;
				OnPropertyChanged(nameof(AverageTaxPercent));
			}
		}
		#endregion
	}
}
