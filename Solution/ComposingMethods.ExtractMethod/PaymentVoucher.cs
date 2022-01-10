using ComposingMethods.ExtractMethod.Enums;
using ComposingMethods.ExtractMethod.Util;

namespace ComposingMethods.ExtractMethod
{
    public class PaymentVoucher
    {
        private decimal Value; 
        private CurrencyEnum Currency;
        private string Buyer;

        public PaymentVoucher(
            decimal value,
            string buyer,
            CurrencyEnum currency) 
        {
            Value = value;
            Buyer = buyer;
            Currency = currency;
        }
        /*
         * You have a code fragment that can be grouped together.
        */
        public PaymentVoucherToPrint GenerateVoucherToPrint() {
            var voucherToPrint = new PaymentVoucherToPrint() {
                Buyer = this.Buyer.Substring(0, 10)
            };

            string currency = ConvertCurrencyToString.Convert(Currency);                
            voucherToPrint.Value = currency + " " + Value;

            return voucherToPrint;
        }
    }
}
