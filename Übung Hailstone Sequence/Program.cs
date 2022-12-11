Console.WriteLine("Type in the starting value");
int n = int.Parse(Console.ReadLine()!);
while (n != 1)
{
    if (n % 2 == 0) { n = n / 2; Console.Write(" " + n + " "); }
    else { n = (3 * n) + 1; Console.Write(" " + n + " "); }
}