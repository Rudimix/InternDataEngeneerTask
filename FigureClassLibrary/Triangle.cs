namespace FigureClassLibrary
{
    public class Triangle : Figure
    {
        private int a, b, c;
        public Triangle(int a,int b,int c) 
        {
            this.a = a; 
            this.b = b;
            this.c = c;
        }
        public bool CheckRightTriangle()
        {
            double aSquare = Math.Pow(a, 2);
            double bSquare = Math.Pow(b, 2);
            double cSquare = Math.Pow(c, 2);

            if (aSquare == bSquare + cSquare || bSquare == aSquare + cSquare || cSquare == aSquare + bSquare)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public double GetArea()
        {
            int p = (a + b + c)/2;
            return Math.Sqrt(p*(p-a)*(p-b)*(p-c));
        }
    }
}
