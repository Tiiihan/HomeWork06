//Обчислення середнього заробітку: Напишіть програму, яка запитує користувача про зарплату кожного працівника за місяць. 
//Після отримання всіх значень програма має обчислити та вивести середній заробіток.

bool isInt = false;
bool isDouble = false;
int numberOfEmployees = 0;
double monthlySalary = 0;
double totalSalary = 0;

while (!isInt)
{
	Console.Write("Enter number of employees: ");
	isInt = int.TryParse(Console.ReadLine(), out numberOfEmployees);
}

for (int i = 0; i < numberOfEmployees; i++)
{
	while (!isDouble)
	{
		Console.Write($"Enter salary for employee {i + 1}: ");
		isDouble = double.TryParse(Console.ReadLine(), out monthlySalary);
	}

	totalSalary += monthlySalary;

	isDouble = false;
}

Console.WriteLine($"Average salary per month is {totalSalary / numberOfEmployees}");