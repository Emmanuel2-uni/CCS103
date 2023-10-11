//Declaration of three arrays.
int [] nums_even;
int [] nums_odd;
int [] nums_main;


int max = 0;
int count_even = 0;
int count_odd = 0;

//Get dynamic size of array
System.Console.Write("Input number of elements to be stored in the Array: ");
max = Convert.ToInt32(Console.ReadLine());

nums_main = new int[max];

//Store elements into the main array and determine if the number is odd or even.
System.Console.Write($"\nInput {nums_main.Length} elements in the Array: \n");
for(int i = 0, length = nums_main.Length; i < length; i++)
{
    System.Console.Write($"Input element {i}: ");
    nums_main[i] = Convert.ToInt32(Console.ReadLine());
  
    if(nums_main[i]%2 != 0)
    {   
        count_odd += 1;
    }
    else if(nums_main[i]%2 == 0)
    {
        count_even += 1;
    }
}



//Declare new length/size of even and odd arrays
nums_even = new int[count_even];
nums_odd = new int[count_odd];

//Reset counts to 0 for index/element storing purposes
count_even = 0;
count_odd = 0;

for(int i = 0, length = nums_main.Length; i < length; i++)
{
    if(nums_main[i]%2 != 0)
    {   
        nums_odd[count_odd] = nums_main[i];
        count_odd++;
    }
    else if(nums_main[i]%2 == 0)
    {
        nums_even[count_even] = nums_main[i];
        count_even++;
    }
}


System.Console.Write($"\nThe even elements are: \n");
for(int i = 0, length = nums_even.Length; i < length; i++)
{
    System.Console.Write(nums_even[i] + " ");
}


System.Console.Write($"\nThe odd elements are: \n");
for(int i = 0, length = nums_odd.Length; i < length; i++)
{
    System.Console.Write(nums_odd[i] + " ");
}
