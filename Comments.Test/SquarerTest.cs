namespace Comments.Test;

using NUnit.Framework;

[TestFixture]
public class SquarerTest
{
    [Test]
    public void SumOfSquaresGivesExpectedResultTest()
    {
        int a = 7;
        int b = 12;

        int expected = 0;
        for (int i = a; i <= b; i++)
        {
            expected += i * i;
        }

        int actual = Squarer.SumOfSquares(a, b);

        Assert.That(actual, Is.EqualTo(expected));
    }
}