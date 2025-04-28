namespace flowers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string flower = Console.ReadLine().ToLower();

            switch (flower)
            {
                case "rose":
                case "tulip":
                case "daisy":
                    Console.WriteLine("Spring flower");
                    break;

                case "orchid":
                    Console.WriteLine("Winter flower");
                    break;

                default:
                    Console.WriteLine("unknown flower");
                    break;
            }
        }
    }
}
