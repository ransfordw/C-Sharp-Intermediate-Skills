using AccessModifiers_2_OnlineStore;

namespace AccessModifiers_2
{

    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
            // If CalculateRating is private in the Customer class, the following code would not compile.
            // var rating = customer.CalcuateRating();

            var customerExampleTwo = new CustomerExampleTwo();
            // RateCalculator is not accessible here because the method is declared as internal but it is accessible within the assembly where is is housed.
            //AccessModifiers_2_OnlineStore.RateCalculator calculator = new RateCalculator();
        }
    }
}

