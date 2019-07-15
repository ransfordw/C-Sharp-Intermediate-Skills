using System;

namespace _34_Interfaces_And_Testability
{
    public class Shipment
    {
        public Shipment()
        {
        }

        public float Cost { get; set; }
        public DateTime ShippingDate { get; internal set; }
    }
}