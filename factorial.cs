using System;
					
public class Program
{
	public static void Main()
	{
		int n = 6;
		
		Console.WriteLine(n);
		Console.WriteLine(Factorial(n));
	}
	
	private static int Factorial(int n)
	{
		if (n==1)
		{
			return n;
		}
		return (n * Factorial(n-1));
	}
}
