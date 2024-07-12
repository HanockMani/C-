using System;

public class ExceptionHandling
{
	public ExceptionHandling()
	{
        int[] ar = new int[5];
        try
        {
            for (int i = 0; i < 10; i++)
            {
                ar[i] = i;
            }
        }
        catch (System.IndexOutOfRangeException)
        {
            Console.WriteLine("Range Exceeded!");
        }
        foreach (int i in ar)
        {
            Console.WriteLine(ar[i]);
        }
    }
}
