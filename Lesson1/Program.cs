/*
//Напишите программу, которая на вход принимает число и 
//выдает его квадрат (число умноженное на само себя)

 double input = double.Parse(Console.ReadLine());

 Console.WriteLine(input * input);
*/



/*
Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
a = 5; b = 25 -> да a = 2 b = 10 -> нет a = 9; b = -3 -> нет a = -3 b = 9 -> да


Console.WriteLine("введите 2 числа");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
if(a*a == b){
    Console.WriteLine("True");
}
else{
    Console.WriteLine("False");
}



Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());

if (number < 1 | number > 7)
{
    Console.WriteLine("Null");
}
if (number == 1)
{
    Console.WriteLine("Понеделъник");
}
if (number == 2)
{
    Console.WriteLine("Вторник");
}
if (number == 3)
{
    Console.WriteLine("Среда");
}
if (number == 4)
{
    Console.WriteLine("Четверг");
}
if (number == 5)
{
    Console.WriteLine("Пятница");
}
if (number == 6)
{
    Console.WriteLine("Суббота");
}
if (number == 7)
{
    Console.WriteLine("Воскресенье");
}

*/


/*
Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 2 -> " -2, -1, 0, 1, 2"



int n = int.Parse(Console.ReadLine());
int i = -n;
while (i <= n)
{
    Console.Write(i);
    Console.Write(" ");
    i = i + 1;
}

*/



/*
Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
456->6
782->2
918->8
*/

int number = int.Parse(Console.ReadLine());
if(number < 100 | number > 999){
    Console.WriteLine("wrong number");
    return;
}
double result = (double)number % 10;
Console.WriteLine(result);
