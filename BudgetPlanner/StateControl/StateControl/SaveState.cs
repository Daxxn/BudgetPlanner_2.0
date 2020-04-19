using StateControl.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateControl.StateControl
{
    public class SaveState
	{
		#region - Fields & Properties
		public BudgetState Budget { get; set; }
		public PaystubState Paystub { get; set; }
		public DebtState Debt { get; set; }
		#endregion

		#region - Constructors
		public SaveState( BudgetState budget, PaystubState paystub, DebtState debt )
		{
			Budget = budget;
			Paystub = paystub;
			Debt = debt;
		}
		#endregion

		#region - Methods

		#endregion

		#region - Full Properties

		#endregion
	}
}
