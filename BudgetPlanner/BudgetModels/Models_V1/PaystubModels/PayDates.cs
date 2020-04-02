using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetModels.Models_V1.PaystubModels
{
    public struct PayDates
	{
		#region - Fields & Properties
		public DateTime Start { get; set; }
		public DateTime End { get; set; }
		public DateTime PayDate { get; set; }
		#endregion

		#region - Constructors
		public PayDates( DateTime start, DateTime end, DateTime pay )
		{
			Start = start;
			End = end;
			PayDate = pay;
		}
		#endregion

		#region - Methods

		#endregion

		#region - Full Properties

		#endregion
	}
}
