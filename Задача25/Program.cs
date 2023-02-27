//Напишите метод, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

//Math.Pow использовать нельзя

//3, 5 -> 243 (3⁵)
//2, 4 -> 16

int A = 2;
int B = 4;
int result = 1;

for (int i = 0; i < B; i++)
{
  result = result * A;
}

Console.WriteLine(result);