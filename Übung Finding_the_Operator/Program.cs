Console.Clear();

Console.WriteLine("Type in the first operand");
double operand1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Type in the second operand");
double operand2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Type in the result of the operands");
double result = double.Parse(Console.ReadLine()!);
string Operator = "0";

if (operand1 + operand2 == result) { Operator = "+"; }
else if (operand1 - operand2 == result) { Operator = "-"; }
else if (operand2 - operand1 == result) { Operator = "-"; }
else if (operand1 * operand2 == result) { Operator = "*"; }
else if (operand1 / operand2 == result) { Operator = "/"; }
else if (operand2 / operand1 == result) { Operator = "/"; }

Console.Write($"The operator used is {Operator}");