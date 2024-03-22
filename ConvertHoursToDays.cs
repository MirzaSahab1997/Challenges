/* Your job for now: convert hours into days. Here is the basic formula: days = h / 24.

Here are the tests that your function should pass: */

int counter = 1;
Console.WriteLine("Please Enter hours to Convert into Days");
double? inputHours = Convert.ToInt32(Console.ReadLine());
do
{
    double? totalDays = ToDays(inputHours);
    Console.WriteLine(totalDays);

    Console.WriteLine("Please Enter hours to Convert into Days (or enter 0 to exit)");
    inputHours = Convert.ToDouble(Console.ReadLine());

    counter++;
}
while (inputHours != 0);

static double? ToDays(double? hours)
{
    if (hours < 0)
    {
        return 0;
    }

    double? days = hours / 24;
    return days;
}
