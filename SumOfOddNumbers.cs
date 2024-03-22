/* Sum the odd numbers

Implement an algorithm to sum together all the odd numbers in a collection. Here are the tests that your solution should pass:

SumOdds(new int[]{1, 2, 3, 4, 5}) -> 9
SumOdds(new int[]{1, 2, 3}) -> 4
SumOdds(new int[]{2, 2}) -> 0
SumOdds(new int[]{1, 1}) -> 2
That one should be fairly easy. You just need to check each number in the collection, to see whether it is odd or even. If it is odd, then add its value to the sum.

Here is the initial code to give you a headstart: */

int[] ints = new int[] { 1, 2, 3};
int SumOfOdds = new SumOfOddNumbersArray().SumOfOdds(ints);

Console.WriteLine(SumOfOdds);

static int SumOfOdds(int[] digits)
{
    if (digits.Length < 0)
    {
        return 0;
    }

    int sum = 0;

    for (int i = 0; i < digits.Length; i++)
    {
        if (digits[i] % 2 != 0)
        {
            sum += digits[i];
        }
    }

    return sum;
}
