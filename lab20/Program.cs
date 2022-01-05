using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

      /* В приложении объявить тип делегата, который ссылается на метод. Требования к сигнатуре метода следующие:
-метод получает входным параметром переменную типа double;
-метод возвращает значение типа double, которое является результатом вычисления.
 
Реализовать вызов методов с помощью делегата, которые получают радиус R и вычисляют:
-длину окружности по формуле D = 2 * π* R;
-площадь круга по формуле S = π* R²;
-объем шара.Формула V = 4 / 3 * π * R³.

Методы должны быть объявлены как статические.*/


namespace lab20
{
    class Program
    {
        delegate double MyDelegate(int a, double b, double r);
        static void Main(string[] args)
        {
            MyDelegate myDelegate = PowerABR;
            double d = myDelegate(2, Math.PI, 10);
            Console.WriteLine(d);
            Console.ReadKey();

            myDelegate = PowerBR;
            double s = myDelegate(2, Math.PI, 10);
            Console.WriteLine(d);
            Console.ReadKey();

            myDelegate = PowerACR;
            double v = myDelegate(2, Math.PI, 10);
            Console.WriteLine(d);
            Console.ReadKey();
        }
        static double PowerABC(int a, double b, double r)
        {
            double d = (2 * Math.PI * 10);
            Console.WriteLine(d);
            return d; 
        }
        static double PowerBR( double b, double r)
        {
            double s = (Math.PI * (Math.Pow (2)* 10));
            Console.WriteLine(s);
            return s;
        }
        static double PowerACR(int a, double c, double b, double r)
        {
            double v = ((a/c)*Math.PI*Math.Pow (3));
            Console.WriteLine(v);
            return v;
        }
    }
}

/*  double D = Convert.ToDouble(Console.ReadLine());
            double S = 3.14(Math.pow(D,2))/4;
            double L = 3.14*D;
            
            
 
            Console.WriteLine("{0:0.00} {1:0.00}",D,L);
            Console.ReadKey();*/
            