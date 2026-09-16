namespace Comments.Test;

using NUnit.Framework;

[TestFixture]
public class X1Test
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

        int actual = X1.SumOfSquares(a, b);

        Assert.That(actual, Is.EqualTo(expected));
    }
}