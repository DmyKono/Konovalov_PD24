using System;
using static System.Math;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace pz2
{
    public class Task2
    {
        void Input(ref double A, ref double B, ref double C)
        {
            Console.WriteLine("Write length for sides a,b,c: \n a:");
            A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\n b:");
            B = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\n c:");
            C = Convert.ToDouble(Console.ReadLine());
        }
        bool IsPossible(double A, double B, double C)
        {
            if((A + B >= C) && (A + C >= B) && (B + C >= A))
            {
                return true;
            }
            else return false;
        }
        double PerimeterCalc(double A, double B, double C)
        {
            return A + B + C;
        }

        double AreaCalc(double A, double B, double C, double P)
        {
            return Math.Sqrt(((P/2) * ((P/2)) - A) * ((P/2) - B) * ((P/2) - C));
        }
       
        public void task2run()
        {
            double SideA=0,SideB=0,SideC=0;

            Input(ref SideA, ref SideB, ref SideC);

            double Perimeter = 0, Area = 0;
            if (IsPossible(SideA,SideB,SideC))
            {
                Perimeter = PerimeterCalc(SideA, SideB, SideC);
                Area = AreaCalc(SideA,SideB,SideC,Perimeter);

            }
            else Console.WriteLine("This triangle is not possible");

            Console.WriteLine($"Perimeter: {Perimeter}\nArea: {Area}");
        }
    }
}
