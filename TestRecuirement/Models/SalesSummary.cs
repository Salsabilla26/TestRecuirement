namespace TestRecuirement.Models
{
    public class SalesSummary
    {
        public string Country { get; set; }
        public string ItemType { get; set; }
        public int UnitsSold { get; set; }
        public decimal UnitPrice { get; set; }

        public decimal Revenue => UnitsSold * UnitPrice;
    }
}
