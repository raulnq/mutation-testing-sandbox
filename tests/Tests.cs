using calculator;

namespace tests;

[TestClass]
public class Tests
{
    [TestMethod]
    [DataRow(1, 1, 1)]
    [DataRow(2, 3, 6)]
    [DataRow(7, 5, 35)]
    public void x_multiplied_by_y_should_be_z(int x, int y, int z)
    {
        var sut = new Calculator();

        var r = sut.Multiply(x, y);

        Assert.AreEqual(z, r);
    }

    [TestMethod]
    [DataRow(1, 1, 1)]
    [DataRow(10, 5, 2)]
    [DataRow(24, 3, 8)]
    public void x_divided_by_y_should_be_z(int x, int y, int z)
    {
        var sut = new Calculator();

        var r = sut.Divide(x, y);

        Assert.AreEqual(z, r);
    }


    [TestMethod]
    [DataRow(0, 0, 0)]
    [DataRow(5, 3, 8)]
    [DataRow(2, 9, 11)]
    public void x_plus_y_should_be_z(int x, int y, int z)
    {
        var sut = new Calculator();

        var r = sut.Add(x, y);

        Assert.AreEqual(z, r);
    }

    [TestMethod]
    [DataRow(0, 0, 0)]
    [DataRow(5, 1, 4)]
    [DataRow(11, 5, 6)]
    public void x_minus_y_should_be_z(int x, int y, int z)
    {
        var sut = new Calculator();

        var r = sut.Subtrac(x, y);

        Assert.AreEqual(z, r);
    }
}