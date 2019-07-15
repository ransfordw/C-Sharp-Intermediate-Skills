using System;

namespace _Interfaces_And_Testability
{
    internal class Shipment
    {
        public Shipment()
        {
        }

        public object Cost { get; set; }
        public DateTime ShippingDate { get; internal set; }
    }
}