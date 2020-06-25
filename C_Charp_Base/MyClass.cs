using System;


namespace C_Charp_Base
{
    class MyClass
    {
        public static void Pause()
        {
            Console.WriteLine("Для продолжения нажмите любую кнопку");
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
            Console.WriteLine("Напишите первое значение");
            var a = Console.ReadLine();
            Console.WriteLine("Напишите второе значение");
            var b = Console.ReadLine();
            var c = a;
            a = b;
            b = c;
            Console.WriteLine($"{a}, {b}");
        }

        public static void SwitchValueEasy()
        {
            Console.WriteLine("Внимание! Этот метод подходит только для целых чисел");
            Console.WriteLine("Напишите первое значение");
            var a = int.Parse(Console.ReadLine());
            Console.WriteLine("Напишите второе значение");
            var b = int.Parse(Console.ReadLine());
            a += b;
            b = a - b;
            a -= b;
            Console.WriteLine($"{a}, {b}");
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
            Console.WriteLine($"Длина вектора равняется  {r:F2}");
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
