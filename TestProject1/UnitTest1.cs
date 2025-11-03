
namespace TestProject1;

public class Tests
{
    private readonly IShape _sphere = new Sphere(5);

    [Test]
    public void TestSphereCalculateArea()
    {
        Assert.That(_sphere.CalculateArea(), Is.EqualTo(314.159).Within(0.001));
    }

    [Test]
    public void TestSphereCalculateVolume()
    {
        Assert.That(_sphere.CalculateVolume(), Is.EqualTo(523.598).Within(0.001));
    }
    
    
    
    

    private readonly IShape _cylinder = new Cylinder(3, 7);

    [Test]
    public void TestCylinderCalculateArea()
    {
        Assert.That(_cylinder.CalculateArea(), Is.EqualTo(188.496).Within(0.001));
    }
        
    [Test]
    public void TestCylinderCalculateVolume()
    {
        Assert.That(_cylinder.CalculateVolume(), Is.EqualTo(197.920).Within(0.001));
    }
    
    
    
    
    
    private readonly IShape _rectangle = new Rectangle(4, 8);

    [Test] public void TestRectangleCalculateArea()
    {
        Assert.That(_rectangle.CalculateArea(), Is.EqualTo(32));
    }
        
    [Test]
    public void TestRectangleCalculateVolume()
    {
        Assert.That(_rectangle.CalculateVolume(), Is.EqualTo(0));
    }
    
    
    
    
    
    
    
    private readonly IShape _cube = new Cube(4);

    [Test]
    public void TestCubeCalculateArea()
    {
        Assert.That(_cube.CalculateArea(), Is.EqualTo(96));
    }
        
    [Test]
    public void TestCubeCalculateVolume()
    {
        Assert.That(_cube.CalculateVolume(), Is.EqualTo(64));
    }
    
    

}