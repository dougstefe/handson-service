namespace Handson.Domain.Entities
{
    public class BoletoPayment : Payment
    {
        public BoletoPayment(string barCode, string controlNumber, decimal total) : base(total)
        {
            BarCode = barCode;
            ControlNumber = controlNumber;
        }

        public string BarCode { get; set; }
        public string ControlNumber { get; set; }
    }
}
