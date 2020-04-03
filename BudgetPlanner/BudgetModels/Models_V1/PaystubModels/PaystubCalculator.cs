using BudgetModels.Models_V1.PaystubModels.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetModels.Models_V1.PaystubModels
{
    public static class PaystubCalculator
	{
		#region - Fields & Properties

		#endregion

		#region - Methods

		#region Totals
		public static (decimal gross, decimal net, decimal tax) CalculateTotals( IEnumerable<IPaystub> paystubs )
		{
			return (paystubs.Sum(x => x.GrossPay),
				paystubs.Sum(x => x.NetPay),
				paystubs.Sum(x => x.TaxDeductions));
		}
		#endregion
		public static (decimal gross, decimal net, decimal tax) CalculateAverages( IEnumerable<IPaystub> paystubs )
		{
			List<decimal> cleanedGross = new List<decimal>(paystubs.Where(x => x.GrossPay != 0).Select(x => x.GrossPay));
			List<decimal> cleanedNet = new List<decimal>(paystubs.Where(x => x.NetPay != 0).Select(x => x.NetPay));
			List<decimal> cleanedTax = new List<decimal>(paystubs.Where(x => x.TaxDeductions != 0).Select(x => x.TaxDeductions));

			return (CalculateAverage(cleanedGross), CalculateAverage(cleanedNet), CalculateAverage(cleanedTax));
		}

		private static decimal CalculateAverage( IEnumerable<decimal> data )
		{
			if (data.Count() != 0)
			{
				return data.Average();
			}
			else
			{
				return 0;
			}
		}

		public static void EstimatePercentage( int selection, IEnumerable<IPaystub> paystubs, decimal avgGross, decimal avgNet, decimal avgTax )
		{
			if (selection >= 0 && selection <= 2)
			{
				foreach (var stub in paystubs)
				{
					stub.EstimateTaxPercent(selection);
				}
			}
			else if (selection == 3)
			{
				EstimateMissingValues(GetLeastCompleteColumn(paystubs), paystubs, avgGross, avgNet, avgTax);
			}
		}

		private static PaystubSelector GetLeastCompleteColumn( IEnumerable<IPaystub> paystubs )
		{
			int grossZeroCount = 0;
			int netZeroCount = 0;
			int incompleteCount = 0;

			foreach (var paystub in paystubs)
			{
				if (paystub.GrossPay == 0 && paystub.NetPay != 0)
				{
					grossZeroCount++;
				}
				else if (paystub.GrossPay != 0 && paystub.NetPay == 0)
				{
					netZeroCount++;
				}
				else if (paystub.GrossPay == 0 && paystub.NetPay == 0)
				{
					incompleteCount++;
				}
			}

			if (grossZeroCount > netZeroCount)
			{
				return PaystubSelector.Gross;
			}
			else if (grossZeroCount < netZeroCount)
			{
				return PaystubSelector.Net;
			}
			else if (incompleteCount > netZeroCount && incompleteCount > grossZeroCount)
			{
				return PaystubSelector.None;
			}
			else
			{
				return PaystubSelector.Tax;
			}
		}

		private static void EstimateMissingValues( PaystubSelector selector, IEnumerable<IPaystub> paystubs, decimal avgGross, decimal avgNet, decimal avgTax )
		{
			foreach (var paystub in paystubs)
			{
				switch (selector)
				{
					case PaystubSelector.Gross:
						if (paystub.GrossPay == 0)
						{
							paystub.GrossPay = avgGross;
						}
						break;
					case PaystubSelector.Net:
						if (paystub.NetPay == 0)
						{
							paystub.NetPay = avgNet;
						}
						break;
					case PaystubSelector.Tax:
						break;
					case PaystubSelector.None:
						break;
					default:
						goto case PaystubSelector.None;
				}
			}
		}
		#endregion

		#region - Full Properties

		#endregion
	}
}
