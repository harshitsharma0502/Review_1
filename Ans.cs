using System;

class ReverseMid
{
    public static void Main()
    {
        Console.Write("Enter an integer: ");
        int num = int.Parse(Console.ReadLine());

        // Count digits
        int temp = num, count = 0;
        while (temp > 0)
        {
            count++;
            temp /= 10;
        }

        int half = count / 2;
        int firstHalfReversed = 0, secondHalfReversed = 0;
        int middleDigit = 0;
        int multiplier = 1, divisor = 1;

        // Find divisor to split number
        for (int i = 0; i < half; i++)
        {
            divisor *= 10;
        }

        int firstHalf = num / divisor;
        int secondHalf = num % divisor;

        // If odd digits, extract middle digit
        if (count % 2 != 0)
        {
            middleDigit = firstHalf % (divisor / 10);
            firstHalf = firstHalf / (divisor / 10);
        }

        // Reverse first half
        while (firstHalf > 0)
        {
            firstHalfReversed = firstHalfReversed * 10 + firstHalf % 10;
            firstHalf /= 10;
        }

        // Reverse second half
        while (secondHalf > 0)
        {
            secondHalfReversed = secondHalfReversed * 10 + secondHalf % 10;
            secondHalf /= 10;
        }

        // Calculate proper multiplier for final output
        temp = secondHalfReversed;
        while (temp > 0)
        {
            multiplier *= 10;
            temp /= 10;
        }

        // Construct final result
        int result;
        if (count % 2 == 0)
        {
            result = firstHalfReversed * multiplier + secondHalfReversed;
        }
        else
        {
            result = firstHalfReversed * (multiplier * 10) + middleDigit * multiplier + secondHalfReversed;
        }

        Console.WriteLine("Output: " + result);
    }
}
