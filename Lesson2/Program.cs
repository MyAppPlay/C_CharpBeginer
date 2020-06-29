using System;
using static Lesson2.MyClass2;

/// <summary>
/// Гаврилов Владимир. Домашнее задание к уроку номер два.
/// </summary>
namespace Lesson2
{
    partial class Program
    {
        const string V1 = "\t 1.Рекурсия";
        const string V1A = "\t a.Рекурсивный метод, который выводит на экран числа от a до b (a<b)";
        const string V1B = "\t b.Рекурсивный метод, который считает сумму чисел от a до b\n";
        const string V2 = "\t 2.Программа подсчета количества «Хороших» чисел в указанном диапазоне\n";
        const string V3 = "\t 3.Определение ИМТ\n";

        static void Main()
        {
            string value;
            do
            {
                Console.Clear();

                Console.WriteLine($"{V1}\n\t{V1A}\n\t{V1B}\n{V2}\n{V3}");
                Console.Write("\tДля продолжения наберите номер пункта.(Например \"1a\")" +
                    "\n\tДля выхода из программы наберите цифру 0\t");
                value = Console.ReadLine();
                switch (value)
                {
                    case "1a":
                        Console.Write("\n\tОт какого числа начнется числовой ряд: ");
                        var a = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\tКаким числом числовой ряд закончится: ");
                        var b = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\n\tПолучился такой числовой ряд: ");
                        PrintAllNumsRange(a, b);
                        Console.WriteLine();
                        Console.Write("\tДля продолжения нажмите любую кнопку");
                        Console.ReadKey();
                        break;
                    case "1b":
                        Console.Write("\n\tОт какого числа начнется числовой ряд: ");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\tКаким числом числовой ряд закончится: ");
                        b = Convert.ToInt32(Console.ReadLine());
                        var x = SumAllNumsRange(a, b);
                        Console.Write($"\n\tСумма чисел от {a} до {b} равняется: {x}");
                        Console.WriteLine();
                        Console.Write("\tДля продолжения нажмите любую кнопку");
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.WriteLine(QuantityGoodNums(1000));
                        Console.WriteLine();
                        Console.Write("\tДля продолжения нажмите любую кнопку");
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.Write("Твой вес(кг): ");
                        double weight = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Твой рост(м): ");
                        double height = Convert.ToDouble(Console.ReadLine());
                        BodyMassIndexAdvisor(weight, height);
                        Console.WriteLine();
                        Console.Write("\tДля продолжения нажмите любую кнопку");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("\n\tВы ВЫБРАЛИ не существующий пункт меню\n");
                        break;
                }
            }
            while (value != "0");

            Console.ReadKey();
        }
    }
}
