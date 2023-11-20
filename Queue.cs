//Define a queue, typesafe
Queue<string> customers = new Queue<string>();


//Adds an object into the queue
//First in, first out
// .Enqueue("Juan") adds Juan to index 0 of the queue
// .Enqueue("Kris") adds Kris to index 1 of the queue
customers.Enqueue("Juan");
customers.Enqueue("Kris");
customers.Enqueue("Mark");
customers.Enqueue("Peter");


// .Dequeue removes the front object of the queue and returns it
System.Console.WriteLine("Now serving... " + customers.Dequeue());

System.Console.WriteLine("\n\n");


// .Peek returns the current front object of the queue
System.Console.WriteLine("Next customer is " + customers.Peek());


System.Console.WriteLine("\n\n");

// Display the remaining objects in the customers queue
System.Console.WriteLine("Remaining Customers: ");
foreach(var items in customers){
    System.Console.WriteLine(items);
}

