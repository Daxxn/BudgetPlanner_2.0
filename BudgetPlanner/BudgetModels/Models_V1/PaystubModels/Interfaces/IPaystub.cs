namespace BudgetModels.Models_V1.PaystubModels.Interfaces
{
    public interface IPaystub
    {
        decimal GrossPay { get; set; }
        decimal NetPay { get; set; }
        decimal TaxDeductions { get; set; }
        decimal TaxPercentage { get; set; }
        double Hours { get; set; }
        bool IsEstimated { get; set; }
        PayDates Period { get; set; }

        void EstimateTaxPercent( int selection );
    }
}