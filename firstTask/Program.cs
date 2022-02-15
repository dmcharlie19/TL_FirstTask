using System;

namespace firstTask
{

    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("введите тип фигуры 1 - прямоугольник, 2 эллипс");
                    UInt16 type = Convert.ToUInt16(Console.ReadLine());
                    if (type != 1 && type != 2)
                        throw new ArgumentException("ошибка ввода типа фигуры");

                    if (type == 1) // прямоугольник
                    {
                        Console.WriteLine("введите левую верхнюю точку в формате X,Y");
                        var topLeft = GetPointFromConsole();

                        Console.WriteLine("введите правую нижнюю точку в формате X,Y");
                        var bottomRight = GetPointFromConsole();

                        var rectangle = new Rectangle(topLeft, bottomRight);

                        Console.WriteLine("площадь фигуры = {0}", rectangle.GetSquare());
                        Console.WriteLine("периметр фигуры = {0}", rectangle.GetPerimeter());
                    }
                    else
                    {
                        Console.WriteLine("введите центр эллипса X,Y");
                        var c = GetPointFromConsole();

                        Console.WriteLine("введите длину большой полуоси");
                        var major = Convert.ToUInt32(Console.ReadLine());

                        Console.WriteLine("введите длину малой полуоси");
                        var minor = Convert.ToUInt32(Console.ReadLine());

                        var ellipse = new Ellipse(c, minor, major);

                        Console.WriteLine("площадь фигуры = {0}", ellipse.GetSquare());
                        Console.WriteLine("периметр фигуры = {0}", ellipse.GetPerimeter());
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
        }

            static Point GetPointFromConsole()
            {
                var a = Console.ReadLine().Split(",");
                if (a.Length != 2)
                    throw new ArgumentException("ошибка ввода точки");

                Point p = new Point();

                p.X = Convert.ToInt32(a[0]);
                p.Y = Convert.ToInt32(a[1]);

                return p;
            }
            

        }



    }
}
