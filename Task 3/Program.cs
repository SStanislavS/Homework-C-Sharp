// Программа на входе принимает число и выдает, является ли число четным (делиться ли оно на два без остатка)
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
{
    Console.WriteLine("Число " + num + " является Четным ");
}
else
{
    Console.WriteLine("Число " + num + " является Нечетным ");
}