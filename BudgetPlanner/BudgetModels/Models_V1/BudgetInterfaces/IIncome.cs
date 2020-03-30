using BudgetModels.Models_V1.BudgetModels;

namespace BudgetModels.Models_V1.BudgetInterfaces
{
    public interface IIncome : IBudget
    {
        decimal AmountRecieved { get; set; }
        bool IsRecieved { get; set; }
        PayPeriod Period { get; set; }
    }
}