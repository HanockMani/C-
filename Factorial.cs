using System;

public class Factorial
{
	public Factorial(int num)
	{
		int fact = 1;
		if(num == 0)
			fact = 1;
		else if(num > 0)
		{
            for (int i = 1; i <= num; i++)
            {
                fact = fact * i;
            }
        }
		Console.WriteLine("Factorial ="+fact);
	}
}
