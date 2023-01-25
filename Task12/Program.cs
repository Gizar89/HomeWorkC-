Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while(n > 0)
{
    int num = n % 10;
    n=n / 10;
    sum = sum + num;
}
Console.WriteLine($"Сумма чисел в числе: {sum}");