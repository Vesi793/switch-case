namespace TypeOfAnimal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string animal = Console.ReadLine().ToLower();

            switch (animal)
            {
                case "dog":
                        Console.WriteLine("mammal");
                    break;
                case "snake":
                case "crocodile":
                case "tortoise":
                    Console.WriteLine("reptile");
                    break;

                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
