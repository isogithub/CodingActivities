
/* Sorting ranfon numbers */


/*
int[] numberArr = new int[100];
Random rnd = new Random();
int counter = 0;

while (counter < 100)
{
	int uniqueNumber = rnd.Next(0, 1001);
	bool isArrContain = false;
	for (int i = counter; i < 100; i++)

	{
		if (numberArr[i] == uniqueNumber)
		{
			isArrContain = true;
			break;
		}

	}
	if (!isArrContain)

	{
		numberArr[counter] = uniqueNumber;
		counter++;
	}

}

for (int i = 1; i <= 3; i++)
{
	int biggestNumber = numberArr[0];
	for (int j = 0; j < numberArr.Length; j++)
	{

		if (numberArr[j] > biggestNumber)
		{
			biggestNumber = numberArr[j];
			numberArr[j] = numberArr[0];
		}


	}

	Console.WriteLine(biggestNumber);

}

Console.ReadLine();
*/



int[] numbers = new int[100];
Random rand = new Random();

int count = 0;
while (count < numbers.Length)
{
	int rndmNumber = rand.Next(0, 1001);
	if (numbers.Contains(rndmNumber))
	{
		continue;
	}
	numbers[count] = rndmNumber;
	count++;
}


int[] threeLargestBumber = numbers[0..3];
for (int i = 0; i < threeLargestBumber.Length; i++)
{
	for (int j = 0; j < numbers.Length; j++)
	{
		if (threeLargestBumber[i] <= numbers[j] && !threeLargestBumber.Contains(numbers[j]))
		{
			threeLargestBumber[i] = numbers[j];
		}
		continue;
	}
}

Console.WriteLine("*** The Three Largest Numbers ***");
for (int i = 0; i < threeLargestBumber.Length; i++)
{
	Console.WriteLine("{0}", threeLargestBumber[i]);
}

Console.ReadLine();
