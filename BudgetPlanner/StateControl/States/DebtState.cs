using BudgetModels.Models_V1.DebtModels;
using StateControl.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateControl.States
{
    public class DebtState : IState
	{
		#region - Fields & Properties
		public IEnumerable<Debt> DebtData { get; set; }
		#endregion

		#region - Constructors
		public DebtState( IEnumerable<Debt> debtData )
		{
			DebtData = debtData;
		}
		#endregion

		#region - Methods

		#endregion

		#region - Full Properties

		#endregion
	}
}
