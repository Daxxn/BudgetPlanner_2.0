using BudgetModels.Models_V1.BudgetModels;

namespace BudgetModels.Models_V1.BudgetModels.Interfaces
{
    public interface IIncome : IBudgetBase
    {
        decimal AmountRecieved { get; set; }
        bool IsRecieved { get; set; }
        PayPeriod Period { get; set; }
    }
}