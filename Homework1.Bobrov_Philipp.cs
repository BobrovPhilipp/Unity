using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.Bobrov_Philipp
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

            #region Задание#1. Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес)
            Console.WriteLine("Добро пожаловать!\nПожалуйста, ответьте на несколько вопросов.");

            Console.WriteLine("Введите ваше имя.");
            string name = Console.ReadLine();

            Console.WriteLine("Введите вашу фамилию.");
            string sureName = Console.ReadLine();

            Console.WriteLine("Укажите ваш возраст.");
            string age = Console.ReadLine();
            Convert.ToInt32(age);

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
            #region Задание#1.п.a) Вывод, используя склеивание;
            Console.WriteLine("Ваши данные: ");
            Console.WriteLine("Имя: " + name + "\nФамилия: " + sureName + "\nВозраст: " + age + " лет" + "\nРост: " + height + " м." + "\nВес: " + weight + " кг.");
            Console.WriteLine("\n");
            #endregion 
            #region Задание#1.п.б) Вывод, используя склеивание;ФОРМАТИРОВАННЫЙ ВЫВОД.
            Console.WriteLine("{0:N1}", name + " - Имя.");
            Console.WriteLine("{0:N1}", sureName + " - Фамилия.");
            Console.WriteLine("{0:N1}", age + " лет - Возраст."); 
            Console.WriteLine("{0:N1}", height + " м. - Рост.");
            Console.WriteLine("{0:N1}", weight + " кг. - Вес.");
            Console.WriteLine("\n");
            #endregion
            #region Задание#1.п.в) Вывод, используя склеивание; ВЫВОД СО ЗНАКОМ $  //ВОПРОС: Почему-то вместо знака $ везде ? - не понял как исправить.
            Console.WriteLine("{0:C}", name + " - Имя."); 
            Console.WriteLine("{0:C}", sureName + " - Фамилия.");
            Console.WriteLine("{0:C}", age + " лет - Возраст.");
            Console.WriteLine("{0:C}", height + " м. - Рост."); 
            Console.WriteLine("{0:C}", weight + " кг. - Вес.");
            Console.WriteLine("\n");
            #endregion

            #region Задание #2.РАССЧЕТ ИНДЕКСА МАССЫ ТЕЛА (На основе выше введенных данных)
            double m = weight;
            double h = height;
            double I = m / (h * h);
            Console.WriteLine("Ваш индекс массы тела равен: ");
            Console.WriteLine("{0:N}", I + " кг/м2.");
            Console.WriteLine("\n");
            #endregion
            #region Задание#2.1.РАССЧЕТ ИНДЕКСА МАССЫ ТЕЛА (На основе новых введеных данных)
            double massa = 84.3;
            Console.WriteLine("Масса тела: " + massa + " кг.");
            double growth = 1.93;
            Console.WriteLine("Рост: " + growth + " м.");
            double BMI = massa / (growth * growth);
            Console.WriteLine("Индекс массы тела равен: ");
            Console.WriteLine("{0:N}", BMI + " кг/м2.");
            Console.WriteLine("\n");
            #endregion

            #region Задание#3.п.а)РАССЧЕТ РАССТОЯНИЯ МЕЖДУ ТОЧКАМИ ПО ФОРМУЛЕ (без функции, с ручным вводом значений пользователем).
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
            #region Задание#3.п.б) РАССЧЕТ РАССТОЯНИЯ МЕЖДУ ТОЧКАМИ ПО ФОРМУЛЕ (включение рассчетов в метод).
            MathXY();
            Console.WriteLine("Спасибо за использование данного сервиса! Всего доброго!");
            #endregion

            #region Задание#4.п.a) ОБМЕН ЗНАЧЕНИЙ (С третьей переменной и с выводом на экран)
            Console.WriteLine("ОБМЕН ЗНАЧЕНИЙ (С третьей переменной): ");
            int a = 150;
            int n = 60;
            mnText(a, n);

            int r = a;
            a = n;
            n = r;

            mnText(a, n);
            #endregion
            #region Задание#4.п.a) ОБМЕН ЗНАЧЕНИЙ (БЕЗ третьей переменной и с выводом на экран)
            Console.WriteLine("ОБМЕН ЗНАЧЕНИЙ (БЕЗ третьей переменной): ");
            int g = 111;
            int hh = 222;
            hgText(g, hh);

            g += hh;
            h = g - h;
            g -= hh;

            hgText(g, hh);
            #endregion

            #region Задание#5.п.а) ВЫВОД информации об Ф.И.О. и городе проживания.
            MyPrint("Имя: Филипп / Фамилия: Бобров / Отчество: Алексеевич / Город проживания: Калининград.\n");
            MyPrint("Имя: Филипп\nФамилия: Бобров\nОтчество: Алексеевич\nГород проживания: Калининград.");
            #endregion
            #region Задание#5.п.б) ВЫВОД информации по центру экрана.
            MyPrint(50, 5);
            MyPrint("Имя: Филипп");
            MyPrint(50, 6);
            MyPrint("Фамилия: Бобров");
            MyPrint(50, 7);
            MyPrint("Город: Калининград.");
            #endregion
            #region Задание#5.п.в) ВЫВОД информации с дополнительными методами.
            MyPrint(35, 9, ConsoleColor.Green);
            MyPrint("Имя: Филипп / Фамилия: Бобров / Город: Калининград");
            MyPrint(ConsoleColor.Red);
            MyPrint("Благодарю за посещение анкеты!", 43, 11);
            #endregion
        }

        #region Метод к 3-му заданию
        static void MathXY()
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
        #endregion
        #region Методы к 4-му заданию
        private static void mnText(int m, int n) //Вспомогательная функция для вывода значений "m" и "n" в консоль.
        {
            string m2Text = Convert.ToString(m);
            string n2Text = Convert.ToString(n);
            Console.WriteLine("a = " + m2Text + " " + "n = " + n2Text);
        }
        private static void hgText(int g, int h) //Вспомогательная функция для вывода значений "g" и "h" в консоль.
        {
            Convert.ToString(g);
            Convert.ToString(h);
            Console.WriteLine("g = " + g + " " + "hh = " + h);
        }
        #endregion
        #region Методы к 5-му заданию.
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

        #endregion
    }

    #region Задание#6.*Создать класс с методами, которые могут пригодиться в вашей учебе(Print, Pause).
    //Не понял, как создать метод Pause
    class MyFunctions
    {

        #region 1. МЕТОДЫ И ФУНКЦИИ (Print) - Выведение в консоль текста с разными свойствами (текст, положение, цвет).
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
        #endregion 
        #region 2. МЕТОДЫ И ФУНКЦИИ (Value_to_Value) - Обмен занчений между двумя и более переменными.
        static void ValueReplace()
        {
            Console.WriteLine("ОБМЕН ЗНАЧЕНИЙ: ");
            int g = 111;
            int h = 222;
            //int f = 555
            hgText(g, h);
            //hgText(g, h, f);

            g += h;
            h = g - h;
            g -= h;
            // f += h; // f += g;
            // h = f - h; // g = f - g;
            // f -= h; // f =- g

            hgText(g, h);
        }

        private static void hgText(int g, int h)
        {
            Convert.ToString(g);
            Convert.ToString(h);
            //Convert.ToString(f);
            Console.WriteLine("g = " + g + " h = " + h);
            //Console.WriteLine("g = " + g + " h = " + h + " f = " + f);
        }
        #endregion
        #region 3. МЕТОДЫ И ФУНКЦИИ (AudioAdd) - Функции для добавления/проигрывания/цикла/остановки аудио-файлов.
        static void audioLoop(string localMusic)
        {
            System.Reflection.Assembly asembly = System.Reflection.Assembly.GetExecutingAssembly();
            System.IO.Stream resourseStream =
                asembly.GetManifestResourceStream(localMusic);
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(resourseStream);
            player.PlayLooping();

        }
        static void audioOnePlay(string localMusic)
        {
            System.Reflection.Assembly asembly = System.Reflection.Assembly.GetExecutingAssembly();
            System.IO.Stream resourseStream =
                asembly.GetManifestResourceStream(localMusic);
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(resourseStream);
            player.Play();
        }
        static void audioStop(string localMusic)
        {
            System.Reflection.Assembly asembly = System.Reflection.Assembly.GetExecutingAssembly();
            System.IO.Stream resourseStream =
                asembly.GetManifestResourceStream(localMusic);
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(resourseStream);
            player.Stop();
        }
        #endregion

    }
    #endregion

}