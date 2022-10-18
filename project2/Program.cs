using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace laba2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, y;
            Console.Write("Input a: ");// просимо щоб користувач увів значення
            a = Convert.ToDouble(Console.ReadLine());//поле для вводу числа
            Console.Write("Input b: ");
            b = Convert.ToDouble(Console.ReadLine());

            if(a > b && b > 2)
            {
                y = Math.Pow(b , 2) + a;// розрахунок для першої умови

                Console.WriteLine("Your result " + y);// виведення для першої умови

            }else if(a < b && b < 2)
            {
                y = Math.Max (a, b);// розрахунок для другої умови

                Console.WriteLine("Your result " + y);// виведення для другої умови
            }
            else if(a == b)
            {
               y = Math.Pow(Math.Sin(a * a), 2) + Math.Pow(Math.Pow(a, b) - Math.Tan(b), 1.0 / 3.0);// розрахунок для третьої умови

               Console.WriteLine("Your result " + y);// виведення для третьої умови
            }
            else
            {
               y = Math.Min(a, b);// розрахунок для четвертої умови

               Console.WriteLine("Your result " + y);// виведення для четвертої умови
            }

            Console.ReadKey();

        }
    }
}
