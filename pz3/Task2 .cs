using Microsoft.Win32;
using pz3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace pz3
{
    public class Task2
    {
        public void Task2run()
        {
            List<Point> points = new List<Point>();
            int x, y;
            int quant= 0;

            if (isPassable(ref quant))
            {
                for (int i = 0; i < quant; i++)
                {
                    Console.Write("x= ");
                    x = Convert.ToInt32(Console.ReadLine());
                    Console.Write("y= ");
                    y = Convert.ToInt32(Console.ReadLine());
                    points.Add(new Point(x, y, Convert.ToString(Convert.ToChar((65 + i)))));

                    Console.WriteLine($"Point - {points[i].Name}");
                    Console.WriteLine($"X - points[i].X");
                    Console.WriteLine($"points[i].Y");

                    Console.WriteLine("========================");
                }

                Point[] PointsArr = points.ToArray();

                Figure figure = new Figure(PointsArr);

                Console.WriteLine($"Figure Perimeter: {figure.PerimeterCalculator()}");
            }
            Console.ReadKey();

        }

        bool isPassable(ref int quants)
        {
            Console.Write("How many points? (3-5) ");
            int answer = Convert.ToInt32(Console.ReadLine());
            if ((answer>=3)&&(answer<=5))
            {
                quants=answer;
                return true;
            }
            else
            {
                Console.SetCursorPosition(0, Console.CursorTop - 1);
                Console.Write(new string(' ', Console.WindowWidth));
                Console.SetCursorPosition(0, Console.CursorTop);
                return isPassable(ref quants);
            }
        }
    }
}
