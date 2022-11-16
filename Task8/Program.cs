Console.WriteLine("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine()); 
int number2 = 0;

while (number2 <= number1) 
{
   Console.Write(number2 + ", ");
   number2 ++; 
if (number2 % 2 == 0)
{
   Console.Write(number2); 
}

}
   
