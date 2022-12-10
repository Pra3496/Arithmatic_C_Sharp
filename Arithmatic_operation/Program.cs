namespace Arithmatic_operation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = 0;
            int second = 0;

            Console.WriteLine("Substraction Class -> Substraction");
            Substraction sub = new Substraction();
            

            Console.WriteLine("Enter the First Number :");
            first = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Second Number :");
            second = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Differance of {0} and {1} is {2}", first, second, sub.substraction(first, second));

        }
    }
}