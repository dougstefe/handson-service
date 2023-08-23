using Handson.Domain.Enums;

namespace Handson.Domain.Entities
{
    public class BoletoPayment : Payment
    {
        public BoletoPayment(string barCode, string controlNumber, decimal total) : base(PaymentMethod.Boleto, total)
        {
            BarCode = barCode;
            ControlNumber = controlNumber;
        }

        public string BarCode { get; private set; }
        public string ControlNumber { get; private set; }
    }
}
