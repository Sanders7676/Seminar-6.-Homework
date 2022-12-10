// Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3




Console.Write("Ведите количество рассматриваемых чисел: ");

int arrayLength = InputInt();

int[] arr = new int[arrayLength];

int[] array = FillArray(arr);

Console.WriteLine("Введены следующие числа:");

PrintArray(array);

int quantityOfNumbersGreaterThanZero = GetQuantityOfNumbersGreaterThanZero(array);

Console.WriteLine($"Среди введенных чисел {quantityOfNumbersGreaterThanZero} имеют значение больше нуля.");


// Метод для приема чисел, вводимых через консоль

int InputInt()
{
    bool isNum = int.TryParse(Console.ReadLine(), out int num);
    
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


//метод заполнения массива числами, вводимыми через консоль

int[] FillArray(int[] arr)
{
    Console.WriteLine("Теперь введите числа:");

    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Введите {i + 1}-e числo: ");
        int num = int.Parse(Console.ReadLine());
        arr[i] = num;
    }
    return arr;
}

// Метод подсчета количества элементов массива значение которых больше нуля


int GetQuantityOfNumbersGreaterThanZero(int[] array)
{
    int quantity = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            quantity++;
        }
    }
    return quantity;
}


//Метод печати массива

void PrintArray(int[] array)
{
    Console.WriteLine($"{string.Join(", ", array)}");
}
