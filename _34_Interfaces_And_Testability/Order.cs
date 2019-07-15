using System;

namespace _34_Interfaces_And_Testability
{
    public class Order
    {
        public DateTime DatePlaced { get; set; }
        public float TotalPrice { get; set; }
        private bool _isShipped;

        public bool IsShipped
        {
            get { return (Shipment!=null); }
            set { _isShipped = (Shipment!=null); }
        }

        public Shipment Shipment { get; set; }
    }
}