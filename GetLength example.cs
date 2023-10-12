//Declare 2d weeklySales array and populate/fill it with existing variables/data
int [,] weeklySales = {
    {1, 2, 3, 4, 5, 6, 7},
    {1, 2, 3, 4, 5, 6, 7},
    {1, 2, 3, 4, 5, 6, 7},
    {1, 2, 3, 4, 5, 6, 7}
};

System.Console.WriteLine("Total number of days: " + weeklySales.Length);

System.Console.WriteLine("\n");

//Get the length/size of "row", .GetLength(<number>) is used in 2d arrays instead of .Length.
int max_row = weeklySales.GetLength(0);

//Get the length of "column"
int max_column = weeklySales.GetLength(1);

System.Console.WriteLine("Number of elements in \"row\": " + max_row);
System.Console.WriteLine("Number of elements in \"column\": " + max_column);

//Console methods for changing printed console text
Console.ForegroundColor = ConsoleColor.Yellow;
System.Console.WriteLine("\t  Day 1 2 3 4 5 6 7 Total");
Console.ForegroundColor = ConsoleColor.Gray;


//Since we are using a 2d array, one of the simplest ways to get the sum of an entire row is to use for-loops
//LINQ methods cannot be easily used with 2d+ arrays.

int total = 0;

// .GetLength(0) is used for getting size of the row in 2D arrays
for (int i = 0; i < weeklySales.GetLength(0); i++)
{
    Console.ForegroundColor = ConsoleColor.Green;
    System.Console.Write($"Week {i} sales: ");
    Console.ForegroundColor = ConsoleColor.Gray;

    // .GetLength(1) is used for getting size of the column in 2D arrays
    for (int j = 0; j < weeklySales.GetLength(1); j++)
    {
        System.Console.Write(weeklySales[i, j] + " ");
        total += weeklySales[i, j];
    }

    Console.ForegroundColor = ConsoleColor.Cyan;
    System.Console.Write($" {total}");
    Console.ForegroundColor = ConsoleColor.Gray;
    total = 0;

    System.Console.WriteLine("\n");
}


