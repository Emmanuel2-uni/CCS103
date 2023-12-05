int max = 3;
int [][] students = new int[max][];
float [] average_array = new float[max];
float average = 0;
int score;
System.Console.WriteLine("Task 1: Calculate Average Scores");

//Call students
for(int i = 0; i < students.Length; i++){

    System.Console.WriteLine($"Enter scores for Student {i+1} (up to 5 scores): ");
  
    //Declare size of each student array in the jagged array
    students[i] = new int[5];

    //Call quiz scores  
    for(int j = 0; j < students[i].Length; j++)
    {
        System.Console.Write($"Enter score for {j+1}: ");
        score = Convert.ToInt32(Console.ReadLine());
        students[i][j] = score;
        average += score;
    }

    average_array[i] = average / students[i].Length;

    //resets average and score variables for correct results
    average = 0;
    score = 0;
}

for(int i = 0; i < average_array.Length; i++ )
{
    System.Console.Write($"\nAverage Score for Student {i+1}: {average_array[i]}");
}




System.Console.WriteLine("\n\nTask 2: Find Row with Highest Sum");

int [][] sums = new int[max+1][];
int [] highest = new int[max+1];

for(int i = 0; i < sums.Length; i++)
{
    System.Console.WriteLine($"Enter values for Row {i+1}: ");
  
    sums[i] = new int[4];
  
    for(int j = 0; j < sums[i].Length; j++)
    {
        score = Convert.ToInt32(Console.ReadLine());
        sums[i][j] = score;
        highest[i] += score;

    }
  
    System.Console.WriteLine($"Sum for Row {i+1} = {highest[i]}");
    score = 0;

}


int max_score = 0;
int pos = 0;

for(int i = 0; i < highest.Length; i++){

    if(highest[i] > max_score)
    {
        max_score = highest[i];
        pos = i;
    }

}

System.Console.WriteLine($"\nRow {pos+1} has the highest sum: {max_score}");
