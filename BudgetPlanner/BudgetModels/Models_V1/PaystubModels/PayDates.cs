using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetModels.Models_V1.PaystubModels
{
    public class PayDates : BaseModel
	{
		#region - Fields & Properties
		private DateTime _start { get; set; }
		private DateTime _end { get; set; }
		private DateTime _payDate { get; set; }
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
		public DateTime Start
		{
			get { return _start; }
			set
			{
				_start = value;
				OnPropertyChanged(nameof(Start));
			}
		}

		public DateTime End
		{
			get { return _end; }
			set
			{
				_end = value;
				OnPropertyChanged(nameof(End));
			}
		}

		public DateTime PayDate
		{
			get { return _payDate; }
			set
			{
				_payDate = value;
				OnPropertyChanged(nameof(PayDate));
			}
		}
		#endregion
	}
}
