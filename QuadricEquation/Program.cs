namespace QuadraticEquation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 6.0D;
            double b = -17.0D;
            double c = 12.0D;
            Equation eq = new Equation(a, b, c);
            string result = eq.GetResult();
            Console.WriteLine(result);
        }
    }
}