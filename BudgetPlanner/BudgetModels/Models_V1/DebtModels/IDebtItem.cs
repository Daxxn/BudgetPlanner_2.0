using System;

namespace BudgetModels.Models_V1.DebtModels
{
    public interface IDebtItem
    {
        IDebt Parent { get; set; }
        decimal AmountPayed { get; set; }
        DateTime DatePayed { get; set; }
    }
}