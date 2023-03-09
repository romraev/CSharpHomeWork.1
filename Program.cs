// Выполнил Раевский Р.Ю.
//Task 2.

// Console.Write("Hello, friend. Enter first number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Hello, friend. Enter second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if (num1 > num2) Console.WriteLine(num1 + " is greater than " + num2);
// else
// {
//     if (num1 < num2) Console.WriteLine(num2 + " is greater than " + num1);
//     else Console.WriteLine("They are equal!");
// }

// Task 4.

// Console.Write("Hello, friend. Enter first number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Enter second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Enter third number: ");
// int num3 = Convert.ToInt32(Console.ReadLine());

// if (num1 > num2) 
// {
//     if (num1 > num3) Console.Write("The maximum number is " + num1);
//     else Console.Write("The maximum number is " + num3);
// }
// else
// {
//     if (num2 > num3) Console.Write("The maximum number is " + num2);
//     else Console.Write("The maximum number is " + num3);
// }

// Task 6.

// Console.Write("Hello, friend. Enter your number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num % 2 == 1) Console.Write("Your number is odd");
// else Console.Write("Your number is even");

// Task 8.
Console.Write("Hello, friend. Enter your number: ");
int num = Convert.ToInt32(Console.ReadLine());

int count = 1;

while (2 * count <= num)
{
    Console.Write(2 * count + " ");
    count++;
}   