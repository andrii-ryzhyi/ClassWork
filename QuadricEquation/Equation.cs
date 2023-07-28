namespace QuadraticEquation
{
    using System;

    internal class Equation
    {
        public double A { get; }
        public double B { get; }
        public double C { get; }

        private double x1, x2;
        private string message;
        public Equation(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        private double CalculateDiscriminant()
        {
            return Math.Pow(B, 2) - 4 * A * C;
        }

        private void CalculateResult()
        {
            if (A != 0.0D)
            {
                double discriminant = CalculateDiscriminant();
                if (discriminant > 0)
                {
                    x1 = (-B + Math.Sqrt(discriminant)) / (2 * A);
                    x2 = (-B - Math.Sqrt(discriminant)) / (2 * A);
                    message = $"x1 = {x1.ToString()}; x2 = {x2.ToString()}";
                }
                else if (discriminant == 0)
                {
                    x1 = x2 = -B / (2 * A);
                    message = $"Discriminant = 0\n x1 = x2 = {x1.ToString()}";
                }
                else
                    message = "Discriminant < 0 which leads to complex solution";
            }
            else
                message = "Input for quadratic equation is incorrect. Parameter a = 0";
        }

        public string GetResult()
        {
            CalculateResult();
            return message;
        }
    }
}