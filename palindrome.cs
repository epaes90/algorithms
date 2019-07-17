using System;

public class Program
{
	public static void Main()
	{
		Console.WriteLine(IsPalindrome("ana")); // True
		Console.WriteLine(IsPalindrome("proburus")); // Fals
		Console.WriteLine(IsPalindrome("qwertyuiopoiuytrewq")); // True
	}

	private static bool IsPalindrome(string word)
	{
		for (int i = 0; i <= word.Length / 2; i++)
		{
			if (word[i] != word[word.Length - i - 1])
			{
				return false;
			}
		}

		return true;
	}
}
