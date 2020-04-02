namespace BudgetModels.Models_V1.BudgetModels.Interfaces
{
    public interface IExpense : IBudgetBase
    {
        decimal RemainingAmount { get; set; }
        decimal AmountPayed { get; set; }
        bool IsPayedOff { get; set; }
        bool IsPayedOnce { get; set; }

        void CalcRemainingFromPayed( );
    }
}