using System;
using System.Collections.Generic;

namespace _27_Exercises
{
    public class Stack
    {
        public List<object> TheStackAsAList { get; set; }
        public bool IsStack { get; private set; }

        public Stack()
        {
            TheStackAsAList = new List<object>();
        }

        public void Push(object obj)
        {
            if (obj == null)
            {
                throw new InvalidOperationException();
            }

            TheStackAsAList.Add(obj);
        }

        public object Pop()
        {
            return TheStackAsAList[TheStackAsAList.Count -1] ;
        }

        public void Clear()
        {
            for (int i = TheStackAsAList.Count - 1; i >= 0; i--)
            {
                TheStackAsAList.RemoveAt(i);
            }
        }

        public override string ToString()
        {
            return "This is a Stack Class";
        }
    }
}
