using C__lab2;

internal class Program
{
    static void Main(string[] args)
    {
        //// --- Задание 1.1 и 4.1: Точка координат ---
        //Console.WriteLine("\n--- Задание 1.1 и 4.1: Создаем Точку ---");
        //Point p1_1 = new Point(3, 5);
        //Point p1_2 = new Point(25, 6);
        //Point p1_3 = new Point(7, 8);
        //Console.WriteLine($"Точка 1: {p1_1}");
        //Console.WriteLine($"Точка 2: {p1_2}");
        //Console.WriteLine($"Точка 3: {p1_3}");

        //// --- Задание 2.1 и 4.2: Прямая ---
        //Console.WriteLine("\n--- Задание 2.1 и 4.2: Создаем Линию ---");
        //Line line1 = new Line(1, 3, 23, 8);
        //Line line2 = new Line(new Point(5, 10), new Point(25, 10));
        //Line line3 = new Line(line1.Start, line2.End);
        //Console.WriteLine($"1. Исходная Линия 1: {line1}");
        //Console.WriteLine($"2. Исходная Линия 2: {line2}");
        //Console.WriteLine($"3. Исходная Линия 3 (начало от Л1, конец от Л2): {line3}");

        //Console.WriteLine("\n4. Изменяем координаты начала Линии 1...");
        //line1.Start.X = 100;
        //line1.Start.Y = 200;
        //Console.WriteLine($"   Новая Линия 1: {line1}");
        //Console.WriteLine($"   Линия 3 изменилась, т.к. ее начало ссылается на тот же объект Point: {line3}");

        //Console.WriteLine("\n5. Заменяем объект начала Линии 1 на новый...");
        //line1.Start = new Point(0, 0);
        //Console.WriteLine($"   Новая Линия 1: {line1}");
        //Console.WriteLine($"   Линия 3 НЕ изменилась, т.к. ее ссылка осталась на старый объект: {line3}");


        //// --- Задание 3.1: Студент ---
        //Console.WriteLine("\n--- Задание 3.1: Студент ---");
        //Student vasya = new Student("Вася", new int[] { 3, 4, 5 });
        //Console.WriteLine($"1. Создан {vasya}");

        //Student petya = new Student("Петя", vasya.Grades);
        //Console.WriteLine($"2. Создан {petya}, оценки скопированы от Васи (по ссылке)");

        //Console.WriteLine("\n3. Заменяем первую оценку Пети на 5...");
        //petya.Grades[0] = 5;
        //Console.WriteLine($"   Теперь {petya}");
        //Console.WriteLine($"   Оценки Васи тоже изменились: {vasya}");
        //Console.WriteLine("   (Объяснение: Массив - ссылочный тип. Оба студента ссылаются на один и тот же массив в памяти)");

        //int[] vasyaGradesCopy = new int[vasya.Grades.Length];
        //vasya.Grades.CopyTo(vasyaGradesCopy, 0);
        //Student andrey = new Student("Андрей", vasyaGradesCopy);
        //Console.WriteLine($"\n4. Создан {andrey} с настоящей копией оценок Васи.");
        //Console.WriteLine("   Меняем первую оценку Васи обратно на 3...");
        //vasya.Grades[0] = 3;
        //Console.WriteLine($"   Теперь {vasya}");
        //Console.WriteLine($"   Оценки Андрея не изменились: {andrey}");


        //// --- Задание 5.3: Длина Линии ---
        //Console.WriteLine("\n--- Задание 5.3: Длина Линии ---");
        //Line lengthLine = new Line(1, 1, 10, 15);
        //Console.WriteLine($"Создана линия: {lengthLine}");
        //Console.WriteLine($"Её длина: {lengthLine.Length}");

        //Console.WriteLine("\nНажмите любую клавишу для выхода...");
        //Console.ReadKey();
        // --- Задание 1.1 и 4.1: Точка координат ---
        Console.WriteLine("\n--- Задание 1.1 и 4.1: Создаем Точку ---");
        Point p1_1 = new Point(3, 5);
        Point p1_2 = new Point(25, 6);
        Point p1_3 = new Point(7, 8);
        Console.WriteLine($"Точка 1: {p1_1}");
        Console.WriteLine($"Точка 2: {p1_2}");
        Console.WriteLine($"Точка 3: {p1_3}");

        // --- Задание 2.1 и 4.2: Прямая ---
        Console.WriteLine("\n--- Задание 2.1 и 4.2: Создаем Линию ---");
        Line line1 = new Line(1, 3, 23, 8);
        Line line2 = new Line(new Point(5, 10), new Point(25, 10));
        Line line3 = new Line(line1.Start, line2.End);
        Console.WriteLine($"1. Исходная Линия 1: {line1}");
        Console.WriteLine($"2. Исходная Линия 2: {line2}");
        Console.WriteLine($"3. Исходная Линия 3 (начало от Л1, конец от Л2): {line3}");

        Console.WriteLine("\n4. Изменяем координаты начала Линии 1...");
        line1.Start.X = 100;
        line1.Start.Y = 200;
        Console.WriteLine($"   Новая Линия 1: {line1}");
        Console.WriteLine($"   Линия 3 изменилась, т.к. ее начало ссылается на тот же объект Point: {line3}");

        Console.WriteLine("\n5. Заменяем объект начала Линии 1 на новый...");
        line1.Start = new Point(0, 0);
        Console.WriteLine($"   Новая Линия 1: {line1}");
        Console.WriteLine($"   Линия 3 НЕ изменилась, т.к. ее ссылка осталась на старый объект: {line3}");


        // --- Задание 3.1: Студент ---
        Console.WriteLine("\n--- Задание 3.1: Студент ---");
        Student vasya = new Student("Вася", new int[] { 3, 4, 5 });
        Console.WriteLine($"1. Создан {vasya}");

        Student petya = new Student("Петя", vasya.Grades);
        Console.WriteLine($"2. Создан {petya}, оценки скопированы от Васи (по ссылке)");

        Console.WriteLine("\n3. Заменяем первую оценку Пети на 5...");
        petya.Grades[0] = 5;
        Console.WriteLine($"   Теперь {petya}");
        Console.WriteLine($"   Оценки Васи тоже изменились: {vasya}");
        Console.WriteLine("   (Объяснение: Массив - ссылочный тип. Оба студента ссылаются на один и тот же массив в памяти)");

        int[] vasyaGradesCopy = new int[vasya.Grades.Length];
        vasya.Grades.CopyTo(vasyaGradesCopy, 0);
        Student andrey = new Student("Андрей", vasyaGradesCopy);
        Console.WriteLine($"\n4. Создан {andrey} с настоящей копией оценок Васи.");
        Console.WriteLine("   Меняем первую оценку Васи обратно на 3...");
        vasya.Grades[0] = 3;
        Console.WriteLine($"   Теперь {vasya}");
        Console.WriteLine($"   Оценки Андрея не изменились: {andrey}");


        // --- Задание 5.3: Длина Линии ---
        Console.WriteLine("\n--- Задание 5.3: Длина Линии ---");
        Line lengthLine = new Line(1, 1, 10, 15);
        Console.WriteLine($"Создана линия: {lengthLine}");
        Console.WriteLine($"Её длина: {lengthLine.Length}");

        Console.WriteLine("\nНажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}