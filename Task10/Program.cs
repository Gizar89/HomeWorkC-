﻿Console.Clear();
Console.Write("Введите чиcло: ");
int n = Convert.ToInt32(Console.ReadLine());
for( int i = 1; i<=n; i++ )
 Console.WriteLine($" {Math.Pow (i, 3)}");