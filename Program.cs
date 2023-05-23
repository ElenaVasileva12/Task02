
int number1=Convert.ToInt32(Console.ReadLine());
int number2=Convert.ToInt32(Console.ReadLine());
int max=number1;

if (number2>max)
{
    Console.WriteLine($"max = {number2}, min = {number1}");
}
else
{
    Console.WriteLine($"max ={number1}, min = {number2}");
}