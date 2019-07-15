using System;
using System.Collections.Generic;
using _39_Interfaces_Exercise;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _39_Interfaces_Exercise_Tests
{
    [TestClass]
    public class WorkflowTests
    {
        [TestMethod]
        public void Add_AddsIActivityToQueue_ShouldIncreaseQueueCount()
        {
            var workflow = new Workflow();
            workflow.Add(new MockActivity());

            var queue = workflow.GetWorkFlow() as Queue<IActivity>;

            var actual = queue.Count;
            var expected = 1;

            Assert.AreEqual(expected, actual);

        }
    }

    internal class MockActivity : IActivity
    {
        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
