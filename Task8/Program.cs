Console.Clear();
Console.Write("Введите 5 значное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int num1, num2, num3, num4;
num1 = num/10000;
Console.Write(num1);
num2 = (num/1000)%10;
Console.Write(num2);
num3 = (num%100)/10;
Console.Write(num3);
num4 = (num%100)%10;
Console.Write(num4);


if(num1 == num4 && num2 == num3 )
{
 Console.WriteLine (" это палиндром");  
}
else 
{
  Console.WriteLine (" это не палиндром");
}




 



