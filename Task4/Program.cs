Console.WriteLine("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите число: ");
int number2 = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите число: ");
int number3 = Convert.ToInt32(Console.ReadLine()); 

if (number1 > number2 && number1 > number3)
   Console.WriteLine("Первое число больше остальных чисел"); 
else
if (number2 > number1 && number2 > number3)
   Console.WriteLine("Второе число больше остальных чисел"); 
else
if (number3 > number1 && number3 > number2)
Console.WriteLine("Третье число больше остальных чисел"); 
else


