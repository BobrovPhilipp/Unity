using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMetodAndFunction.Bobrov_Philipp
    //*Создать класс с методами, которые могут пригодиться в вашей учебе(Print, Pause).
{
    class MyFunctions
    {
        //МЕТОДЫ И ФУНКЦИИ (Print) - Выведение в консоль текста с разными свойствами (текст, положение, цвет).
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
        #endregion

        //МЕТОДЫ И ФУНКЦИИ (Value_to_Value) - Обмен занчений между двумя и более переменными.
        #region
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

        //МЕТОДЫ И ФУНКЦИИ (AudioAdd) - Функции для добавления/проигрывания/цикла/остановки аудио-файлов.
        #region
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

        //СКРИПТ (FOR UNITY) (Vel&PosForObject) - Функции для установки скорости движения и начальной позиции для объекта на сцене(Unity).
        #region
        void VelAndPos() // Вызывается либо в функции Start, либо Update
        {
             Vector2 vel = new Vector2(Random.Range(-2, -4), 0); // f = float Тип данных из категории int, double etc.
             gameObject.GetComponent<Rigidbody2D>().velocity = vel; // velocity - скорость Здесь: мы задаем скорость ускорения, зависящую от Vector2(vel)

             var firstPos = gameObject.transform.position; // Задаем начальную позицию объекта. Она же будет использоваться и для спавна клонов или же смены позиции.
             firstPos = new Vector3(firstPos.x, Random.Range(-2, 2) * 1.5f, firstPos.z); //Range - некое число с котором взаимодействуют следующие числа после ().
             gameObject.transform.position = firstPos;
        }

        // ИЛИ (ORANGE)

        void Start()
        {
            Vector2 velAttack = new Vector2(15f, 0);
            gameObject.GetComponent<Rigidbody2D>().velocity = velAttack;


            var posOrange = gameObject.transform.position; // Задаем начальную позицию объекта. Она же будет использоваться и для спавна клонов или же смены позиции.
            posOrange = new Vector3(posOrange.x, AttackSpawn_script.posY, posOrange.z); //Range - некое число с котором взаимодействуют следующие числа после ().
            gameObject.transform.position = posOrange;
        }
        #endregion

        //СКРИПТ (FOR UNITY) (SpawnObjectAndKeyMove) - Функции для создания и вызова клонов на сцене (Unity) + назначение клавиш.
        #region
        public GameObject zombie; // public - чтобы этот объект мог считываться программой Unity(строчка в скрипте) + Prafab - клон объекта, чтобы не использовать основной.
        void Start()
        {
            InvokeRepeating("SpawnZombie", 2f, 1f); // задает переодичность вызова метода (таймер) Здесь: Вызвать объект  zombie через 1 секунду каждые 4 секунды.
        }
        void SpawnZombie()
        {
            Instantiate(zombie); // Добавление заданного объекта на игровую сцену
        }

        // Назначение клавиш.
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                posY = gameObject.transform.position.y + 1.82f; - опционально - posY = см.выше в "ORANGE".
                var pos = gameObject.transform.position;
                pos.y += 1.5f;
                gameObject.transform.position = pos;
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                posY = gameObject.transform.position.y - 1.18f;
                var pos = gameObject.transform.position;
                pos.y -= 1.5f;
                gameObject.transform.position = pos;
            }
        }
        #endregion

        //СКРИПТ (FOR UNITY) (CollisionAndHP) - Функции для вызова коллизии без условий и введения примитивного здоровья (Unity).
        #region
        int hp = 100;
        void OnTriggerEnter2D(Collider2D collision)
        {

            hp -= 50;

            if (hp <= 0)
            {
                Destroy(gameObject);
            }

        }
        #endregion

        //СКРИПТ (FOR UNITY) (ScoreForOn/Off) - Последовательность для введения переменной для вкл/выкл. событий (Unity).
        #region
        int score = 0; // Текущее значение переменной
        int target = 0;// Необходимое значение переменной (опционально - можно обойтись и лишь score)
        GameObject someObject; // Событие

        public void Start()
        {
            someObject.SetActive(false); // or (true)
            score = 0;
            target = Random.someObject (40, 80); // если нужен рандомный диапазон
        }
        public void OnClick()
        {
            score += 1;
            if (score >= target)
            {
                someObject.SetActive(true); // or (false)
                target += 10;
                score = 0;
            }
        }
        #endregion
    }
}
