using System;
using static C_Charp_Base.MyClass;

namespace C_Charp_Base
{
    class Program
    {
        #region Constants

        const string V1 = "\t1.Программа обмена значениями переменных";
        const string V1A = "\ta.С использованием третей переменной";
        const string V1B = "\tb.Без использования третьей переменной\n";
        const string V2 = "\t2.Определение длины отрезка по координатам\n";
        const string V3 = "\t3.Определение ИМТ\n";

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
                Console.WriteLine("Для продолжения наберите номер пункта.(Например \"1a\")\nДля выхода из программы наберите цифру 0");
                value = Console.ReadLine();

                if (value == "1a")
                    SwitchValue();
                else if (value == "1b")
                    SwitchValueEasy();
                else if (value == "2")
                    VectorLength();
                else if (value == "3")
                    IMT();
                else Console.WriteLine("Вы набрали не существующий пункт меню");
                Pause();
            }
            while (value != "0");
        }
    }
}
