namespace BudgetModels.Models_V1.BudgetInterfaces
{
    public interface IExpense : IBudget
    {
        bool IsPayedInFull { get; set; }
        bool IsPayedOff { get; set; }
        decimal RemainingAmount { get; set; }
    }
}