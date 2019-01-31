namespace AccessModifiers_2
{
    public class GoldCustomer : Customer
    {
        public void OfferVoucher()
        {
            // If CalculateRating is protected in the base Customer class, it will be accessible in any derived classes, like this GoldCustomer class
            var rating = this.CalcuateRating(excludeOrders: true);
        }
    }
}
