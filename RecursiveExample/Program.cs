
/*
	1 - 2 + 3 - 4 + .... - 100 = ?
 */


// Solution 1
int result1 = Calculate(100);
int Calculate(int a)
{
	if (a == 1)
	{
		return 1;
	}
	else
	{
		if (a % 2 == 0)
		{
			return -a + Calculate(a - 1);
		}
		else
		{
			return a + Calculate(a - 1);
		}
	}
}

// Print result
Console.WriteLine($"Result1 = {result1}");

Console.WriteLine("***** ***** *****");

// Solution 2
int result2 = Calculate2(1);
int Calculate2(int a)
{
	if (a >= 101)
		return 0;
	int result = a - Calculate2(a + 1);
	return result;
}


// Print result
Console.WriteLine($"Result2 = {result2}");

