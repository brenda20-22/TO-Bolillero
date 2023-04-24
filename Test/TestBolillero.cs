namespace Test;

[TestClass]
public class TestBolillero
{
    public Bolillero bolillero { get; set; }
    public TestBolillero  => Bolillero = new bolillero();

    [Fact]
    public void Constructor()
    {
        bolillero
        Assert.Equal();
    }
}