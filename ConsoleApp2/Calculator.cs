namespace ConsoleApp2;

public class Calculator
{
    private double _a { get; }
    private double _b { get; }
    private char _c { get; }

    public Calculator(double a, double b, char c)
    {
        if ("+-*/".IndexOf(c) == -1) throw new ArgumentException("Invalid operation");
        if (c == '/' && b == 0) throw new ArgumentException("You cannot divide by 0");
        
        _a = a; _b = b; _c = c;
    }

    public double Calculate()
    {
        switch (_c)
        {
            case '+': return _a + _b; break;
            case '-': return _a - _b; break;
            case '*': return _a * _b; break;
            case '/': return _a / _b; break;
            default: throw new ArgumentException("Invalid operation");
        }
        
    }
    
}