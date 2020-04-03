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
		public decimal GrossPay { get; set; }
		public decimal NetPay { get; set; }
		public decimal TaxDeductions { get; set; }
		private decimal _taxPercentage;
		public double Hours { get; set; }
		public bool IsEstimated { get; set; } = false;
		public PayDates Period { get; set; }
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
		public decimal TaxPercentage
		{
			get { return _taxPercentage; }
			set
			{
				_taxPercentage = value;
				OnPropertyChanged(nameof(TaxPercentage));
			}
		}
		#endregion
	}
}
