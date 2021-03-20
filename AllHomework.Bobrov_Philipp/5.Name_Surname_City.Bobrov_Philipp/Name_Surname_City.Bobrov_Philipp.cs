using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Name_Surname_City.Bobrov_Philipp
// а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
// б) * Сделать задание, только вывод организовать в центре экрана.
// в) ** Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y).
{
    class Program
    {
        //МЕТОДЫ И ФУНКЦИИ
        #region
        static void MyPrint(string info)
        {
            Console.WriteLine(info);
        }
        static void MyPrint(int x, int y)
        {
            Console.SetCursorPosition(x, y);
        }
        static void MyPrint(string info, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(info);
        }
        static void MyPrint(ConsoleColor myColor)
        {
            Console.ForegroundColor = myColor;
        }
        static void MyPrint(int x, int y, ConsoleColor myColor)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = myColor;
            

        }
        static void Main(string[] args)
        #endregion
        {
            // ВЫВОД информации об Ф.И.О. и городе проживания.
            #region
            MyPrint("Имя: Филипп / Фамилия: Бобров / Отчество: Алексеевич / Город проживания: Калининград.\n");
            MyPrint("Имя: Филипп\nФамилия: Бобров\nОтчество: Алексеевич\nГород проживания: Калининград.");
            #endregion

            // ВЫВОД информации по центру экрана.
            #region
            MyPrint(50, 5);
            MyPrint("Имя: Филипп");
            MyPrint(50, 6);
            MyPrint("Фамилия: Бобров");
            MyPrint(50, 7);
            MyPrint("Город: Калининград.");
            #endregion

            // ВЫВОД информации с дополнительными методами.
            #region
            MyPrint(35, 9, ConsoleColor.Green);
            MyPrint("Имя: Филипп / Фамилия: Бобров / Город: Калининград");
            MyPrint(ConsoleColor.Red);
            MyPrint("Благодарю за посещение анкеты!", 43, 11);
            #endregion
        }
    }
}
