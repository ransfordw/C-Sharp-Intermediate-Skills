using System;

namespace AccessModifiers_2
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            var rating = CalcuateRating(excludeOrders: true);
            if (rating == 0)
                Console.WriteLine("Promoted to Level 1");
            else
                Console.WriteLine("Promoted to Level 2");
        }

        protected int CalcuateRating(bool excludeOrders)
        {
            return 0;
        }
    }
}
