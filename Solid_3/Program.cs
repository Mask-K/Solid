using System;


interface IFigure
{
    int GetArea();
}

class Rectangle : IFigure
{
    public  int Width { get; set; }
    public  int Height { get; set; }
    public int GetArea()
    {
        return Width * Height;
    }
}

//квадрат наслідується від прямокутника!!!
class Square : IFigure
{
    public int Width { get; set; }
    public int GetArea()
    {
        return Width * Width;
    }
}

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            rect.Width = 5;
            rect.Height = 10;

            Console.WriteLine(rect.GetArea());
            //Відповідь 100? Що не так???
            Console.ReadKey();
        }
    }
