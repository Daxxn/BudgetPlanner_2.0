using System;

namespace BudgetModels.Models_V1.DebtModels
{
    public interface IDebtItem
    {
        decimal AmountPayed { get; set; }
        DateTime DatePayed { get; set; }
    }
}