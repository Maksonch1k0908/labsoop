namespace Problem_04
{
    public class Person
    {
        private string name;
        private double money;
        public List<Product> Bag { get; set; }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty.");
                }
                name = value;
            }
        }

        public double Money
        {
            get { return money; }
            private set
            {
                if (money <= 0)
                {
                    throw new ArgumentException("Money can`t be a negative num");
                }
                money = value;
            }
        }

        public Person(string name, double money)
        {
            Name = name;
            Money = money;
            Bag = new List<Product>();
        }

        public string BuyProduct(Product product)
        {
            bool canBuyProduct = Money >= product.Cost;
            if (canBuyProduct)
            {
                Money -= product.Cost;
                Bag.Add(product);
                return $"{Name} bought {product.Name}";
            }

            return $"{Name} can't afford {product.Name}";
        }
    }
}