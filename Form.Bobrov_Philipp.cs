using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form.Bobrov_Philipp
// Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). 
// В результате вся информация выводится в одну строчку:
// а) используя склеивание;
// б) используя форматированный вывод;
// в) используя вывод со знаком $.
{
    class Program 
    {
        static void Main(string[] args)
        {
            //АНКЕТИРОВАНИЕ.
            #region
            Console.WriteLine("Добро пожаловать!\nПожалуйста, ответьте на несколько вопросов.");

            Console.WriteLine("Введите ваше имя.");
            string name = Console.ReadLine();

            Console.WriteLine("Введите вашу фамилию.");
            string sureName = Console.ReadLine();

            Console.WriteLine("Укажите ваш возраст.");
            int age;
            string ageText = Console.ReadLine();
            age = Convert.ToInt32(ageText);

            Console.WriteLine("Укажите ваш рост(в метрах).");
            double height;
            string heightText = Console.ReadLine();
            height = Convert.ToDouble(heightText);

            Console.WriteLine("Укажите ваш вес(в килограммах).");
            double weight;
            string weightText = Console.ReadLine();
            weight = Convert.ToDouble(weightText);
            Console.WriteLine("\n"); // ВОПРОС: Есть ли более верная альтернатива для совершения отступа, кроме \n?
            #endregion

            //ВЫВОД СКЛЕИВАНИЕМ.
            #region
            Console.WriteLine("Ваши данные: ");
            Console.WriteLine("Имя: " + name + "\nФамилия: " + sureName + "\nВозраст: " + age + " лет" + "\nРост: " + height + " м." + "\nВес: " + weight + " кг.");
            Console.WriteLine("\n");
            #endregion

            //ФОРМАТИРОВАННЫЙ ВЫВОД.
            #region
            Console.WriteLine("{0:N1}", name + " - Имя.");
            Console.WriteLine("{0:N1}", sureName + " - Фамилия.");
            Console.WriteLine("{0:N1}", age + " лет - Возраст."); 
            Console.WriteLine("{0:N1}", height + " м. - Рост.");
            Console.WriteLine("{0:N1}", weight + " кг. - Вес.");
            Console.WriteLine("\n");
            #endregion

            //ВЫВОД СО ЗНАКОМ $  //ВОПРОС: Почему-то вместо знака $ везде ? - не понял как исправить.
            #region
            Console.WriteLine("{0:C}", name + " - Имя."); 
            Console.WriteLine("{0:C}", sureName + " - Фамилия.");
            Console.WriteLine("{0:C}", age + " лет - Возраст.");
            Console.WriteLine("{0:C}", height + " м. - Рост."); 
            Console.WriteLine("{0:C}", weight + " кг. - Вес.");
            Console.WriteLine("\n"); 
            #endregion

            //РАССЧЕТ ИНДЕКСА МАССЫ ТЕЛА (На основе выше введенных данных)
            #region
            double m = weight;
            double h = height;
            double I = m / (h * h);
            Console.WriteLine("Ваш индекс массы тела равен: ");
            Console.WriteLine("{0:N}", I + " кг/м2.");
            Console.WriteLine("\n");
            #endregion

            //РАССЧЕТ ИНДЕКСА МАССЫ ТЕЛА (На основе новых введеных данных)
            #region
            double massa = 84.3;
            Console.WriteLine("Масса тела: " + massa + " кг.");
            double growth = 1.93;
            Console.WriteLine("Рост: " + growth + " м.");
            double BMI = massa / (growth * growth);
            Console.WriteLine("Индекс массы тела равен: ");
            Console.WriteLine("{0:N}", BMI + " кг/м2.");
            Console.WriteLine("\n");
            #endregion
        }

    }

}