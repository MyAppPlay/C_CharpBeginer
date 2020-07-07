using System;
using System.IO;

// Гаврилов Владимир
namespace Lesson4
{
    //    Реализуйте задачу 1 в виде статического класса StaticClass;
    //  а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
    //  б) * Добавьте статический метод для считывания массива из текстового файла.Метод должен возвращать массив целых чисел;
    //  в)** Добавьте обработку ситуации отсутствия файла на диске.
    partial class Program
    {
        static class MyArray
        {
            public static void WriteArrayForFile(int[] array)
            {
                StreamWriter streamWriter = new StreamWriter("data.txt");
                streamWriter.WriteLine(array.Length);
                for (int i = 0; i < array.Length; i++)
                {
                    streamWriter.WriteLine(array[i]);
                }
                streamWriter.Close();
            }

            public static int[] ReadArrayFromFile(string path)
            {
                StreamReader streamReader = new StreamReader(path);

                int length = int.Parse(streamReader.ReadLine());
                int[] result = new int[length];
                for (int i = 0; i < length; i++)
                {
                    result[i] = int.Parse(streamReader.ReadLine());
                }
                streamReader.Close();
                return result;
            }


            public static int[] GenerateArray(int arrayLength)
            {
                Console.WriteLine($"Имеем целочисленный массив из {arrayLength} элементов, " +
                    $"сгенерированый из случайных чисел");
                Random rnd = new Random();
                int[] _myAraay = new int[arrayLength];
                for (int i = 0; i < _myAraay.Length; i++)
                    _myAraay[i] = rnd.Next(-10000, 10001);
                foreach (int elem in _myAraay)
                    Console.Write($"{elem} ");
                Console.WriteLine();
                return _myAraay;
            }

            public static int PairBy3(int[] array)
            {
                var ctn = 0;

                for (int i = 0; i < array.Length; i++)
                {
                    var i2 = i + 1;
                    if (i2 >= array.Length)
                        return ctn;
                    else if (array[i] % 3 == 0 || array[i2] % 3 == 0)
                        ctn++;
                }
                return ctn;
            }
        }
    }
}
