using System;
using System.ComponentModel.DataAnnotations;


namespace LoanCalculator.Models
{

    public class Credit
    {
        private const int DaysYear = 365;
        private const double DaysMonth = 30.5;

        [Required(ErrorMessage = "Credit rate should be set")]
        public int CreditRate { get; set; }
        [Required(ErrorMessage = "Credit amount should be set")]
        [Range(1000, 2000000)]
        public int CreditAmount { get; set; }
        [Required(ErrorMessage = "Credit term should be set")]
        public int CreditTerm { get; set; }
        public double? TotalSum { get; set; }

        public void SetTotalSum()
        {
            var percent =  Math.Round(Convert.ToDouble(CreditAmount) * (Convert.ToDouble(CreditRate) / 100) * Convert.ToDouble((CreditTerm * DaysMonth) / DaysYear));
            TotalSum = CreditAmount + percent ;
        }
    }
}
