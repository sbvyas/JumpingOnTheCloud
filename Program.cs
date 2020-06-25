using System;

class JumpingOnTheCloud
{		
	static int jumpingOnClouds(int[] c)
	{
		int aTotalSteps = 0;
		
		for (int i = 0; i < c.Length - 1; i++)
		{
			if (i == c.Length - 2)
			{
				aTotalSteps++;
				break;
			}
			if (c[i + 2] == 0)
			{
				i++;
			}
			aTotalSteps++;
		}
		return aTotalSteps;
	}

	static void Main(string[] args)
	{		
		int n = Convert.ToInt32(Console.ReadLine());
		int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp));
		int result = jumpingOnClouds(c);
		Console.WriteLine(result.ToString());
		Console.ReadLine();		
	}
}
