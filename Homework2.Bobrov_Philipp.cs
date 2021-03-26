using System;

namespace Homework2.Bobrov_Philipp
{
    /*
1.Написать метод, возвращающий минимальное из трёх чисел.
2.Написать метод подсчета количества цифр числа.
3.С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
4.Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль.На выходе истина, если прошел авторизацию, и ложь, если не прошел 
    (Логин: root, Password: GeekBrains). Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше 
    или не пропускает.С помощью цикла do while ограничить ввод пароля тремя попытками.
5.
    а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
    б) * Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
6.*Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000. «Хорошим» называется число, которое делится на сумму своих цифр. 
    Реализовать подсчёт времени выполнения программы, используя структуру DateTime.
7.
    a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
    б) * Разработать рекурсивный метод, который считает сумму чисел от a до b.
    */

    class Program
    {


        static void Main(string[] args)
        {


            #region Задача #1. Написать метод, возвращающий минимальное из трёх чисел.

            int x = 20;
            int y = 135;
            int z = 70;

            int min1 = x < y || x < z ? x : y;
            int min2 = z < y ? z : y;
            int min3 = min1 < min2 ? min1 : min2;

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            Console.WriteLine("Минимальное число: " + min3);
            #endregion

            #region Задача#2. Написать метод подсчета количества цифр числа.

            Console.WriteLine("Количество цифр: " + CountNum(28538));

            static long CountNum(long m)  // нерекурсивный метод
            {
                long n = 0;

                while (m > 0)
                {

                    m = m / 10;
                    n++;

                }
                return n;
            }
            #endregion

            #region Задача#3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.

            int p, count = 0; 
            do
            {
                static bool Odd(int p)
                {
                    return p % 2 == 0;
                }

                Console.Write("Введите число '0': ");
                p = int.Parse(Console.ReadLine());
                Console.WriteLine((Odd(p) || p < 0 ? count += 0 : count += p));
            }
            while (p != 0);
            
            Console.WriteLine("Сумма введеных нечетных положительных чисел равна: " + count);

            #endregion

            #region Задача#4. Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.С помощью цикла do while ограничить ввод пароля тремя попытками.

            int score = 0;

            do
            {
                Console.WriteLine("Пожалуйста, введите логин: ");
                string login = Console.ReadLine();
                string rightlogin = "root";
                Console.WriteLine("Пожалуйста, введите пароль: ");
                string password = Console.ReadLine();
                string rightpassword = "GeekBrains";

                if (login == rightlogin && password == rightpassword)
                {
                    Console.WriteLine("Добро пожаловать!");
                    score += 4;
                }
                else 
                {
                    Console.WriteLine("Неверный логин или пороль. Попробуйте снова");
                    score++;
                }

            }
            while (score < 3);



            #endregion

            #region Задача#5.п.а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.

            Console.WriteLine("Добро пожаловать!\nПожалуйста, ответьте на несколько вопросов.");

            Console.WriteLine("Укажите ваш рост(в метрах).");
            double height;
            string heightText = Console.ReadLine();
            height = Convert.ToDouble(heightText);

            Console.WriteLine("Укажите ваш вес(в килограммах).");
            double weight;
            string weightText = Console.ReadLine();
            weight = Convert.ToDouble(weightText);

            double m = weight;
            double h = height;
            double I = m / (h * h);
            Console.WriteLine("Ваш индекс массы тела равен: ");
            Console.WriteLine("{0:N}", I);
            Console.WriteLine("\n");

            if (I < 16) Console.WriteLine("У Вас выраженный дефицит массы тела. Вам необходимо набрать вес.");
            if (I > 16 && I < 18.5) Console.WriteLine("У Вас недостаточная(дефицит) масса тела. Вам необходимо набрать вес.");
            if (I > 18.5 && I < 25) Console.WriteLine("Ваш вес в норме.");
            if (I > 25 && I < 30) Console.WriteLine("У Вас избыточная масса тела(предожирение). Вам необходимо сбросить вес.");
            if (I > 30 && I < 35) Console.WriteLine("У Вас ожирение. Вам необходимо сбросить вес.");
            if (I > 35 && I < 40) Console.WriteLine("У Вас ожирение резкое. Вам необходимо сбросить вес.");
            if (I > 40) Console.WriteLine("У Вас очень резкое ожирение. Вам необходимо сбросить вес.");

            #endregion

            #region Задача#5.п.б) * Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
            
            double needMassaPlus;
            double needMassaMinus;

            double indexMin = 18.5;
            double indexMax = 25;

            needMassaPlus = (indexMin - I) * (h * h);
            needMassaMinus = (I - indexMax) * (h * h);

            if (I < 16) Console.WriteLine("У Вас выраженный дефицит массы тела. Вам необходимо набрать " + needMassaPlus + " кг.");
            if (I > 16 && I < 18.5) Console.WriteLine("У Вас недостаточная(дефицит) масса тела. Вам необходимо набрать " + needMassaPlus + " кг.");
            if (I > 18.5 && I < 25) Console.WriteLine("Ваш вес в норме.");
            if (I > 25 && I < 30) Console.WriteLine("У Вас избыточная масса тела(предожирение). Вам необходимо сбросить " + needMassaMinus + " кг.");
            if (I > 30 && I < 35) Console.WriteLine("У Вас ожирение. Вам необходимо сбросить " + needMassaMinus + " кг.");
            if (I > 35 && I < 40) Console.WriteLine("У Вас ожирение резкое. Вам необходимо сбросить " + needMassaMinus + " кг.");
            if (I > 40) Console.WriteLine("У Вас очень ерское ожирение. Вам необходимо сбросить " + needMassaMinus + " кг.");

            #endregion

            #region Задача#6.*Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000. «Хорошим» называется число, которое делится на сумму своих цифр.

            DateTime start = DateTime.Now;
            static bool Check(int a)
            {

                int h;
                h = a % 10 + a / 10 % 10;
                if (a % 10 > 0 && a % h == 0) return true; else return false;
            }

            for (int i = 1; i <= 1000000000; i++)
                if (Check(i)) Console.WriteLine(i);
            Console.WriteLine("Время выполненения программы:");
            Console.WriteLine(DateTime.Now - start);

            #endregion

            #region  Задача#7.п.a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).

            Loop1(52, 83);

            static void Loop1(int a, int b)
            {

                Console.Write("{0} ", a);
                if (a < b) Loop1(a + 1, b);

            }

            #endregion

            #region  Задача#7.п.б) * Разработать рекурсивный метод, который считает сумму чисел от a до b.

            Loop2(27, 121);


            static void Loop2(int a, int b)
            {
                int s = a + (a + 1);
                Console.Write("{0} ", s);
                if (a < b) Loop2(a + 1, b);

            }

            #endregion


        }
    }
}
