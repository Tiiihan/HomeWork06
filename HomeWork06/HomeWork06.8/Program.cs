//Перевірка на простоту: Напишіть програму, яка перевіряє, чи є задане користувачем число простим. 
//Число вважається простим, якщо воно ділиться лише на 1 і на себе.

bool isInt = false;
int userInput = 0;
int counter = 0;

while (!isInt)
{
	Console.Write("Enter number: ");
	isInt = int.TryParse(Console.ReadLine(), out userInput);
}

for (int i = 2; i <= userInput; i++)
{
	if (userInput % i == 0 && i != userInput)
		counter++;
}

if (counter == 0)
	Console.WriteLine($"It`s prime {userInput}");
else
	Console.WriteLine("It`s not prime");