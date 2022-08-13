using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson20
{
    class Program
    {
        delegate double MyDelegate(double r);
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите радиус");
            double r = Convert.ToDouble(Console.ReadLine());
           
            MyDelegate myDelegate = GetD;
            myDelegate += GetS;
            myDelegate += GetV;
            myDelegate(r);
            Console.ReadKey();
        }

        static double GetD(double r)
        {
            double d = 2 * Math.PI * r;
            Console.WriteLine("Длина окружности равна {0:f2} ", d);
            return d;
        }
        static double GetS(double r)
        {
            double s = Math.PI * r * r;
            Console.WriteLine("Площадь круга равна {0:f2} ", s);
            return s;
        }
        static double GetV(double r)
        {
            double v = (4 * Math.PI * Math.Pow(r,3))/3;
            Console.WriteLine("Объем шара равен {0:f2} ", v);
            return v;
        }
    }
}
