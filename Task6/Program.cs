// Console.Clear();
// Console.Write("Введите любое число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// if (n<99){
//    Console.WriteLine("третьей цифры нет");
// }
// if (n>9999){
//     Console.WriteLine((n%1000)/10/10);
// }

// if(n>1000 && n<9999){
//     Console.WriteLine((n%100)/10);

// }    
// if (n>100 && n<1000){
    
//     Console.WriteLine((n%100)%10);
// }
// сам решал

// рещение на семинаре

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n<100)
  Console.WriteLine(" Третьей цифры нет");
else 
{
    while(n>=1000)
    n=n/10;
}  
Console.WriteLine(n);
Console.WriteLine(n%10);
    

    




