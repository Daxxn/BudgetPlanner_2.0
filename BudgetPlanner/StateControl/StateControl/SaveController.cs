using BudgetModels.Models_V1.BudgetModels;
using BudgetModels.Models_V1.BudgetModels.Interfaces;
using BudgetModels.Models_V1.DebtModels;
using BudgetModels.Models_V1.PaystubModels;
using BudgetModels.Models_V1.PaystubModels.Interfaces;
using Newtonsoft.Json;
using StateControl.States;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateControl.StateControl
{
    public static class SaveController
	{
        #region - Fields & Properties
        public delegate void SendMessage( string message );
        #endregion

        #region - Methods
        public static string Save( string path, SaveState state )
        {
            string message = null;

            if (String.IsNullOrEmpty(path))
            {
                return "Path is invalid";
            }

            try
            {
                JsonController.SaveJson(path, state);
            }
            catch (Exception e)
            {
                message = e.Message;
            }

            return message;
        }

		public static SaveState BuildSaveState( BudgetState budgetState, PaystubState paystubState, DebtState debtState )
		{
			return new SaveState(budgetState, paystubState, debtState);
		}

        public static SaveState BuildSaveState( IEnumerable<IIncome> incomeData,
                IEnumerable<IExpense> expenseData,
                IEnumerable<IPaystub> paystubData,
                IEnumerable<IDebt> debtData )
        {
            return new SaveState(
                new BudgetState(incomeData.Cast<Income>(), expenseData.Cast<Expense>()),
                new PaystubState(paystubData.Cast<Paystub>()),
                new DebtState(debtData.Cast<Debt>())
                );
        }

        public static BudgetState BuildBudgetState( IEnumerable<Income> incomeData, IEnumerable<Expense> expenseData )
        {
            return new BudgetState(incomeData, expenseData);
        }

        public static PaystubState BuildPaystubState( IEnumerable<Paystub> paystubData )
        {
            return new PaystubState(paystubData);
        }

        public static DebtState BuildDebtState( IEnumerable<Debt> debtData )
        {
            return new DebtState(debtData);
        }

        
        #endregion

        #region - Full Properties

        #endregion
    }
}
