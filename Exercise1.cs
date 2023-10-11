//Declaration of two arrays.
int [] nums1;
int [] nums2;

int max = 0;

//Get dynamic size of array
System.Console.Write("Input number of elements to be stored in the Array: ");
max = Convert.ToInt32(Console.ReadLine());
 
nums1 = new int[max];
nums2 = new int[max];
 
System.Console.Write($"\nInput {nums1.Length} elements in the Array: \n");
 
for(int i = 0, length = nums1.Length; i < length; i++)
{
    System.Console.Write($"Input element {i}: ");
    nums1[i] = Convert.ToInt32(Console.ReadLine());
}
 
 
//copy nums1[] to nums2[]
nums2 = nums1;
System.Console.Write($"\nElements in Array 1 are:\n");

for(int i = 0, length = nums1.Length; i < length; i++)
{
    System.Console.Write(nums1[i] + " ");
}
 
System.Console.Write($"\nElements in Array 2 are:\n");
 
for(int i = 0, length = nums1.Length; i < length; i++)
{
    System.Console.Write(nums2[i] + " ");
}
