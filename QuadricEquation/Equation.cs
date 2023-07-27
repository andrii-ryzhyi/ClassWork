namespace QuadraticEquation
{
    using System;
    internal class Equation
    {
        private double a;
        private double b;
        private double c;
        private double x1, x2;

        public double A
        {
            get { return a; }
        }
        public double B
        {
            get { return b; }
        }
        public double C
        {
            get { return c; }
        }

        public Equation(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        private void InitEquation()
        {
            if (a != 0.0D)
            {
                double discriminant = Math.Pow(b, 2) - 4 * a * c;
                if (discriminant >= 0)
                {
                    x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                    x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                }
                else
                    Console.WriteLine("Discriminant < 0 which leads to complex solution");
            }
            else
            {
                Console.WriteLine("Input for quadratic equation is incorrect. Parameter a=0\n");
            }
        }
        public string GetResult()
        {
            InitEquation();
            string result = $"x1 = {x1.ToString()}; x2 = {x2.ToString()}";
            return result;
        }
    }
}