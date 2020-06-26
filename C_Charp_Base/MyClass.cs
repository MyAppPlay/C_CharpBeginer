using System;


namespace C_Charp_Base
{
    class MyClass
    {
        public static void Pause()
        {
            Console.WriteLine("\tДля продолжения нажмите любую кнопку");
            Console.ReadKey();
        }

        public static void Print(string s)
        {
            Console.WriteLine(s);
        }

        public static void Resume(string Name1, string Name2, string Town)
        {
            var l = (Name1.Length + Name2.Length + Town.Length) / 2;
            Console.SetWindowSize(Console.LargestWindowWidth/2, Console.LargestWindowHeight/2);
            Console.SetCursorPosition(Console.WindowWidth/2 - l, 1);
            Console.WriteLine($"{Name1} {Name2}, {Town}");
        }

        public static void SwitchValue()
        {
            Console.Clear();
            Console.WriteLine("\n\t\tПрограмма обмена значениями двух переменных с использованием третьей");
            Console.Write("\n\tНапишите первое значение\t");
            var a = Console.ReadLine();
            Console.Write("\n\tНапишите второе значение\t");
            var b = Console.ReadLine();
            var c = a;
            a = b;
            b = c;
            Console.Write("\tСтатус : ok\t");
            Console.WriteLine($"{a}, {b}");
        }

        public static void SwitchValueEasy()
        {
            Console.Clear();
            Console.WriteLine("\n\t\tПрограмма обмена значениями двух переменных без использования третьей");

            Console.WriteLine("\t\tВнимание! Этот метод подходит только для целых чисел\n");
            Console.Write("\tНапишите первое значение\t");
            var a = int.Parse(Console.ReadLine());
            Console.Write("\tНапишите второе значение\t");
            var b = int.Parse(Console.ReadLine());
            a += b;
            b = a - b;
            a -= b;
            Console.WriteLine("\tСтатус : ok\t");
            Console.WriteLine($"\tЗначение первой переменной стало:\t{a},\n" +
                $"\tЗначение второй переменной стало:\t {b}");
        }

        public static void VectorLength()
        {
            Console.WriteLine("Введите координату x1");
            var x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату x2");
            var x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату y1");
            var y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату y2");
            var y2 = double.Parse(Console.ReadLine());
            var r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine($"Длина ОТРЕЗКА равняется  {r:F2}");
        }

        public static void IMT()
        {
            Console.WriteLine("Какой у тебя рост?");
            var h = double.Parse(Console.ReadLine());
            Console.WriteLine("Какой у тебя вес?");
            var m = double.Parse(Console.ReadLine());
            var I = m / (h * h);
            Console.WriteLine($"ИМТ составляет {I}");
        }

        public static int  Random(int x, int y)
        {
            var r = new Random();
            return r.Next(x, y);
        }

        public static void ConsoleBackgroundAndForegroundColor()
        {
                Console.BackgroundColor = (ConsoleColor)Random(13,16);
                Console.ForegroundColor = (ConsoleColor)Random(0, 6);
        }
    }
}
