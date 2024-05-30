namespace Problem_05
{
    public class Dough
    {
        private string flourType;
        private string bakingTechnique;
        private double weight;

        public Dough(string flourType, string bakingTechnique, double weight)
        {
            this.FlourType = flourType;
            this.BakingTechnique = bakingTechnique;
            this.Weight = weight;
        }

        public string FlourType
        {
            get
            {
                return this.flourType;
            }
            private set
            {
                bool isInvalid = this.CheckTypeIsInvalid(value);
                if (isInvalid)
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                this.flourType = value;
            }
        }

        public string BakingTechnique
        {
            get
            {
                return this.bakingTechnique;
            }
            private set
            {
                bool isInvalid = this.CheckTypeIsInvalid(value);
                if (isInvalid)
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                this.bakingTechnique = value;
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
                bool isInvalid = this.CheckWeightIsInvalid(value);
                if (isInvalid)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }

                this.weight = value;
            }
        }

        public double CalculateCalories()
        {
            double totalCalories = 0;

            double typeGrams = Modifiers(this.FlourType);
            double techniqueGrams = Modifiers(this.BakingTechnique);

            totalCalories = (2 * this.Weight) * typeGrams * techniqueGrams;

            return totalCalories;
        }

        private double Modifiers(string type)
        {
            double grams = 0;
            type = type.ToLower();

            switch (type)
            {
                case "white": grams = 1.5; break;
                case "wholegrain": grams = 1.0; break;
                case "crispy": grams = 0.9; break;
                case "chewy": grams = 1.1; break;
                case "homemade": grams = 1.0; break;
            }

            return grams;
        }

        private bool CheckTypeIsInvalid(string type)
        {
            type = type.ToLower();
            bool isInvalid = type != "white" &&
                             type != "wholegrain" &&
                             type != "crispy" &&
                             type != "chewy" &&
                             type != "homemade";

            return isInvalid;
        }

        private bool CheckWeightIsInvalid(double weight)
        {
            bool isInvalid = weight < 1 || weight > 200;

            return isInvalid;
        }
    }
}
