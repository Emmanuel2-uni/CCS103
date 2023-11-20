class Queue
{
    // Manually programming the Queue abstract function
    private int[] array;
    private int front;
    private int rear;
    private int capacity;


    // Queue that only accepts integer numbers
    // !! Constructor !! for the Queue object
    public Queue(int size)
    {
        //Capcity becomes size
        capacity = size;
        array = new int[size];
        front = 0;
        rear = -1;
    }
    

    // Enqueue function
    public void Enqueue(int item)
    {   
        // Checks if the current queue array is full
        if(rear == capacity-1)
        {
            System.Console.WriteLine("Queue is full. Cannot enqueue");
        }


        // If the queue is empty, we set the front to index 0
        if(front==-1)
        {
            front = 0;
        }


        array[++rear] = item;
        System.Console.WriteLine($"{item} enqueued to the queue");       
    }


    // Dequeue function, removes the array entry in the "front" index
    public void Dequeue()
    {
        // If the queue is empty, we return to the caller function and skip
        // the rest of the code.
        if(front == -1)
        {
            System.Console.WriteLine("Queue is empty. Cannot dequeue");
            return;
        }


        // The next item in the queue will be the next iteration of the front index
        //   front++ will iterate the front index upwards and the new [front] value will saved for the entire class
        int item = array[front++];
        System.Console.WriteLine($"{item} dequeued from the queue");       


        //If the end of the queue is reached, we set the front index to -1
        // to indicate queue is empty
        if( front > rear )
        {
            front = rear = -1;
        }
    }   


    // Displays the current content of the queue array
    public void Display()
    {
        // Return out of the Display function if the front is -1
        // -1 signifies empty queue
        if(front == -1)
        {
            System.Console.WriteLine("Queue is empty.");
            return;
        }

        // i = front in order to not list the empty indexes
        System.Console.WriteLine("Queue elements are: ");
        for(int i = front; i<= rear; i++){
            System.Console.WriteLine($"{array[i]}");
        }
    }


    public void Peek()
    {
        // Return out of the Peek function if the front is -1
        // -1 signifies empty queue
        if(front == -1)
        {
            System.Console.WriteLine("Queue is empty.");
            return;
        }

        //The current object in the front index will be stored in "item"
        // and then displayed.
        int item = array[front];
        System.Console.WriteLine($"{item} is the front entry of the current queue.");
        
        if(front > rear)
        {   
            front = rear = -1;
        }

    }

    public void Clear()
    {
        // Return out of the Clear function if the front is -1
        // -1 signifies empty queue
        if(front == -1)
        {
            System.Console.WriteLine("Queue is empty.");
            return;
        }

        System.Console.WriteLine("Clearing the current queue...");

        for(int i = front; i<= rear; i++)
        {
            

        }
        
    }

}