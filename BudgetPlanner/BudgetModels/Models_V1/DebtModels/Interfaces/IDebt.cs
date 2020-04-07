using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace BudgetModels.Models_V1.DebtModels
{
    public interface IDebt
    {
        decimal AmountOwed { get; set; }
        string Debter { get; set; }
        ObservableCollection<IDebtItem> DebtHistory { get; set; }
        IDebtItem SelectedDebtHistory { get; set; }
        DateTime? DueDate { get; set; }
    }
}