// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());
// double[] numbers = new double[size];
// InputArrayRandomNumbers(numbers);
// Console.WriteLine("Цыфры в массиве: ");
// PrintArray(numbers);
// double min = Int32.MaxValue;
// double max = Int32.MinValue;

// for (int m = 0; m < numbers.Length; m++)
// {
// if (numbers[m] > max)
// {
//     max = numbers[m];
//  }
// if (numbers[m] < min)
// {
//     min = numbers[m];
//  }
// }

// Console.WriteLine($"всего {numbers.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
// Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

// void InputArrayRandomNumbers(double[] numbers)
// {
//     for(int i = 0; i < numbers.Length; i++)
//         {
//             numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
//         }
// }
// void PrintArray(double[] numbers)
// {
//     Console.Write("[ ");
//     for(int i = 0; i < numbers.Length; i++)
//         {
//             Console.Write(numbers[i] + " ");
//         }
//     Console.Write("]");
//     Console.WriteLine();
// }

//Переделал после разбора на семинаре.

void InputArray(double[] array)
{
  for (int i = 0; i < array.Length; i++)
    array[i] = Math.Round(new Random().NextDouble() * (10 - 1) + 1, 2); // [1, 10]
    // * (end - begin) + begin
}


string DiffMaxAndMin(double[] array)
{
  double minArray = array[0], maxArray = array[0];
  foreach (double element in array)
  {
    if (element > maxArray)
      maxArray = element;
    if (element < minArray)
      minArray = element;
  }
  return $"{maxArray} - {minArray} = {maxArray - minArray}";
}


Console.Clear();
Console.Write("Введите кол-во элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Результат: {DiffMaxAndMin(array)}");