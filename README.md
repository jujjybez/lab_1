# Лабораторная работа 1
# Цели работы
1. Научиться работать с переменными разных типов данных CTS средствами
языка C#.
2. Научиться создавать классы и поля классов, инициализировать свойства
классов. Научиться создавать перегруженные конструкторы классов.
3. Научиться создавать тесты для реализованных методов и классов.

# Задание 1
Выведите на консоль минимальные и максимальные значения для
предопределенных типов данных CTS.

Код задания 1:
```
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
```

Вывод консоли:
![image](https://github.com/user-attachments/assets/361fe120-e46e-4e67-a5d7-faed554bf8c7)


# Задание 2
Создайте класс с именем Rectangle.
В теле класса создайте два поля, описывающие длины сторон double sideA, sideB.
Создайте пользовательский конструктор Rectangle(double sideA, double sideB), в
теле которого поля sideA и sideB инициализируются значениями аргументов.
Создайте два private метода, вычисляющие площадь прямоугольника - double
CalculateArea() и периметр прямоугольника - double CalculatePerimeter ().
Создайте два свойства double Area и double Perimeter с одним методом доступа
get, вызывающим созданные ранее методы.
Напишите программу, которая принимает от пользователя длины двух сторон
прямоугольника и выводит на экран периметр и площадь. Покройте тестами
методы класса Rectangle.

Код задания 2:
```
using System;
using System.Diagnostics;

namespace lab_1_2
{
    public class Rectangle
    {
        private double side_1;
        private double side_2;

        public Rectangle(double side_A, double side_B)
        {
            side_1 = side_A;
            side_2 = side_B;
        }

        private double CalculateArea()
        {
            return side_1 * side_2;
        }

        private double CalculatePerimeter()
        {
            return 2 * (side_1 + side_2);
        }

        public double Area
        {
            get { return CalculateArea(); }
        }

        public double Perimeter
        {
            get { return CalculatePerimeter(); }
        }
    }
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter rectangle side 1: ");
            double side_A = double.Parse(Console.ReadLine());           // parse - конвертация из строки в double
            Console.WriteLine("Enter rectangle side 2: ");
            double side_B = double.Parse(Console.ReadLine());

            Rectangle rectangle = new Rectangle(side_A, side_B);

            Console.WriteLine($"Rectangle area: {rectangle.Area}");
            Console.WriteLine($"Rectangle perimeter: {rectangle.Perimeter}");

            Console.ReadKey();
        }
    }
}
```

Вывод консоли:
![image](https://github.com/user-attachments/assets/e89e9ebf-70a7-4c85-9bc5-2c32e5fee969)

# Тесты для задания 2
Код тестов:
```
using System.Diagnostics;
using System.Drawing;
using lab_1_2;

namespace test_2
{
    [TestClass]
    public class RectangleTest
    {
        [TestMethod]
        public void TestArea()
        {
            double sideA = 3.2;
            double sideB = 4.2;
            lab_1_2.Rectangle rec = new lab_1_2.Rectangle(sideA, sideB);

            double area = rec.Area;
            Assert.AreEqual(13.44, area, 0.01, "Area calculation is incorrect.");
        }
        [TestMethod]
        public void TestPerimeter()
        {
            double sideA = 3.2;
            double sideB = 4.2;
            lab_1_2.Rectangle rec = new lab_1_2.Rectangle(sideA, sideB);

            double perimeter = rec.Perimeter;

            Assert.AreEqual(14.8, perimeter, 0.01, "Perimeter calculation is incorrect.");
        }
    }
}
```

Выполнение тестов:
![image](https://github.com/user-attachments/assets/07ece572-00a9-4d8d-8733-26641c881455)


# Задание 3
Создайте классы Point и Figure.
Класс Point должен содержать два целочисленных поля с координатами точки.
Создайте два свойства с одним методом доступа get.
Создайте пользовательский конструктор, в теле которого проинициализируйте
поля значениями аргументов.
Класс Figure должен содержать конструкторы, которые принимают от 3-х до 5-ти
аргументов типа Point, а также строковое автосвойство для хранения названия
фигуры. Используйте ключевое слово this для вызова перегруженных
конструкторов, избегайте дублирования кода.
Создайте два метода: double LengthSide(Point A, Point B), который рассчитывает
длину стороны многоугольника; double PerimeterCalculator(), который
рассчитывает периметр многоугольника.
Напишите программу, которая выводит на экран название и периметр
многоугольника. Покройте тестами методы класса Figure.

Код задания 3:
```
using System.Diagnostics;
using System;

namespace lab_1_3
{
    public class Point
    {
        private int x;
        private int y;

        public int X
        {
            get { return x; }
        }

        public int Y
        {
            get { return y; }
        }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    public class Figure
    {
        private Point[] points;
        private string name;

        public Figure(Point p1, Point p2)
        {
            points = new Point[2];
            points[0] = p1;
            points[1] = p2;
        }
        public Figure(Point p1, Point p2, Point p3)
        {
            points = new Point[3];
            points[0] = p1;
            points[1] = p2;
            points[2] = p3;
        }
        public Figure(Point p1, Point p2, Point p3, Point p4)
        {
            points = new Point[4];
            points[0] = p1;
            points[1] = p2;
            points[2] = p3;
            points[3] = p4;
        }
        public Figure(Point p1, Point p2, Point p3, Point p4, Point p5)
        {
            points = new Point[5];
            points[0] = p1;
            points[1] = p2;
            points[2] = p3;
            points[3] = p4;
            points[4] = p5;
        }
        private Figure(Point[] points, string name)
        {
            this.points = points;
            this.name = name;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double LengthSide(Point A, Point B)
        {
            int dx = A.X - B.X;
            int dy = A.Y - B.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }

        public double PerimeterCalculator()
        {
            double perimeter = 0;
            for (int i = 0; i < points.Length - 1; i++)
            {
                perimeter += LengthSide(points[i], points[i + 1]);
            }

            if (points.Length > 2)
            {
                perimeter += LengthSide(points[points.Length - 1], points[0]);
            }

            return perimeter;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(0, 0);
            Point p2 = new Point(0, 5);
            Point p3 = new Point(5, 5);
            Point p4 = new Point(5, 0);

            Figure rectangle = new Figure(p1, p2, p3, p4);
            rectangle.Name = "Rectangle";
            double perimeter = rectangle.PerimeterCalculator();
            Console.WriteLine(rectangle.Name);
            Console.WriteLine(perimeter);
        }
    }
}
```

Вывод консоли:
![image](https://github.com/user-attachments/assets/532e6bf2-c911-43db-bf93-2301ac73b402)

# Тесты для задания 3
Код тестов:
```
using System.Diagnostics;
using System.Drawing;
using lab_1_3;

namespace test_3
{
    [TestClass]
    public class TestFigure
    {
        [TestMethod]
        public void TestLenghtSide()
        {
            var pA = new lab_1_3.Point(1, 1);
            var pB = new lab_1_3.Point(4, 5);
            var figure = new Figure(pA, pB);

            double lenght = figure.LengthSide(pA, pB);

            Assert.AreEqual(5.0, lenght, "Lenght is incorrect.");
        }

        [TestMethod]
        public void TestTrianglePerimeter()
        {
            var p1 = new lab_1_3.Point(0, 0);
            var p2 = new lab_1_3.Point(4, 0);
            var p3 = new lab_1_3.Point(4, 3);
            var figure = new Figure(p1, p2, p3);

            double perimeter = figure.PerimeterCalculator();

            Assert.AreEqual(12.0, perimeter, "Perimeter is incorrect.");
        }

        [TestMethod]
        public void TestRectanglePerimeter()
        {
            var p1 = new lab_1_3.Point(0, 0);
            var p2 = new lab_1_3.Point(4, 0);
            var p3 = new lab_1_3.Point(4, 3);
            var p4 = new lab_1_3.Point(0, 3);
            var figure = new Figure(p1, p2, p3, p4);

            double perimeter = figure.PerimeterCalculator();

            Assert.AreEqual(14.0, perimeter, "Perimeter is incorrect.");
        }

        [TestMethod]
        public void TestPentagonPerimeter()
        {
            var p1 = new lab_1_3.Point(0, 0);
            var p2 = new lab_1_3.Point(4, 0);
            var p3 = new lab_1_3.Point(4, 3);
            var p4 = new lab_1_3.Point(2, 5);
            var p5 = new lab_1_3.Point(0, 3);
            var figure = new Figure(p1, p2, p3, p4, p5);

            double perimeter = figure.PerimeterCalculator();

            Assert.AreEqual(15.66, perimeter, 0.01, "Perimeter is incorrect.");
        }
    }
}
```

Выполнение тестов:
![image](https://github.com/user-attachments/assets/73462d10-25a0-4562-830a-3b729da184f2)

# Вывод
В ходе выполнения лабораторной работы получилось изучить работу с переменными разных типов данных CTS средствами языка C#, научится создавать классы и поля классов, инициализировать свойства
классов, создавать перегруженные конструкторы классов, создавать тесты для реализованных методов и классов.
