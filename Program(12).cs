//Declare String customer queue (Abstract)
Queue<string> customers = new Queue<string>();

String customer_name;
int flag_run = 0;
int choice = 0;
int choice_call = 0;

//Start of program
do{
    System.Console.Clear();
    System.Console.WriteLine("==== Customer Queueing System ====");
    System.Console.WriteLine("Number of clients for the day is " + customers.Count);
    System.Console.WriteLine("1. Add Customer");
    System.Console.WriteLine("2. Call next customer");
    System.Console.WriteLine("3. Remaining Customer");
    System.Console.WriteLine("4. Exit");

    System.Console.Write("\nEnter choice: ");
    choice = Convert.ToInt32(System.Console.ReadLine());


    switch(choice){

        //Input customer name
        case 1:
            System.Console.WriteLine("\n==== Input new customer ====");
            System.Console.Write("\n\nInput customer name: ");
            customer_name = System.Console.ReadLine();
            customers.Enqueue(customer_name);
            System.Console.WriteLine("Customer " + customer_name + " has been added.");
            System.Console.ReadKey();
            break;
            
        //Call next customer
        case 2:
            System.Console.WriteLine("\n==== Call customer ====");
            System.Console.WriteLine("\n\n Call next customer? [1 - yes | 2 - no]");
            choice_call = Convert.ToInt32(System.Console.ReadLine());
            if(choice_call == 1 && customers.Count != 0){
                System.Console.WriteLine("Now serving..." + customers.Peek());
                customers.Dequeue();
                System.Console.ReadKey();
            }
            else if(choice_call == 1 && customers.Count == 0){
                System.Console.WriteLine("Queue is empty. Exiting call option...");
                System.Console.ReadKey();
                break;
            }
            else{
                System.Console.WriteLine("Exiting call option...");
                System.Console.ReadKey();
                break;
            }
            break;

        //Display remaining customers.
        case 3:
            System.Console.WriteLine("\n==== Display remaining customers ====\n");
            foreach(var name in customers){
                System.Console.WriteLine(name);
            }
            System.Console.ReadKey();
            break;

        //Exit out of the program
        case 4:
            flag_run = 1;
            break;

        //Catch default/random options
        default:
            break;
    }

}while(flag_run == 0);