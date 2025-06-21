//Калькулятор оплати праці за годину: Напишіть програму, яка запитує в користувача кількість годин, працюваних за день,
//та розмір годинної ставки.
//Після введення значень програма має обчислити та вивести оплату за день.

bool isDouble1 = false;
bool isDouble2 = false;
double hoursPerDay = 0;
double hourlyRate = 0;

while (!isDouble1)
{
	Console.Write("Enter the number of working hours per day: ");
	isDouble1 = double.TryParse(Console.ReadLine(), out hoursPerDay);
}

while (!isDouble2)
{
	Console.Write("Enter hourly rate: ");
	isDouble2 = double.TryParse(Console.ReadLine(), out hourlyRate);
}

double payment = hourlyRate * hoursPerDay;
Console.WriteLine($"Payment per day: {payment}");