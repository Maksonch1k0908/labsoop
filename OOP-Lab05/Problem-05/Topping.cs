namespace Problem_05
{
    public class Topping
    {
        private string type;
        private double weight;

        public Topping(string type, double weight)
        {
            this.Type = type;
            this.Weight = weight;
        }

        public string Type
        {
            get
            {
                return this.type;
            }
            private set
            {
                bool isInvalid = this.CheckIfTypeIsInvalid(value);
                if (isInvalid)
                {
                    throw new ArgumentException(string.Format("Cannot place {0} on top of your pizza.", value));
                }

                this.type = value;
            }
        }

        public double Weight
        {
            get
            {
                return this.weight;
            }
            private set
            {
                bool isInvalid = this.CheckIfWeightIsInvalid(value);
                if (isInvalid)
                {
                    throw new ArgumentException(string.Format("{0} weight should be in the range [1..50].", this.Type));
                }

                this.weight = value;
            }
        }

        public double CalculateCalories()
        {
            double totalCalories = 0;

            double typeGrams = this.Modifiers(this.Type);
            totalCalories = (2 * this.Weight) * typeGrams;

            return totalCalories;
        }

        private double Modifiers(string type)
        {
            double grams = 0;
            type = type.ToLower();

            switch (type)
            {
                case "meat": grams = 1.2; break;
                case "veggies": grams = 0.8; break;
                case "cheese": grams = 1.1; break;
                case "sauce": grams = 0.9; break;
            }

            return grams;
        }

        private bool CheckIfTypeIsInvalid(string type)
        {
            type = type.ToLower();

            bool isInvalid = type != "meat" &&
                             type != "veggies" &&
                             type != "cheese" &&
                             type != "sauce";

            return isInvalid;
        }

        private bool CheckIfWeightIsInvalid(double weight)
        {
            bool isInvalid = weight < 1 || weight > 50;

            return isInvalid;
        }
    }
}
