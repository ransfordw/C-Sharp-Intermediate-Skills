using System;
using _34_Interfaces_And_Testability;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _34_Interfaces_And_Testability_Tests
{
    [TestClass]
    public class OrderProcessorTests
    {
        // MethodName_ConditionBeingTested_Expectation
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Process_OrderIsAlreadyShipped_ThrowsException()
        {
            var orderProcessor = new OrderProcessor(new MockShippingCalculator());
            Order order = new Order()
            {
                Shipment = new Shipment()
            };

            orderProcessor.Process(order);
        }

        [TestMethod]
        public void Process_OrderIsNotShipped_ShouldSetTheSHipmentPropertyOfTheOrder()
        {
            var orderProcessor = new OrderProcessor(new MockShippingCalculator());
            var order = new Order();
            orderProcessor.Process(order);

            Assert.IsTrue(order.IsShipped);
            Assert.AreEqual(1, order.Shipment.Cost);
            Assert.AreEqual(DateTime.Today.AddDays(1), order.Shipment.ShippingDate);
        }
    }

    public class MockShippingCalculator : IShippingCalculator
    {
        public float CalculateShipping(Order order)
        {
            // We assume the fake class functions properly so we can just have a valid return
            return 1;
        }
    }
}
