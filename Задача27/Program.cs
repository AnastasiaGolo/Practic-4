//Напишите метод, который принимает на вход число и выдаёт сумму цифр в числе.
//
//452 -> 11
//82 -> 10
//9012 -> 12

int number = ReadInt("Введите число: ");


int ReadInt(string message)
{
   Console.Write(message);
   return Convert.ToInt32(Console.ReadLine());
}

int SummAllDigit(int number)
{
   int result = 0;
   while (number > 0)
   {
      result += number% 10;
      number = number / 10;
   }
   return result;
}

System.Console.WriteLine($"Сумма чисел в цифре {number} = {SummAllDigit(number)}");