using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_Boxing_And_Unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add("Hello");
            list.Add(DateTime.Today);

            // Not type safe
            var number = (int)list[1]; // throws invalid cast exception

            // Type safe lists avoid boxing and unboxing performance penalties
            var anotherList = new List<int>();
            var names = new List<string>();
        }
    }
}
