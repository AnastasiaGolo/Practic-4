//Напишите метод, который задаёт массив из N элементов и выводит их на экран.
//
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

int lenArray = ReadInt("Введите числа через запятую: ");
int ReadInt(string message)
{
   Console.Write(message);
   return Convert.ToInt32(Console.ReadLine());
}

int RandomArray( int Lenght, int minValue, int maxValue)
{
    int[] array = new int[Lenght];
    Random random = new Random();
    for (int i = 0; i < Lenght; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < Lenght; i++)
    {
        System.Console.Write($"{array[i]}, ");
    }
    System.Console.Write($"{array[array.Length - 1]}");
    System.Console.Write("]");
}

int[] array = RandomArray(Lenght, min, max);
PrintArray(array);