using System;


// Гаврилов Владимир.
namespace Lesson3
{
    class Program
    {
        // 1. а) Дописать структуру Complex, добавив метод вычитания комплексных чисел.
        //       Продемонстрировать работу структуры.
        //    б) Дописать класс Complex, добавив методы вычитания и произведения чисел.
        //       Проверить работу класса.
        //    в) Добавить диалог с использованием switch демонстрирующий работу класса.

        // 2. а) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке).
        //       Требуется подсчитать сумму всех нечетных положительных чисел.
        //       Сами числа и сумму вывести на экран, используя tryParse;
        static void Main()
        {
            ComplexStructDemonstration();

            SummOddNumbers();

            ComplexClassDemonstration();
        }

        private static void SummOddNumbers()
        {
            Console.Clear();
            Console.WriteLine("\t\t Подсчет суммы всех нечетных положительных чисел из введенного ряда\n");
            Console.WriteLine("\t Введите ряд чисел. Закончите ввод нулем");
            bool flag;
            int x = -1;
            int result = 0;
            while (x != 0)
            {
                do
                {
                    string s = Console.ReadLine();
                    flag = int.TryParse(s, out x);
                }
                while (!flag);
                result = x % 2 != 0 ? result + x : result;
            }
            Console.WriteLine($"Сумма нечетных чисел: {result}");
            Console.ReadKey();
        }

        private static void ComplexClassDemonstration()
        {
            Console.Clear();
            Console.WriteLine("\t\tДемонстрация работы класса ComplexС\n");
            // Описали ссылку на объект.
            ComplexC complex1;
            // Создали объект и сохранили ссылку на него в complex1.
            complex1 = new ComplexC(1, 1);
            // Описали объект и создали его.
            ComplexC complex2 = new ComplexC(2, 2);
            // С помощью свойства Im изменили внутреннее (приватное) поле im.
            complex2.Im = 3;
            // Создали ссылку на объект.
            ComplexC result;
            // Так как в методе Plus создается новый объект,
            // в result сохраняем ссылку на вновь созданный объект.
            result = complex1.Plus(complex2);
            Console.Write($"\tПервое комплексное число: {complex1.ToString}");
            Console.WriteLine($"\tВторое комплексное число: {complex2.ToString}");
            Console.WriteLine("\tВыберите операцию:");
            Console.WriteLine("\t 1.Сумма. ");
            Console.WriteLine("\t 2.Разность. ");
            Console.WriteLine("\t 3.Произведение. ");
            Console.WriteLine("\t 0.Выход из программы. ");
            string value = Console.ReadLine();
            switch (value)
            {
                case "1":
                    Console.WriteLine("\tСумма: " + result.ToString);
                    break;
                case "2":
                    Console.WriteLine("\tРазность: " + complex1.Minus(complex2).ToString);
                    break;
                case "3":
                    Console.WriteLine("\tПрозведение: " + complex1.Multi(complex2).ToString);
                    break;
                default:
                    break;
            }
            if (value != "0")
                Console.ReadKey();

            if (value == "0")
                return;
            else ComplexClassDemonstration();
        }

        private static void ComplexStructDemonstration()
        {
            Console.Clear();
            Console.WriteLine("\t\tДемонстрация работы структуры ComplexS\n");

            ComplexS complex1;
            complex1.re = 1;
            complex1.im = 1;

            ComplexS complex2;
            complex2.re = 2;
            complex2.im = 2;

            ComplexS result = complex1.Plus(complex2);
            Console.Write($"\tСкладываем {complex1.ToString} и {complex2.ToString}  получается: ");
            Console.WriteLine(result.ToString);
            Console.ReadKey();

            result = complex1.Multi(complex2);
            Console.Write($"\tПеремножаем {complex1.ToString} и {complex2.ToString}  получается: ");
            Console.WriteLine(result.ToString);
            Console.ReadKey();

            // Демонстрация метода вычитания комплексных чисел.
            result = complex1.Minus(complex2);
            Console.Write($"\tРазность чисел {complex1.ToString} и {complex2.ToString}  равняется: ");
            Console.WriteLine(result.ToString);
            Console.ReadKey();
        }
    }
}
