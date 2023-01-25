Console.Clear();
Console.Write("Введите число А: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число В: ");
int B = Convert.ToInt32(Console.ReadLine());
int result = A;
for(int i = 1; i<B; i++)
{
    result = result * A;
}
Console.WriteLine($"А в степени В: {result}");




