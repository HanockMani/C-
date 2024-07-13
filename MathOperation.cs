using System;

delegate int ArithOp(int x, int y);

public class MathOperation
{
	public static int Add(int a, int b)
	{
		return (a + b);
	}

	public static int sub(int a, int b)
	{
		return (a - b);
	}
}
