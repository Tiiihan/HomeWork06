string stars = "*";

Console.Write("Enter the number of rows of graphics");
int numberOfRows = int.Parse(Console.ReadLine());

for (int i = 0; i < numberOfRows; i++)
{
    Console.WriteLine(stars);
    stars += "*";
}