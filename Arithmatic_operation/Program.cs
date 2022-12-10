namespace Arithmatic_operation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = 0;
            int second = 0;

            Console.WriteLine("Addition Class -> Addition");
            Additon cal = new Additon();
            

            Console.WriteLine("Enter the First Number :");
            first = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Second Number :");
            second = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sum of {0} and {1} is {2}", first, second, cal.Addition(first, second));

        }
    }
}