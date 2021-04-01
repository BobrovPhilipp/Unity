using System;

namespace Homework3.BobrovPhilipp

/* 1.
а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.
б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
в) Добавить диалог с использованием switch демонстрирующий работу класса.

2.
а) С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке). 
Требуется подсчитать сумму всех нечётных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse.

3. *Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел. Предусмотреть методы сложения, вычитания, умножения и деления дробей. 
Написать программу, демонстрирующую все разработанные элементы класса.
Добавить свойства типа int для доступа к числителю и знаменателю;
Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа; ?????? 
** Добавить проверку, чтобы знаменатель не равнялся 0. 
*Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0"); 
*** Добавить упрощение дробей. */
{
    #region Task#1.a) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.
    struct MyComplex
    {
        public double im;
        public double re;

        //  Пример вычитания двух комплексных чисел
        public MyComplex Minus(MyComplex x)
        {
            MyComplex y;
            y.im = im - x.im;
            y.re = re - x.re;
            return y;
        }
        //  Пример сложения двух комплексных чисел
        public MyComplex Plus(MyComplex x)
        {
            MyComplex y;
            y.im = im + x.im;
            y.re = re + x.re;
            return y;
        }
        
        //  Пример произведения двух комплексных чисел
        public MyComplex Multi(MyComplex x)
        {
            MyComplex y;
            y.im = re * x.im + im * x.re;
            y.re = re * x.re - im * x.im;
            return y;
        }
        public override string ToString()
        {
            if (im >= 0)
                return re + "+" + im + "i";
            else
                return re + "" + im + "i";
        }
    }
    #endregion
    #region Task#1.b) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
    class MyComplexClass
    {

        #region Поля

        /// <summary>
        /// Мнимая часть комплексного числа
        /// </summary>
        private double _im;

        /// <summary>
        /// Действительная часть комплексного числа
        /// </summary>
        private double _re;

        #endregion

        #region Свойства

        public double propIm
        {
            get { return _im; }
            set
            {
                if (value == 0)
                    throw new Exception("Мнимая часть комплексного числа не может быть равна нулю.");
                _im = value;
            }
        }

        public double propRe
        {
            get { return _re; }
            set { _re = value; }
        }

        #endregion 

        #region Конструкторы

        public MyComplexClass()
        {

        }

        /// <summary>
        /// Конструктор создает новое комплексное число с параметрами
        /// </summary>
        /// <param name="im">Мнимая часть комплексного числа</param>
        /// <param name="re">Действительная часть комплексного числа</param>
        public MyComplexClass(double im, double re)
        {
            if (im == 0)
                throw new Exception("Мнимая часть комплексного числа не может быть равна нулю.");

            _im = im;
            _re = re;
        }

        #endregion

        #region Публичные методы

        public MyComplexClass Plus(MyComplexClass x)
        {
            // Пример 1
            MyComplexClass y = new MyComplexClass(_im + x.propIm, _re + x.propRe);

            // Пример 2
            MyComplexClass y1 = new MyComplexClass();
            y1.propIm = _im + x.propIm;
            y1.propRe = _re + x.propRe;

            return y1;
        }

        public MyComplexClass Minus(MyComplexClass x)
        {
            MyComplexClass y2 = new MyComplexClass();
            y2.propIm = _im - x.propIm;
            y2.propRe = _re - x.propRe;
            return y2;
        }

        public MyComplexClass Multi(MyComplexClass x)
        {
            MyComplexClass y3 = new MyComplexClass();
            y3.propIm = _re * x.propIm + _im * x.propRe;
            y3.propRe = _re * x.propIm - _im * x.propIm;
            return y3;
        }

        public override string ToString()
        {
            if (_im > 0)
                return $"{_re} + {_im}i";
            else return $"{_re}{_im}i";
        }

        #endregion

    }
    #endregion



    #region Task#3 Описать класс дробей. Предусмотреть методы сложения, вычитания, умножения и деления дробей.

    class MyGrit
    {
        #region Поля

        /// <summary>
        /// Числитель первозаданного числа
        /// </summary>
        /// <param name="_num">Числитель числа(1)</param>
        private int _num;

        /// <summary>
        /// Знаменатель первозанного числа
        /// </summary>
        /// <param name="_denom">Знаменатель числа(1)</param>
        private int _denom;

        #endregion

        #region Свойства дробей. * Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0")

        /// <summary>
        /// Числитель последующих нововведенных дробей
        /// </summary>
        /// <param name="propNum">Числитель числа(2)</param>
        public int propNum
        {
            get { return _num; }
            set 
            { 
                _num = value; 
            }
        }

        /// <summary>
        /// Знаменитель последующих нововведенных дробей
        /// </summary>
        /// <param name="propDenom">Знаменатель числа(2)</param>
        public int propDenom
        {
            get { return _denom; }
            set 
            {
                if (value == 0)
                    throw new ArgumentException("Знаменатель не может быть равен 0");
                _denom = value; 
            }
        }

        #endregion

        #region Конструктор новых дробей. * Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0")

        public MyGrit()
        {
        }

        /// <summary>
        /// Конструктор создает новые дроби с заданными параметрами
        /// </summary>
        /// <param name="num">Числитель</param>
        /// <param name="denum">Знаменатель</param>
        public MyGrit(int num, int denum)
        {
            if (denum == 0)
                throw new ArgumentException("Знаменатель не может быть равен 0");

            _num = num;
            _denom = denum;
        }

        #endregion

        #region Методы для действий (сложение/вычитание/деление/умножение)

        //  Сложение
        public MyGrit Plus(MyGrit xgrit2)
        {
            MyGrit ySumm = new MyGrit(_num * xgrit2.propDenom + _denom * xgrit2.propNum, _denom * xgrit2.propDenom);
            //ySumm.propNum = _num * xgrit2.propDenom + _denom * xgrit2.propNum;
            //ySumm.propDenom = _denom * xgrit2.propDenom;

            #region Упрощение дробей для сложения
            while (ySumm.propNum % 2 == 0 && ySumm.propDenom % 2 == 0)
            {
                ySumm.propNum /= 2;
                ySumm.propDenom /= 2;
            }

            while(ySumm.propNum % 3 == 0 && ySumm.propDenom % 3 == 0)
            {
                ySumm.propNum /= 3;
                ySumm.propDenom /= 3;
            }

            while (ySumm.propNum % 4 == 0 && ySumm.propDenom % 4 == 0)
            {
                ySumm.propNum /= 4;
                ySumm.propDenom /= 4;
            }

            while (ySumm.propNum % 5 == 0 && ySumm.propDenom % 5 == 0)
            {
                ySumm.propNum /= 5;
                ySumm.propDenom /= 5;
            }

            while (ySumm.propNum % 7 == 0 && ySumm.propDenom % 7 == 0)
            {
                ySumm.propNum /= 7;
                ySumm.propDenom /= 7;
            }

            while (ySumm.propNum % 8 == 0 && ySumm.propDenom % 8 == 0)
            {
                ySumm.propNum /= 8;
                ySumm.propDenom /= 8;
            }

            while (ySumm.propNum % 9 == 0 && ySumm.propDenom % 9 == 0)
            {
                ySumm.propNum /= 9;
                ySumm.propDenom /= 9;
            }

            while (ySumm.propNum % 11 == 0 && ySumm.propDenom % 11 == 0)
            {
                ySumm.propNum /= 11;
                ySumm.propDenom /= 11;
            }

            while (ySumm.propNum % 13 == 0 && ySumm.propDenom % 13 == 0)
            {
                ySumm.propNum /= 13;
                ySumm.propDenom /= 13;
            }

            while (ySumm.propNum % 25 == 0 && ySumm.propDenom % 25 == 0)
            {
                ySumm.propNum /= 25;
                ySumm.propDenom /= 25;
            }

            while (ySumm.propNum % 125 == 0 && ySumm.propDenom % 125 == 0)
            {
                ySumm.propNum /= 125;
                ySumm.propDenom /= 125;
            }
            #endregion
            return ySumm;
        }
        
        //  Вычитание
        public MyGrit Minus(MyGrit xgrit2)
        {
            MyGrit yMinus = new MyGrit(_num * xgrit2.propDenom - _denom * xgrit2.propNum, _denom * xgrit2.propDenom);
            //yMinus.propNum = _num * xgrit2.propDenom - _denom * xgrit2.propNum;
            //yMinus.propDenom = _denom * xgrit2.propDenom;

            #region Упрощение дробей для вычитания
            while (yMinus.propNum % 2 == 0 && yMinus.propDenom % 2 == 0)
            {
                yMinus.propNum /= 2;
                yMinus.propDenom /= 2;
            }

            while (yMinus.propNum % 3 == 0 && yMinus.propDenom % 3 == 0)
            {
                yMinus.propNum /= 3;
                yMinus.propDenom /= 3;
            }

            while (yMinus.propNum % 4 == 0 && yMinus.propDenom % 4 == 0)
            {
                yMinus.propNum /= 4;
                yMinus.propDenom /= 4;
            }

            while (yMinus.propNum % 5 == 0 && yMinus.propDenom % 5 == 0)
            {
                yMinus.propNum /= 5;
                yMinus.propDenom /= 5;
            }

            while (yMinus.propNum % 7 == 0 && yMinus.propDenom % 7 == 0)
            {
                yMinus.propNum /= 7;
                yMinus.propDenom /= 7;
            }

            while (yMinus.propNum % 8 == 0 && yMinus.propDenom % 8 == 0)
            {
                yMinus.propNum /= 8;
                yMinus.propDenom /= 8;
            }

            while (yMinus.propNum % 9 == 0 && yMinus.propDenom % 9 == 0)
            {
                yMinus.propNum /= 9;
                yMinus.propDenom /= 9;
            }

            while (yMinus.propNum % 11 == 0 && yMinus.propDenom % 11 == 0)
            {
                yMinus.propNum /= 11;
                yMinus.propDenom /= 11;
            }

            while (yMinus.propNum % 13 == 0 && yMinus.propDenom % 13 == 0)
            {
                yMinus.propNum /= 13;
                yMinus.propDenom /= 13;
            }

            while (yMinus.propNum % 25 == 0 && yMinus.propDenom % 25 == 0)
            {
                yMinus.propNum /= 25;
                yMinus.propDenom /= 25;
            }

            while (yMinus.propNum % 125 == 0 && yMinus.propDenom % 125 == 0)
            {
                yMinus.propNum /= 125;
                yMinus.propDenom /= 125;
            }
            #endregion
            return yMinus;
        }
        
        //  Умножение
        public MyGrit Multi(MyGrit xgrit2)
        {
            MyGrit yMulti = new MyGrit(_num * xgrit2.propNum, _denom * xgrit2.propDenom);

            #region Упрощение дробей для умножения
            while (yMulti.propNum % 2 == 0 && yMulti.propDenom % 2 == 0)
            {
                yMulti.propNum /= 2;
                yMulti.propDenom /= 2;
            }

            while (yMulti.propNum % 3 == 0 && yMulti.propDenom % 3 == 0)
            {
                yMulti.propNum /= 3;
                yMulti.propDenom /= 3;
            }

            while (yMulti.propNum % 4 == 0 && yMulti.propDenom % 4 == 0)
            {
                yMulti.propNum /= 4;
                yMulti.propDenom /= 4;
            }

            while (yMulti.propNum % 5 == 0 && yMulti.propDenom % 5 == 0)
            {
                yMulti.propNum /= 5;
                yMulti.propDenom /= 5;
            }

            while (yMulti.propNum % 7 == 0 && yMulti.propDenom % 7 == 0)
            {
                yMulti.propNum /= 7;
                yMulti.propDenom /= 7;
            }

            while (yMulti.propNum % 8 == 0 && yMulti.propDenom % 8 == 0)
            {
                yMulti.propNum /= 8;
                yMulti.propDenom /= 8;
            }

            while (yMulti.propNum % 9 == 0 && yMulti.propDenom % 9 == 0)
            {
                yMulti.propNum /= 9;
                yMulti.propDenom /= 9;
            }

            while (yMulti.propNum % 11 == 0 && yMulti.propDenom % 11 == 0)
            {
                yMulti.propNum /= 11;
                yMulti.propDenom /= 11;
            }

            while (yMulti.propNum % 13 == 0 && yMulti.propDenom % 13 == 0)
            {
                yMulti.propNum /= 13;
                yMulti.propDenom /= 13;
            }

            while (yMulti.propNum % 25 == 0 && yMulti.propDenom % 25 == 0)
            {
                yMulti.propNum /= 25;
                yMulti.propDenom /= 25;
            }

            while (yMulti.propNum % 125 == 0 && yMulti.propDenom % 125 == 0)
            {
                yMulti.propNum /= 125;
                yMulti.propDenom /= 125;
            }
            #endregion
            return yMulti;
        }

        //  Деление
        public MyGrit Div(MyGrit xgrit2)
        {
            MyGrit yDiv = new MyGrit(_num * xgrit2.propDenom, _denom * xgrit2.propNum);

            #region Упрощение дробей для умножения
            while (yDiv.propNum % 2 == 0 && yDiv.propDenom % 2 == 0)
            {
                yDiv.propNum /= 2;
                yDiv.propDenom /= 2;
            }

            while (yDiv.propNum % 3 == 0 && yDiv.propDenom % 3 == 0)
            {
                yDiv.propNum /= 3;
                yDiv.propDenom /= 3;
            }

            while (yDiv.propNum % 4 == 0 && yDiv.propDenom % 4 == 0)
            {
                yDiv.propNum /= 4;
                yDiv.propDenom /= 4;
            }

            while (yDiv.propNum % 5 == 0 && yDiv.propDenom % 5 == 0)
            {
                yDiv.propNum /= 5;
                yDiv.propDenom /= 5;
            }

            while (yDiv.propNum % 7 == 0 && yDiv.propDenom % 7 == 0)
            {
                yDiv.propNum /= 7;
                yDiv.propDenom /= 7;
            }

            while (yDiv.propNum % 8 == 0 && yDiv.propDenom % 8 == 0)
            {
                yDiv.propNum /= 8;
                yDiv.propDenom /= 8;
            }

            while (yDiv.propNum % 9 == 0 && yDiv.propDenom % 9 == 0)
            {
                yDiv.propNum /= 9;
                yDiv.propDenom /= 9;
            }

            while (yDiv.propNum % 11 == 0 && yDiv.propDenom % 11 == 0)
            {
                yDiv.propNum /= 11;
                yDiv.propDenom /= 11;
            }

            while (yDiv.propNum % 13 == 0 && yDiv.propDenom % 13 == 0)
            {
                yDiv.propNum /= 13;
                yDiv.propDenom /= 13;
            }

            while (yDiv.propNum % 25 == 0 && yDiv.propDenom % 25 == 0)
            {
                yDiv.propNum /= 25;
                yDiv.propDenom /= 25;
            }

            while (yDiv.propNum % 125 == 0 && yDiv.propDenom % 125 == 0)
            {
                yDiv.propNum /= 125;
                yDiv.propDenom /= 125;
            }
            #endregion
            return yDiv;
        }

        #endregion

        public override string ToString()
        {
            return $"{_num}/{_denom}";
        }
    }


    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            #region Task#1.a)Вывод действий структуры MyComplex

            MyComplex complex1;
            complex1.re = 5;
            complex1.im = 1;

            MyComplex complex2;
            complex2.re = 3;
            complex2.im = 4;

            MyComplex result = complex1.Plus(complex2);
            Console.WriteLine("Сумма двух комплексных чисел(структура): " + result.ToString());
            result = complex1.Multi(complex2);
            Console.WriteLine("Произведение двух комплексных чисел(структура): " + result.ToString());
            result = complex1.Minus(complex2);
            Console.WriteLine("Вычетание двух комплексных чисел(структура): " + result.ToString() + "\n");
            #endregion

            #region Task#1.b)Вывод действий класса MyComplexClass

            MyComplexClass complex01 = new MyComplexClass(-5,8);
            //complex01.propIm = -5;
            //complex01.propRe = 8;

            MyComplexClass complex02 = new MyComplexClass(3,4);
            //complex02.propIm = 3;
            //complex02.propRe = 4;

            #region Task#1.с) Добавить диалог с использованием switch демонстрирующий работу класса.
            var resultClass = complex01.Plus(complex02);
            int m = 0;
            do
            {
                Console.WriteLine("Выберете:\n1 - вывести сумму комплексных чисел\n2 - вывести вычитание комплексных чисел\n3 - вывести произведение комплексных чисел\n4 - закончить");
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    if (number > 0 && number < 5)
                        switch (number)
                        {
                            case 1:
                                Console.WriteLine("Сумма двух комлексных чисел(класс): " + resultClass.ToString());
                                break;
                            case 2:
                                resultClass = complex01.Minus(complex02);
                                Console.WriteLine("Вычитание двух комлексных чисел(класс): " + resultClass.ToString());
                                break;
                            case 3:
                                resultClass = complex01.Multi(complex02);
                                Console.WriteLine("Произведение двух комлексных чисел(класс): " + resultClass.ToString());
                                break;
                            case 4:
                                m += 4;
                                Console.WriteLine("Завершение работы" + "\n");
                                break;
                        }
                    else Console.WriteLine("Введите число в диапозоне от 1 до 4");
                }
                else Console.WriteLine("Вы ввели некорректное значение. Пожалуйста, введите целое число в диапозоне от 1 до 4");

            }
            while (m != 4);

            #endregion

            #endregion

            #region Task#2. С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке). Подсчитать сумму всех нечётных положительных чисел. Вывести на экран, используя tryParse.
            int p;
            int count = 0;
            do
            {
                static bool Odd(int p)
                {
                    return p % 2 == 0;
                }

                Console.Write("Введите число '0': ");
                if (int.TryParse(Console.ReadLine(), out p))
                    Console.WriteLine((Odd(p) || p < 0 ? count += 0 : count += p));
                else
                {
                    Console.WriteLine("Вы ввели некорректное значение. Введите 0, либо любое положительное число.");
                    p = count;
                }
                
            }
            while (p != 0);

            Console.WriteLine("Сумма введеных нечетных положительных чисел равна: " + count + "\n");
            #endregion

            
            #region Task#3.Ввод собственных значений дроби с исключением на ввод текста.

                Console.Write("Введите числитель первой дроби: \n");
                if (int.TryParse(Console.ReadLine(), out int grit01))
                {
                    Console.WriteLine($"Числитель первой дроби: {grit01}\n");
                    Console.WriteLine("Введите знаменатель первой дроби: ");
                }

                else 
                {
                    Console.WriteLine("Ошибка ввода. Некорректное значение.");
                    return;
                }

                if (int.TryParse(Console.ReadLine(), out int grit02))
                    Console.WriteLine($"Знаменатель первой дроби: {grit02}\n");
                else
                {
                    Console.WriteLine("Ошибка ввода. Некорректное значение.");
                    return;
                }

                MyGrit grit1 = new MyGrit(grit01, grit02);


                Console.Write("Введите числитель второй дроби: \n");
                if (int.TryParse(Console.ReadLine(), out int grit03))
                {
                    Console.WriteLine($"Числитель второй дроби: {grit03}\n");
                    Console.WriteLine("Введите знаменатель второй дроби: ");
                }
                else
                {
                    Console.WriteLine("Ошибка ввода. Некорректное значение.");
                    return;
                }

                if (int.TryParse(Console.ReadLine(), out int grit04))
                Console.WriteLine($"Числитель второй дроби: {grit04}\n");
                else
                {
                    Console.WriteLine("Ошибка ввода. Некорректное значение.");
                    return;
                }

                MyGrit grit2 = new MyGrit(grit03, grit04);

                #endregion

                #region Вывод действий класса MyGrit с помощью switch.
                int r = 0;
                do
                {
                    Console.WriteLine("Пожалуйста, выберете действие:\n1.Сложение дробей.\n2.Вычитание дробей.\n3.Умножение дробей.\n4.Деление дробей.\n5.Завершить работу.");
                    if (int.TryParse(Console.ReadLine(), out int number))
                    {
                        if (number > 0 && number < 6)
                            switch (number)
                            {
                                case 1:
                                    var resultgrit = grit1.Plus(grit2);
                                    Console.WriteLine($"Сумма дробей равна: {grit1.ToString()} + {grit2.ToString()} = {resultgrit.ToString()}\n");
                                    break;
                                case 2:
                                    resultgrit = grit1.Minus(grit2);
                                    Console.WriteLine($"Разность дробей равна: {grit1.ToString()} - {grit2.ToString()} = {resultgrit.ToString()}\n");
                                    break;
                                case 3:
                                    resultgrit = grit1.Multi(grit2);
                                    Console.WriteLine($"Произведение дробей равно: {grit1.ToString()} * {grit2.ToString()} = {resultgrit.ToString()}\n");
                                    break;
                                case 4:
                                    resultgrit = grit1.Div(grit2);
                                    Console.WriteLine($"Частное дробей равно: {grit1.ToString()} : {grit2.ToString()} = {resultgrit.ToString()}\n");
                                    break;
                                case 5:
                                    r += 5;
                                    break;
                            }
                        else Console.WriteLine("Некорректное число. Пожалуйста, введите число в диапозоне от 1 до 5");
                    }
                    else
                    {
                        Console.WriteLine("Вы ввели текст. Пожалуйста, введите корректное число от 1 до 5");
                        number = r;
                    }
                }
                while (r != 5);

            Console.WriteLine($"Завершение работы.");
            Console.ReadKey();
            #endregion
        }
    }

}
