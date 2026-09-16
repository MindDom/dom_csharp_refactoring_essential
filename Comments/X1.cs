namespace Comments;

public class X1
{
    public static int SumOfSquares(int lowerBound, int upperBound)
    {
        int squareSum = 0;

        for (int i = lowerBound; i <= upperBound; i++)
        {
            squareSum += SquareInt(i);
        }

        return squareSum;
    }

    static int SquareInt(int k)
    {
        return k * k;
    }
}