using BudgetModels.Models_V1.PaystubModels.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetModels.Models_V1.PaystubModels
{
	public class Paystub : BaseModel, IPaystub
	{
		#region - Fields & Properties
		private decimal _grossPay;
		private decimal _netPay;
		private decimal _taxDeductions;
		private decimal _taxPercentage;
		private double _hours;
		private bool _isEstimated = false;
		private PayDates _period;
		#endregion

		#region - Constructors
		public Paystub( ) { }
		#endregion

		#region - Methods
		public void EstimateTaxPercent( int selection )
		{
			if ( selection == 0 )
			{
				TaxPercentage = PercentageCalculator.CalcPercent(GrossPay, NetPay);
			}
			else if ( selection == 1 )
			{
				GrossPay = PercentageCalculator.CalcTotal(NetPay, TaxPercentage);
			}
			else if ( selection == 2)
			{
				NetPay = PercentageCalculator.CalcDiff(GrossPay, TaxPercentage);
			}
			else if (selection == 3)
			{

			}
			else
			{
				throw new ArgumentException("Selector outside possible range.", nameof(selection));
			}
		}

		public void EstimateTaxAmount( int selector )
		{
			if (selector == 0)
			{

			}
			else if (selector == 1)
			{

			}
			else if (selector == 2)
			{

			}
			else if (selector == 3)
			{

			}
		}
		#endregion

		#region - Full Properties
		public decimal GrossPay
		{
			get { return _grossPay; }
			set
			{
				_grossPay = value;
				OnPropertyChanged(nameof(GrossPay));
			}
		}

		public decimal NetPay
		{
			get { return _netPay; }
			set
			{
				_netPay = value;
				OnPropertyChanged(nameof(NetPay));
			}
		}

		public decimal TaxDeductions
		{
			get { return _taxDeductions; }
			set
			{
				_taxDeductions = value;
				OnPropertyChanged(nameof(TaxDeductions));
			}
		}

		public decimal TaxPercentage
		{
			get { return _taxPercentage; }
			set
			{
				_taxPercentage = value;
				OnPropertyChanged(nameof(TaxPercentage));
			}
		}

		public double Hours
		{
			get { return _hours; }
			set
			{
				_hours = value;
				OnPropertyChanged(nameof(Hours));
			}
		}

		public bool IsEstimated
		{
			get { return _isEstimated; }
			set
			{
				_isEstimated = value;
				OnPropertyChanged(nameof(IsEstimated));
			}
		}

		public PayDates Period
		{
			get { return _period; }
			set
			{
				_period = value;
				OnPropertyChanged(nameof(Period));
			}
		}
		#endregion
	}
}
