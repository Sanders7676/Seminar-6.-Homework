//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


//К1 не должно быть равно К2. Если они равны, то прямые параллельны.

// x = (b2 - b1) / (k1 - k2)



Console.WriteLine();

Console.WriteLine("У нас есть две функции: y = k1 * x + b1 и y = k2 * x + b2");

Console.WriteLine("Найдем точку пересечения прямых, заданных указанными функциями.");

Console.WriteLine();

Console.WriteLine("Ведите необходимые параметры для функции y = k1 * x + b1:");

Console.Write("Введите значение k1: ");

double numberK1 = InputInt();

Console.Write("Введите значение B1: ");

double numberB1 = InputInt();

Console.WriteLine();

Console.WriteLine("Ведите необходимые параметры для функции y = k2 * x + b2;:");

Console.Write("Введите значение k2: ");

double numberK2 = InputInt();

Console.Write("Введите значение B2: ");

double numberB2 = InputInt();

double[] pointOfIntersectionOfLines = FindCoordinatesOfPointOfIntersectionOfLlines(numberK1, numberB1, numberK2, numberB2);

try
{
    double[] arr = FindCoordinatesOfPointOfIntersectionOfLlines(numberK1, numberB1, numberK2, numberB2);
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
    return;
}

Console.WriteLine();

Console.Write("Прямые пересекаются в точке c координатами: ");

PrintArray(pointOfIntersectionOfLines);

Console.WriteLine();



// Метод нахождения точки пересечения прямых

double[] FindCoordinatesOfPointOfIntersectionOfLlines(double numberK1, double numberB1, double numberK2, double numberB2)
{
    if (numberK1 != numberK2)
    {
        double coordinateX = Math.Round(((numberB2 - numberB1) / (numberK1 - numberK2)), 1);

        double coordinateY = Math.Round((((numberK1 * coordinateX) + numberB1)), 1);

        double[] array = new double[2];

        array[0] = coordinateX;

        array[1] = coordinateY;
        
        return array;
    }
    else
    {
        throw new Exception("Прямые параллельны. Точка пересечения отсутствует");
    }
}


// Метод для приема чисел, вводимых через консоль

double InputInt()
{
    bool isNum = double.TryParse(Console.ReadLine(), out double num);
    if (isNum)
    {
        return num;
    }
    else
    {
        Console.WriteLine("Введено некорректное значение.");
        return -1;         
    }
}



//Метод печати массива

void PrintArray(double[] array)
{
    Console.WriteLine($"({string.Join(" ; ", array)})");
}