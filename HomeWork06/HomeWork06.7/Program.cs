//Генерація таблиці множення для конкретного числа: 
//Напишіть програму, яка запитує в користувача число, а потім генерує таблицю множення для цього числа від 1 до 10.

const int lowLIMIT = 1;
const int upperLIMIT = 10;
bool isInt = false;
int userInput = 0;

while (!isInt)
{
	Console.Write("Enter number: ");
	isInt = int.TryParse(Console.ReadLine(), out userInput);
}

for(int i = lowLIMIT; i <= upperLIMIT; i++)
    Console.WriteLine(i * userInput);