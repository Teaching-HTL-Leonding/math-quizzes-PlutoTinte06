Console.WriteLine("Type in a positive number: ");
int number_begin = int.Parse(Console.ReadLine()!);
int number_reverse = 0;
int number = number_begin;

while (number > 0)
{
    int rest = number % 10;
    number = number / 10;
    number_reverse = (number_reverse * 10) + rest;
}

if (number_reverse == number_begin) {Console.WriteLine("The number is a palindrome");}
else if (number_reverse != number_begin) {Console.WriteLine("The number is not a palindrome");}