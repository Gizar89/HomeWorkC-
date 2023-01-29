Console.WriteLine( "Введите число указывающее на размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[n];
InputArrayRandomNumbers(numbers);
Console.WriteLine("Цыфры в массиве: ");
PrintArray(numbers);
int sum = 0;

for(int m = 0; m < numbers.Length; m+=2)
sum = sum + numbers[m];
Console.WriteLine($"всего {numbers.Length} чисел, сумма элементов на нечётных позициях = {sum}");
void InputArrayRandomNumbers(int[] numbers)
{
for(int i = 0; i < numbers.Length; i++)
{
numbers[i] = new Random().Next(1,10);
}
}
void PrintArray(int[] numbers)
{
Console.Write("[ ");
for(int i = 0; i < numbers.Length; i++)
{
Console.Write(numbers[i] + " ");
}
Console.Write("]");
Console.WriteLine();
}