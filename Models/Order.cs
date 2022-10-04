using System;

namespace ShopOnline
{
    public class Order
    {
        public int OrderID {get; set;}
        public DateTime CreatedTime {get; set;}
        public DeliveryAddress Address {get; set;} = new DeliveryAddress();
        public Cakes Cakes {get; set;} = new Cakes();
        public decimal GetTotalPrice {get; set;}
        public string FormattedTotalPrice() => GetTotalPrice.ToString("0.00");
    }
}