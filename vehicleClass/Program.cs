namespace VehicleClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string vehicle = Console.ReadLine().ToLower();

            switch (vehicle)
            {
                case "car":
                case "truck":
                case "motorcycle":
                    Console.WriteLine("land vehicle");
                    break;

                case "boat":
                case "ship":
                case "submarine":
                    Console.WriteLine("water vehicle");
                    break;

                case "airplane":
                case "helicopter":
                    Console.WriteLine("air vehicle");
                    break;

                    default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
