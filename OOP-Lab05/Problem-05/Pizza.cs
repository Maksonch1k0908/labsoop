namespace Problem_05
{
    public class Pizza
    {
        private string name;
        private Dough dough;
        private List<Topping> toppings;

        public Pizza(string name, Dough dough)
        {
            this.Name = name;
            this.Dough = dough;
            this.toppings = new List<Topping>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                bool isInvalid = this.CheckNameIsInvalid(value);
                if (isInvalid)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }

                this.name = value;
            }
        }

        public Dough Dough { get; }

        public double NumOfTopings => this.toppings.Count;

        public double TotalCalories { get; private set; }

        public void AddTopping(Topping topping)
        {
            if (this.toppings.Count >= 10)
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }

            this.toppings.Add(topping);
        }

        private double CalculateTotalCalories()
        {
            double toppingsTotalCalories = 0;

            foreach (var topping in this.toppings)
            {
                toppingsTotalCalories += topping.CalculateCalories();
            }

            double totalCalories = this.Dough.CalculateCalories() + toppingsTotalCalories;
            return totalCalories;
        }

        private bool CheckNameIsInvalid(string name)
        {
            bool isInvalid = string.IsNullOrEmpty(name) || name.Length > 15;

            return isInvalid;
        }

        public override string ToString()
        {
            this.TotalCalories = this.CalculateTotalCalories();

            return $"{this.Name} - {TotalCalories} Calories.";
        }
    }
}
