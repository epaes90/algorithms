using System;

public class Program
{
	public static void Main()
	{
		int[] array = {1, 2, 3, 4, 5, 6,7,8,9,0};
		Reverse(array);
		for (int i = 0; i < array.Length; i++)
		{
			Console.WriteLine(array[i]);
		}
	}

	public static void Reverse(int[] array)
	{
		for (int i = 0; i < array.Length/2; i++)
		{
			var c = array[i];
			array[i] = array[array.Length - i - 1];
			array[array.Length - i - 1] = c;
		}
	}
}
