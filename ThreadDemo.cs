using System;
using System.Threading;

public class ThreadDemo
{
	public ThreadDemo()
	{
		Thread thread1 = new Thread(() => PrintNumbers("Thread1"));
        Thread thread2 = new Thread(() => PrintNumbers("Thread2"));

		thread1.start();
		thread2.start();

        Console.WriteLine("Main thread is continuing to run");

        thread1.join();
        thread2.join();

		Console.WriteLine("Both threads have finished execution");

    }

    public void PrintNumbers(string threadName)
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"{threadName}: {i}");
            Thread.sleep(500);
        }
    }
}

