namespace FirstClassBmiApp.Models
{
    public class BmiModel
    {
        // Storing the Weight of the person (i.e. 40.5)
        public double Weight { get; set; }

        // Storing the Height of the person (i.e. 5.7)
        public double Height { get; set; }

        // Calculates the actual BMI of a person based on the provided Weight and Height from the
        // "Index" view page after clickling "Calculate".
        // Formula = BMI = Weight (kg) / (Height (in meters) * Height (in meters))
        public double CalculateBMI()
        {
            // We cannot divide a value by 0, otherwise we will get an error. Simply return 0.0 if the height is 0.
            if (Height == 0.0)
            {
                return 0.0;
            }
            else
            {
                return Weight / (Height * Height);
            }
        }
    }
}
