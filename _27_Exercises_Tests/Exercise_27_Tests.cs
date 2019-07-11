using _27_Exercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace _27_Exercises_Tests
{
    [TestClass]
    public class Exercise_27_Tests
    {
        [TestMethod]
        public void Stack_Push_AddsElementToStack()
        {
            var stack = new Stack();
            stack.Push(10);

            var actual = stack.TheStackAsAList.Count;
            var expected = 1;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Stack_Push_AddsElementToTopOfStack()
        {
            var stack = new Stack();
            stack.Push("Hello");
            stack.Push(10);

            var actual = stack.Pop();
            object expected = 10;

            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void Stack_Pop_ReturnsElementFromTopOfStack()
        {
            var stack = new Stack();
            stack.Push("Hello");
            stack.Push(10);

            var actual = stack.Pop();
            object expected = 10;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Stack_Clear_EmptysTheStack()
        {
            var stack = new Stack();
            stack.Push("Hello");
            stack.Push(10);
            stack.Push(10);
            stack.Push(10);
            stack.Push(10);

            stack.Clear();

            var actual = stack.TheStackAsAList.Count;
            object expected = 0;

            Assert.AreEqual(expected, actual);
        }
    }
}
