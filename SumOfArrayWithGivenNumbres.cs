/* Arrays play important role in programming. They are used to group similar data types. An array has a common name and each individual element is accessed by an index. 
In this exercise we're working with an array of 10 integers, as follows: [10, 20, 30, 40, 50, 60, 70, 80, 90, 100]. 0 is the first index and 9 is the last index of the array. 
Write a function that receives two integers as parameters. The function returns the sum of the elements in the array found between those two integers. 
For example, if we use 30 and 60 as parameters, the function should return 180. 
A few additional requirements: 
• The two integers passed to the function should be positive; if not, the function should return -1. 
• Validate that the first integer is lower than the second integer. If not, the function should return 0. 
• If the first integer is in the array, and the second is above 100, for example 90 and 120, then the function should return the sum of those integers that are within the array and in between the range given. 
In this case, that would be 190. 
• If both integers are not found in the array, for example 110 and 120, the function should return 0. 
*/

Console.WriteLine("Enter first number");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Second number");
int num2 = Convert.ToInt32(Console.ReadLine());

int SumOfNumber = GetSumOfArray(num1, num2);

if (SumOfNumber == -1)
{
    Console.WriteLine("Invalid input: Negative number entered.");
}
else
{
    Console.WriteLine($"Sum of Array list {SumOfNumber}");
}

static int GetSumOfArray(int firstNumber, int secondNumber)
{
    if (firstNumber < 0 || secondNumber < 0)
    {
        return -1;
    }

    int sum = 0;
    int[] arrayInt = new int[] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

    bool foundFirstNumber = false;
    bool foundSecondNumber = false;

    for (int i = 0; i < arrayInt.Length; i++)
    {
        if (arrayInt[i] == firstNumber)
        {
            foundFirstNumber = true;
            sum += arrayInt[i];
        }

        if (arrayInt[i] == secondNumber)
        {
            foundSecondNumber = true;
            sum += arrayInt[i];
        }

        if (foundFirstNumber && foundSecondNumber)
        {
            break;
        }
    }

    if (!foundFirstNumber || !foundSecondNumber)
    {
        return 0;
    }
    return sum;
}
