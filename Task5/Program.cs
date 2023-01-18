Console.Clear();
int n = new Random().Next(100, 1000);
Console.WriteLine( $"Случайное число: {n}");

int n2 = (n%100)/10;
Console.WriteLine(n2);