int FunctAkkerman (int numberM, int numberN)
{
    if (numberM == 0) return numberN + 1;
    if (numberM != 0 && numberN == 0) return FunctAkkerman(numberM - 1, 1);
    if (numberM > 0 && numberN > 0) return FunctAkkerman(numberM - 1, FunctAkkerman(numberM, numberN - 1));
return FunctAkkerman(numberM, numberN);
}

Console.Clear();
Console.WriteLine("Введите начальное число M:");
int numberM = int.Parse(Console.ReadLine());

Console.WriteLine("Введите начальное число N:");
int numberN = int.Parse(Console.ReadLine());

Console.WriteLine($"Функция Аккермана A({numberM},{numberN}) = {FunctAkkerman(numberM, numberN)}");
