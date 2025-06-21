//Побудова графіку зірочками: Напишіть програму, яка будує графік за допомогою зірочок.
//Користувач повинен ввести кількість рядків графіка. Кожен рядок графіка має містити відповідну кількість зірочок.

bool isInt = false;
int numberOfRows = 0;
string stars = "*";

while (!isInt)
{
	Console.Write("Enter the number of rows of graphics: ");
	isInt = int.TryParse(Console.ReadLine(), out numberOfRows);
}

for (int i = 0; i < numberOfRows; i++)
{
	Console.WriteLine(stars);
	stars += "*";
}