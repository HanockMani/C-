using System;

public class DayFinder
{
    public DayFinder(int Day)
    {
        if (Day < 1 && Day > 7)
            Console.WriteLine("Invalid Day!");
        else
        {
            switch (Day)
            {
                case 1:
                    Console.WriteLine("Day Is Sunday");
                    break;
                case 2:
                    Console.WriteLine("Day is Monday");
                    break;
                case 3:
                    Console.WriteLine("Day Is Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Day is Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Day is Thursday");
                    break;
                case 6:
                    Console.WriteLine("Day Is Friday");
                    break;
                case 7:
                    Console.WriteLine("Day is Saturday");
                    break;

            }
        }
    }
}
