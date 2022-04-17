// Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным.

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Clear();
Console.Write("Введите число: ");
double a = Convert.ToDouble(Console.ReadLine());
if (a%2==0)
{
      Console.WriteLine("Да");
}

else
{
      Console.WriteLine("Нет");
}