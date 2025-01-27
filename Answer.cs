using System;

class IsPrimeOrNot
{
    public static void Main(String[] args)
    {
        Console.Write("Enter the first no.= ");
        int start = int.Parse(Console.ReadLine());

        Console.Write("Enter the second no.= ");
        int end = int.Parse(Console.ReadLine());

        if (start>end)
        {
            int temp = start;
            start = end;
            end = temp;
        }

        Console.WriteLine("Prime numbers b/w input no.'s= ");
        for (int i=end;i>=start;i--)
        {
            bool isPrime = true;

            if (i < 2)
            {
                isPrime = false;
            }
            else
            {
                for (int j=2;j<i;j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }

            if (isPrime)
            {
                Console.WriteLine(i);
            }
        }
    }
}
