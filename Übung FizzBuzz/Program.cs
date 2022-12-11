int i = 1;
int upperBounds = int.Parse(Console.ReadLine()!);
int lowerBounds = int.Parse(Console.ReadLine()!);

while (i <= lowerBounds && i != upperBounds)
{
    if (i % 3 == 0 && i % 5 != 0) { Console.Write(" Fizz, "); }
    else if (i % 5 == 0 && i % 3 != 0) { Console.Write(" Buzz, "); }
    else if (i % 3 == 0 && i % 5 == 0) { Console.Write(" FizzBuzz, "); }
    else { Console.Write(" " + i + " "); }
    i++;
}