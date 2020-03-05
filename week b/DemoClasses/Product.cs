namespace DemoObject
{
    class Product
    {
        string ProductId;
        int Stock;
        double StarRating;
        public void SetDefaultValues()
        {
            ProductId = "1";
            Stock = 0;
            StarRating = 5;
        }
        public void SetValues(string id, int quantity, double rating)
        {
            ProductId = id;
            Stock = quantity;
            StarRating = rating;

            if (quantity > 50)
            {
                System.Console.WriteLine("Error! too much quantity");
            }

            if (quantity < 0)
            {
                System.Console.WriteLine("Error! can't have negative quantity");
            }
        }
        public override string ToString()
        {
            return "product " + ProductId + ", "
                + Stock + " in stock, " + StarRating + " star rating";
        }
    }
}
