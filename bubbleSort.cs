using System;

public class Program
{
	public static void Main()
	{
		int[] array = {2,3,6,1,4,5,9,8,7,25,88,5};
		BubbleSort(array);
		for (int i = 0; i < array.Length; i++)
		{
			Console.WriteLine(array[i]);
		}
	}

	public static void BubbleSort(int[] array)
	{
		int aux;
		for (int j = 0; j < array.Length; j++)
		{
			for (int i = 1; i < array.Length; i++)
			{
				if (array[i - 1] > array[i])
				{
					aux = array[i - 1];
					array[i - 1] = array[i];
					array[i] = aux;
				}
			}
		}
	}

}
