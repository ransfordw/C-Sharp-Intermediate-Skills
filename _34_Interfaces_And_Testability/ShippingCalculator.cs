﻿using System;

namespace _34_Interfaces_And_Testability
{
    public class ShippingCalculator : IShippingCalculator
    {
        public ShippingCalculator()
        {
        }

        public float CalculateShipping(Order order)
        {
            if (order.TotalPrice < 30f)
                return order.TotalPrice * 0.1f;
            return 0;
        }
    }
}