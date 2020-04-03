using BudgetModels.Models_V1.PaystubModels.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetPlanner_UI.CustomEventArgs
{
    public class FinishAddNewPaystubEventArgs : EventArgs
	{
		#region - Fields & Properties
		public IEnumerable<IPaystub> Paystubs { get; private set; }
		public bool ReplaceOld { get; private set; }
		#endregion

		#region - Constructors
		public FinishAddNewPaystubEventArgs( IEnumerable<IPaystub> paystubs, bool replaceOld )
		{
			Paystubs = paystubs;
			ReplaceOld = replaceOld;
		}
		#endregion
	}
}
