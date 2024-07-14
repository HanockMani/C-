using System;

public class TypeCasting
{
	public TypeCasting()
	{
        long myNum = 15000000000L;
        Console.WriteLine(myNum);

        //Automatic casting
        int myInt = 10;
        double myDouble = myInt;
        Console.WriteLine(myInt);

        //DownCasting
        myInt = (int)myDouble;
        Console.WriteLine(myDouble);
            
    }
}
