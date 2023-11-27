// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
System.Console.Write("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberB*numberB == numberA)
{
    System.Console.WriteLine("Первое число является квадратом второго");
}
else
{
    System.Console.WriteLine("Первое число не является квадратом второго");
}