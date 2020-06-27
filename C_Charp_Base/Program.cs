using System;
using static C_Charp_Base.MyClass;

/// <summary>
/// Гаврилов Владимир. Домашнее задание к первому уроку.
/// </summary>
namespace C_Charp_Base 
{
    class Program
    {
        #region Constants

        const string V1 = "\t 1.Программа обмена значениями переменных";
        const string V1A = "\t a.С использованием третей переменной";
        const string V1B = "\t b.Без использования третьей переменной\n";
        const string V2 = "\t 2.Определение длины отрезка по координатам\n";
        const string V3 = "\t 3.Определение ИМТ\n";

        #endregion


        static void Main()
        {
            string value;
            do
            {

                ConsoleBackgroundAndForegroundColor();
                Console.Clear();

                Resume("Владимир", "Гаврилов", "Москва");

                Console.WriteLine($"{V1}\n\t{V1A}\n\t{V1B}\n{V2}\n{V3}");
                Console.Write("\tДля продолжения наберите номер пункта.(Например \"1a\")" +
                    "\n\tДля выхода из программы наберите цифру 0\t");
                value = Console.ReadLine();

                if (value == "1a")
                    SwitchValue();
                else if (value == "1b")
                    SwitchValueEasy();
                else if (value == "2")
                    VectorLength();
                else if (value == "3")
                    IMT();
                else if (value == "0")
                    break;
                else Console.WriteLine("\n\tВы ВЫБРАЛИ не существующий пункт меню\n");
                Pause();
            }
            while (value != "0");
        }
    }
}
