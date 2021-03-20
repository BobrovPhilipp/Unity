using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanseXY.Bobrov_Philipp
//а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле 
//    r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).
//    Вывести результат, используя спецификатор формата .2f(с двумя знаками после запятой);
//б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.
{
    class Program 
    {

        static void Main(string[] args)
        {
            //РАССЧЕТ РАССТОЯНИЯ МЕЖДУ ТОЧКАМИ ПО ФОРМУЛЕ (без функции, с ручным вводом значений пользователем).
            #region
            Console.WriteLine("Добро пожаловать в консоль рассчета расстояния между двумя точками.");

            Console.WriteLine("Задайте значение координаты долготы точки 'A': ");
            string x1Text = Console.ReadLine();
            double x1 = Convert.ToDouble(x1Text);

            Console.WriteLine("Задайте значение координаты широты точки 'A': ");
            string y1Text = Console.ReadLine();
            double y1 = Convert.ToDouble(y1Text);

            Console.WriteLine("Задайте значение координаты долготы точки 'B': ");
            string x2Text = Console.ReadLine();
            double x2 = Convert.ToDouble(x2Text);

            Console.WriteLine("Задайте значение координаты широты точки 'B': ");
            string y2Text = Console.ReadLine();
            double y2 = Convert.ToDouble(y2Text);

            double result;
            result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine("Расстояние между точкой A и точкой B: ");
            Console.WriteLine("{0:N}", result);
            
            Console.WriteLine("Благодарю за пользование. Доброго дня!");
            Console.WriteLine("\n");
            #endregion

            //РАССЧЕТ РАССТОЯНИЯ МЕЖДУ ТОЧКАМИ ПО ФОРМУЛЕ (включение рассчетов в метод).
            #region
            MathXY();
            Console.WriteLine("Спасибо за использование данного сервиса! Всего доброго!");
            #endregion
        }
        private static void MathXY()
        {
            Console.WriteLine("ДУБЛЬ, вызванный методом.");
            Console.WriteLine("Добро пожаловать в консоль рассчета расстояния между двумя точками.");
            Console.WriteLine("Задайте значение координаты долготы точки 'A': ");
            string x1Text = Console.ReadLine();
            double x1 = Convert.ToDouble(x1Text);

            Console.WriteLine("Задайте значение координаты широты точки 'A': ");
            string y1Text = Console.ReadLine();
            double y1 = Convert.ToDouble(y1Text);

            Console.WriteLine("Задайте значение координаты долготы точки 'B': ");
            string x2Text = Console.ReadLine();
            double x2 = Convert.ToDouble(x2Text);

            Console.WriteLine("Задайте значение координаты широты точки 'B': ");
            string y2Text = Console.ReadLine();
            double y2 = Convert.ToDouble(y2Text);

            double result;
            result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine("Расстояние между точкой A и точкой B: ");
            Console.WriteLine("{0:N}", result);
        }
    }
}
