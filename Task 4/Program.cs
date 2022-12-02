// Программа на входе принимает число (N), а на выходе показывает все четные числа от 1 до N.
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

for (int i = 2; i <= n; i +=2)
{
    Console.Write("{0} ", i);
    Console.WriteLine();
}
