namespace examGrade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int grade = int.Parse(Console.ReadLine());

            switch (grade)
            {
                case 2:
                    Console.WriteLine("Poor");
                    break;
                case 3:
                        Console.WriteLine("Average");
                    break;
                case 4:
                        Console.WriteLine("Good");
                    break;
                case 5:
                        Console.WriteLine("Very good");
                    break;
                case 6:
                        Console.WriteLine("Excellent");
                    break;

                default:
                    Console.WriteLine("Invalid grade");
                    break;
            }
            
        }
    }
}
