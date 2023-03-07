//Task 1.

Console.Write("Hello, friend. Enter first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Hello, friend. Enter second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2) Console.WriteLine(num1 + " is greater than " + num2);
else
{
    if (num1 < num2) Console.WriteLine(num2 + " is greater than " + num1);
    else Console.WriteLine("They are equal!");
}