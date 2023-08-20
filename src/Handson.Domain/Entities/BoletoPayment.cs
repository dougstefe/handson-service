namespace Handson.Domain.Entities
{
    public class BoletoPayment : Payment
    {
        public string BarCode { get; set; }
        public string ControlNumber { get; set; }
    }
}
