namespace TDD;

public class Tests
{
    private Calculator _calculator = new();

    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void first_1_second_2_add_should_return_3()
    {
        ResultShouldBe(1, 2, 3);
    }

    private void ResultShouldBe(int first, int second, int expected)
    {
        Assert.AreEqual(expected, _calculator.Add(first, second));
    }
}