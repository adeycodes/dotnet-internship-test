// TASK 1
/*
Declare and initialize the following variables:
A string variable named name with the value "John Doe"
An integer variable named age with the value 25
A boolean variable named isAdmin with the value true
Print the values of these variables to the console.
*/
string name = "John Doe";
int age = 25;
bool isAdmin = true;
Console.WriteLine(name);
Console.WriteLine(age);
Console.WriteLine(isAdmin);

// TASK 2
/*
Write a program that takes an integer input from the user and prints out whether the number is even or odd.
Use an if-else statement to determine whether the number is even or odd.
Print "Even" if the number is even, and "Odd" if the number is odd.
*/

// ask the user for an integer input
Console.Write("Please enter an integer: ");
string? input = Console.ReadLine();

// TryParse so the program doesn't crash if the user types something that isn't a number
if (int.TryParse(input, out int userInput))
{
    // a number is even if dividing by 2 leaves no remainder
    if (userInput % 2 == 0) // check if the number is even
    {
        Console.WriteLine("Even");
    }
    else // if the number is not even, it must be odd
    {
        Console.WriteLine("Odd");
    }
}
else
{
    Console.WriteLine("That is not a valid integer.");
}

// TASK 3
/*
Write a program that prints out the numbers 1 to 10 using a for loop.
*/
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}

// TASK 4
/*
Declare and initialize an integer array with the values 2, 4, 6, 8, 10.
Print the sum of all elements in the array to the console.
Use a foreach loop to iterate over the array and print each element to the console.
*/
int[] numbers = { 2, 4, 6, 8, 10 };
int sum = 0;

foreach (int number in numbers)
{
    Console.WriteLine(number);
    sum += number;
}

Console.WriteLine("Sum: " + sum);

// TASK 5
/*
Write a method named Greet that takes a string parameter name and prints out a personalized greeting message.
The method should print "Hello, <name>!" to the console.
Call the Greet method with the argument "Alice".
*/
Greet("Alice");


static void Greet(string name)
{
    Console.WriteLine("Hello, " + name + "!");
}