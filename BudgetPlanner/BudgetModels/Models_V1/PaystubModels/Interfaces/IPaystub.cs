namespace BudgetModels.Models_V1.PaystubModels.Interfaces
{
    public interface IPaystub
    {
        decimal GrossPay { get; set; }
        decimal NetPay { get; set; }
        PayDates Period { get; set; }
        decimal TaxDeductions { get; set; }
    }
}