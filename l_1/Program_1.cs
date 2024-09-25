using System;

namespace lab_1_1
{
    internal class Program_1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("min and max values of predefined CTS data types: ");

            // целочисленные типы данных
            Console.WriteLine($"byte: min = {byte.MinValue}, max = {byte.MaxValue}");
            Console.WriteLine($"sbyte: min = {sbyte.MinValue}, max = {sbyte.MaxValue}");
            Console.WriteLine($"short: min = {short.MinValue}, max = {short.MaxValue}");
            Console.WriteLine($"ushort: min = {ushort.MinValue}, max = {ushort.MaxValue}");
            Console.WriteLine($"int: min = {int.MinValue}, max = {int.MaxValue}");
            Console.WriteLine($"uint: min = {uint.MinValue}, max = {uint.MaxValue}");
            Console.WriteLine($"long: min = {long.MinValue}, max = {long.MaxValue}");
            Console.WriteLine($"ulong: min = {ulong.MinValue}, max = {ulong.MaxValue}");

            // вещественные типы данных
            Console.WriteLine($"float: min = {float.MinValue}, max = {float.MaxValue}");
            Console.WriteLine($"double: min = {double.MinValue}, max = {double.MaxValue}");
            Console.WriteLine($"decimal: min = {decimal.MinValue}, max = {decimal.MaxValue}");

            // логический тип данных
            Console.WriteLine($"bool: min = false, max = true");

            // символьный тип данных
            Console.WriteLine($"char: min = {char.MinValue}, max = {char.MaxValue}");

            // структуры
            Console.WriteLine($"DateTime: min = {DateTime.MinValue}, max = {DateTime.MaxValue}");
            Console.WriteLine($"TimeSpan: min = {TimeSpan.MinValue}, max = {TimeSpan.MaxValue}");

            Console.ReadKey(); // ожидание ввода пользователем в консоль
        }
    }
}
