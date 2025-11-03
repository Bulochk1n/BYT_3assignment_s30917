
using ConsoleApp2;

Calculator calculator1 = new Calculator(10, 2, '+');
Console.WriteLine($"Result1 : {calculator1.Calculate():F2}");

Calculator calculator2 = new Calculator(10, 2, '-');
Console.WriteLine($"Result2 : {calculator2.Calculate():F2}");

Calculator calculator3 = new Calculator(10, 2, '*');
Console.WriteLine($"Result3 : {calculator3.Calculate():F2}");

Calculator calculator4 = new Calculator(10, 2, '/');
Console.WriteLine($"Result4 : {calculator4.Calculate():F2}");

try
{
    Calculator calculator5 = new Calculator(10, 2, 'a');
    Console.WriteLine($"Result5 : {calculator5.Calculate():F2}");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

try
{
    Calculator calculator6 = new Calculator(10, 0, '/');
    Console.WriteLine($"Result6 : {calculator6.Calculate():F2}");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

