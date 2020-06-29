using System;


namespace Lesson2
{
    class MyClass2
    {

        public static int SumAllNumsRange(int a, int b)
        {
            if (a == b)
                return b;
            else
                return a + SumAllNumsRange(a + 1, b);
        }

        public static void PrintAllNumsRange(int a, int b)
        {
            Console.Write($"{a} ");
            if (a < b)
                PrintAllNumsRange(a + 1, b);
        }

        public static int SumNumValue(int n)
        {
            var x = 0;
            while (n > 0)
            {
                x += n % 10;
                n /= 10;
            }
            return x;
        }

        public static int QuantityGoodNums(int value = 1_000_000_000)
        {
            var ctn = 1;
            var ctnGN = 0;
            var time = DateTime.Now;

            while (ctn <= value)
            {
                if (ctn % SumNumValue(ctn) == 0)
                {
                    ctnGN++;
                    Console.WriteLine($"{ctn}  {DateTime.Now - time}");
                }
                ctn++;
            }
            Console.Write("Количество \"хороших\"чисел: ");
            return ctnGN;
        }

        public static void BodyMassIndexAdvisor(double weight, double height)
        {
            var bmi = weight / (height * height);
            var norm = bmi > 18.5 && bmi < 25;
            if (norm)
                Console.WriteLine("Ваш индекс массы тела в норме");
            else if (bmi < 18.5)
                Console.WriteLine($"Вам следует набрать {18.5 - bmi} кг");
            else if (bmi > 25)
                Console.WriteLine($"Вам следует сбросить {bmi - 25:F1} кг");
            Console.ReadKey();
        }
    }
}

