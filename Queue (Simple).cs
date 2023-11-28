Queue<string> customers = new Queue<string>();
String customer_name;
int flag_run = 0;
int flag_run_2 = 0;
int choice = 0;

do{

    System.Console.Write("Enter customer name [0 to exit]: ");
    customer_name = System.Console.ReadLine();

    if(customer_name == "0")
    {
        flag_run = 1;
        break;
    }

    customers.Enqueue(customer_name);
    System.Console.WriteLine();

}while(flag_run == 0);

//For checking name list
foreach(var name in customers){
    System.Console.WriteLine(name);
}

do{
    System.Console.WriteLine("Next customer is " + customers.Peek());
    System.Console.WriteLine("Remaining Customers: ");

    foreach(var name in customers){
        System.Console.Write(name + " ");
    }


    System.Console.WriteLine("\nCall next customer? [1 - yes | 2 - no]: ");
    choice = Convert.ToInt32(System.Console.ReadLine());

    if( choice == 1 ){
        System.Console.WriteLine("\nNow serving... " + customers.Peek());
        customers.Dequeue();
    }
    else if(choice == 2)
    {
        flag_run_2 = 1;
        break;
    }else{
        System.Console.WriteLine("\nInvalid choice.");
    }

}while(flag_run_2 == 0);
