namespace SphereCalculator


{
    internal class Program
    {
        static void Main()
        {
            //instance of the class
            var calculateSphere = new CalculateSphere();

            double result = 0;
            Console.WriteLine(" Input your radius to calculate shpere: ");

            try
            {
                double radius = double.Parse(Console.ReadLine());
                var volumeOfSphere = calculateSphere.volumeOfSphere(radius);
                Console.WriteLine($"The Volume of sphere with radius {radius} is {volumeOfSphere}");

            }
            catch (Exception) { Console.WriteLine("Invalid Input. Only accept numeric value"); }


        }

      
    }
}