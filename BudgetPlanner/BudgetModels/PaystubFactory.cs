using BudgetModels.Models_V1.PaystubModels;
using BudgetModels.Models_V1.PaystubModels.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetModels
{
    public static class PaystubFactory
	{
		#region - Fields & Properties

		#endregion

		#region - Methods
		public static IPaystub BuildPaystub(  )
		{
			return new Paystub();
		}

		public static IEnumerable<IPaystub> BuildTestPaystubs_1( int count = 10 )
		{
			Random rng = new Random();
			List<Paystub> output = new List<Paystub>();

			for (int i = 0; i < count; i++)
			{
				int gross = rng.Next(1, 999);
				int grossDecimal = rng.Next(0, 99);
				decimal grossTemp = (decimal)gross;
				grossTemp += (decimal)grossDecimal * (decimal)0.01;

				output.Add(new Paystub
				{
					GrossPay = grossTemp,
					NetPay = grossTemp / 2,
					Period = new PayDates(DateTime.Now.AddDays(i), DateTime.Now.AddDays(i + 7), DateTime.Now.AddDays(i + (7 * 2)))
				});
			}

			return output;
		}

		public static IEnumerable<IPaystub> BuildTestPaystubs_2( int count = 10 )
		{
			Random rng = new Random();
			List<Paystub> output = new List<Paystub>();

			for (int i = 0; i < count; i++)
			{
				int gross = rng.Next(1, 999);
				int grossDecimal = rng.Next(0, 99);
				decimal grossTemp = (decimal)gross;
				grossTemp += (decimal)grossDecimal * (decimal)0.01;

				output.Add(new Paystub
				{
					GrossPay = grossTemp,
					NetPay = 0,
					Period = new PayDates(DateTime.Now.AddDays(i), DateTime.Now.AddDays(i + 7), DateTime.Now.AddDays(i + (7 * 2)))
				});
			}

			for (int i = 0; i < count / 4; i++)
			{
				output[ i ].NetPay = output[ i ].GrossPay / 2;
			}

			return output;
		}
		#endregion

		#region - Full Properties

		#endregion
	}
}
