bool isEqual = false;
int counter = 0;
double averageSalary = 0f;

Console.Write("Enter quantity of employers");
int employers = int.Parse(Console.ReadLine());



for (int counter2 = 0; counter2 < employers; counter2++)
{
	Console.Write($"Enter salary of {counter2 + 1}th employee ");
	double salaryPerMonth = float.Parse(Console.ReadLine());

	averageSalary += salaryPerMonth;
}

Console.WriteLine($"Average salary per month is {averageSalary/employers}");


//bool isEqual = false;
//while (!isEqual)
//{
//    Console.Write($"Enter salary of {counter + 1}th employee ");
//	double salaryPerMonth = float.Parse(Console.ReadLine());

//    counter++;
//    averageSalary += salaryPerMonth;

//    if (counter == employers)
//        isEqual = true;
//}