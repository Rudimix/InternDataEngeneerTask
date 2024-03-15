using FigureClassLibrary;

namespace InternDataEngeneerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Figure figure = new Triangle(1, 2, 3);
            figure = new Circle(1);
            Console.WriteLine(figure.GetArea());
        }
    }
}
