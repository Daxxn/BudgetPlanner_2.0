using System;

namespace BudgetModels.Models_V1.BudgetInterfaces
{
    public interface IBudgetBase : IBudget
    {
        decimal Amount { get; set; }
        string Description { get; set; }
        DateTime DueDate { get; set; }
        int IDNumber { get; set; }
        string Title { get; set; }
    }
}