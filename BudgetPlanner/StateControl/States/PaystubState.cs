using BudgetModels.Models_V1.PaystubModels;
using BudgetModels.Models_V1.PaystubModels.Interfaces;
using StateControl.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateControl.States
{
    public class PaystubState : IState
	{
		#region - Fields & Properties
		public IEnumerable<Paystub> PaystubData { get; set; }
		#endregion

		#region - Constructors
		public PaystubState( IEnumerable<Paystub> paystubData )
		{
			PaystubData = paystubData;
		}
		#endregion

		#region - Methods

		#endregion

		#region - Full Properties

		#endregion
	}
}
