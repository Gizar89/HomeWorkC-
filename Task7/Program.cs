Console.Clear();
Console.Write("Введите цыфру дня недели (1-7): ");
int n = Convert.ToInt32(Console.ReadLine());
if (n == 1)
Console.WriteLine("Это рабочий день - Понедельник");
if (n == 2)
Console.WriteLine("Это рабочий день - Вторник");
if (n == 3)
Console.WriteLine("Это рабочий день - Среда");
if (n == 4)
Console.WriteLine("Это рабочий день - Четверг");
if (n == 5)
Console.WriteLine("Это рабочий день - Пятница(короткий день)");
if (n==6)
Console.WriteLine("Это выходной - Суббота");
if (n == 7)
 Console.WriteLine("Это выходной - Воскресенье");
else if (n>7)
  Console.WriteLine( "В неделе только 7 дней");

