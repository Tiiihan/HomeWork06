//Генерація фібоначчівської послідовності: Напишіть програму, яка генерує перші N чисел Фібоначчі.
//Послідовність Фібоначчі починається з 0 і 1, а кожне наступне число є сумою двох попередніх чисел у послідовності.

int N = 0;
bool isInt = false;

while (!isInt)
{
	Console.Write("Enter number: ");
	isInt = int.TryParse(Console.ReadLine(), out N);

	if(N < 2)
		isInt = false;
}

int limit = N - 2;
int previous1 = 0;
int previous2 = 1;
int current = 0;

Console.WriteLine(previous1);
Console.WriteLine(previous2);

for (int i = 0; i < limit; i++)
{
	current = previous1 + previous2;

	previous1 = previous2;
	previous2 = current;

	Console.WriteLine(current);
}