// Declare number of categories *num_cat* integer
System.Console.Write("Enter number of item categories: ");
int num_cat = Convert.ToInt32(Console.ReadLine());

// Declare number of Jagged Arrays according to num_cat for name and quantity
String [][] Product_name = new String[num_cat][];
int [][] Product_quant = new int[num_cat][];

String input;
int quant = 0;

for(int i = 0; i < num_cat; i++){
    System.Console.Write($"\nEnter number of products for category {i+1}: ");
    int num_prod = Convert.ToInt32(Console.ReadLine());

    // Declare size (number of products, num_prod) of specific Jagged Array [i]
    Product_name[i] = new String[num_prod];
    Product_quant[i] = new int[num_prod];

    System.Console.WriteLine("");

    for(int j = 0; j < num_prod; j++){

        // Enter the product name
        System.Console.Write($"Enter product name for category {i+1}, product {j+1}: ");
        input = Console.ReadLine();
        Product_name[i][j] = input;

        // Enter the product quantity
        System.Console.Write($"Enter quantity for product {input}: ");
        quant = Convert.ToInt32(Console.ReadLine());
        Product_quant[i][j] = quant;
    }
}

System.Console.Write("\nInventory: \n");

// List down the name and quantity of items stored in each Jagged Array
for(int i = 0; i < Product_name.Length; i++){
    System.Console.Write($"  Category {i+1}: \n");

    for(int j = 0; j < Product_name[i].Length; j++){
        System.Console.Write($"\t{Product_name[i][j]} ({Product_quant[i][j]})\n");
    }
}
