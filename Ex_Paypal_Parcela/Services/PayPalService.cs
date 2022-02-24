using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Paypal_Parcela.Services
{
    internal class PayPalService : IOnlinePaymentService
    {
        private const double FeePercentage = 0.02;
        private const double MonthlyInterest = 0.01;


        public double Interest(double amount, int months)
        {
            return amount * MonthlyInterest * months;
        }


        public double PaymentFee(double amount)
        {
            return amount * FeePercentage;
        }
    }
}
