using BudgetModels.Models_V1.PaystubModels.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetModels.Models_V1.PaystubModels
{
	public class Paystub : IPaystub
	{
		#region - Fields & Properties
		public decimal GrossPay { get; set; }
		public decimal NetPay { get; set; }
		public decimal TaxDeductions { get; set; }
		public PayDates Period { get; set; }
		#endregion

		#region - Constructors
		public Paystub( ) { }
		#endregion

		#region - Methods

		#endregion

		#region - Full Properties

		#endregion
	}
}
