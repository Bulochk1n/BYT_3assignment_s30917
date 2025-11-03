using ConsoleApp2;

namespace TestProject2;

public class Tests
{
    
    private readonly Calculator _calculator1 = new Calculator(12, 42, '+');
    [Test]
    public void TestCalculatorAdd()
    {
        Assert.Multiple(() =>
        {
            Assert.That(_calculator1.Calculate(), Is.EqualTo(54));
            Assert.That(_calculator1.Calculate(), !Is.EqualTo(234));
        });
        
    }
    
    private readonly Calculator _calculator2 = new Calculator(12, 42, '-');
    [Test]
    public void TestCalculatorSubtract()
    {
        
        Assert.Multiple(() =>
        {
            Assert.That(_calculator2.Calculate(), Is.EqualTo(-30));
            Assert.That(_calculator2.Calculate(), !Is.EqualTo(54));
        });
    }
    
    private readonly Calculator _calculator3 = new Calculator(12, 42, '*');
    [Test]
    public void TestCalculatorMultiply()
    {
        Assert.Multiple(() =>
        {
            Assert.That(_calculator3.Calculate(), Is.EqualTo(504));
            Assert.That(_calculator3.Calculate(), !Is.EqualTo(56));
        });
    }
    
    private readonly Calculator _calculator4 = new Calculator(12, 42, '/');
    [Test]
    public void TestCalculatorDivide()
    {
        Assert.Multiple(() =>
        {
            Assert.That(_calculator4.Calculate(), Is.EqualTo(0.285).Within(0.001));
            Assert.That(_calculator4.Calculate(), !Is.EqualTo(56));
        });
    }
    
    private readonly Calculator _calculator5 = new Calculator(-12, 42, '/');
    [Test]
    public void TestCalculatorDivideSignFirst()
    {
        Assert.Multiple(() =>
        {
            Assert.That(_calculator5.Calculate(), Is.EqualTo(-0.285).Within(0.001));
            Assert.That(_calculator5.Calculate(), !Is.EqualTo(0.285).Within(0.001));
        });
    }
    
    private readonly Calculator _calculator6 = new Calculator(12, -42, '/');
    [Test]
    public void TestCalculatorDivideSignSecond()
    {
        Assert.Multiple(() =>
        {
            Assert.That(_calculator6.Calculate(), Is.EqualTo(-0.285).Within(0.001));
            Assert.That(_calculator6.Calculate(), !Is.EqualTo(0.285).Within(0.001));
        });
    }
    
    private readonly Calculator _calculator7 = new Calculator(-12, -42, '/');
    [Test]
    public void TestCalculatorDivideSignBoth()
    {
        Assert.Multiple(() =>
        {
            Assert.That(_calculator7.Calculate(), Is.EqualTo(0.285).Within(0.001));
            Assert.That(_calculator7.Calculate(), !Is.EqualTo(-0.285).Within(0.001));
        });
    }
    
    private readonly Calculator _calculator8 = new Calculator(0, -42, '/');
    [Test]
    public void TestCalculatorDivideZeroFirst()
    {
        Assert.Multiple(() =>
        {
            Assert.That(_calculator8.Calculate(), Is.EqualTo(0));
            Assert.That(_calculator8.Calculate(), !Is.EqualTo(-0.285).Within(0.001));
        });
    }
    
    
    
    
    
    
}