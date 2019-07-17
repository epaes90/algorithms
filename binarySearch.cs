using System;

public class Program
{
	static int i = 0;
	public static void Main()
	{
		int[] array = {1, 2, 3, 4, 5, 7, 8, 9, 10,11,12,13,14,15,16,17,18,20,21,22,26,27,28,29};
		int index = BinarySearch(array, 19);
		Console.WriteLine("index: " + index);
		if (index > -1)
		{
			Console.WriteLine("number: " + array[index]);
		}
	}

	public static int BinarySearch(int[] array, int num)
	{
		return BinarySearch(array, num, -1, -1);
	}

	private static int BinarySearch(int[] array, int num, int index, int index2)
	{
		if (index == -1)
		{
			index = 0;
		}

		if (index2 == -1)
		{
			index2 = array.Length;
		}

		int mid = (index + index2) / 2;
		
		if (array[mid] == num)
		{
			return mid;
		}

		if (mid == index || mid == index2)
		{
			return -1;
		}

		if (array[mid] < num)
		{
			return BinarySearch(array, num, mid, index2);
		}

		return BinarySearch(array, num, index, mid);
	}
}
