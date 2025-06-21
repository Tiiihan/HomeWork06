//Генерація простих чисел: Напишіть програму, яка генерує прості числа від 1 до заданого користувачем числа.
//Просте число - це число, яке ділиться лише на 1 і на себе.

bool isInt = false;
bool isPrime = true;
int userInput = 0;
int counter = 0;

while (!isInt)
{
	Console.Write("Enter number: ");
	isInt = int.TryParse(Console.ReadLine(), out userInput);
}

for (int i = 1; i <= userInput; i++)
{
	isPrime = true;

	for (int j = 2; j <= i; j++)
	{
		if (i % j == 0 && i != j)
			isPrime = false;
	}

	if(isPrime)
        Console.WriteLine(i);
}