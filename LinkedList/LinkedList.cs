class LinkedList{
    private Node head;

    public LinkedList(){
        head = null;

    }
    public void Add(int Data){ //25, 7
        
        // Function accepts an int variable
        // should be called Data with an uppercase D in order to not confuse people
       Node newNode = new Node(Data);
       if(head == null){
            head = newNode;
            return;
       }
       else{
            Node current = head; //25 first node data
            while(current.Next != null){ // true
                current = current.Next; // set to the next node


            }
            current.Next = newNode; //set 7 as the next node

       }
    }

    public void Display(){

        Node current = head;
        while(current!=null)
        {
            System.Console.WriteLine(current.Data);
            current = current.Next;
        }
    }

    public void Remove(int Data){
        // Determines if head is empty or not
        if(head == null){
            return;
        }

        if(head.Data == Data){
            head.Next = null;
            return;
        }

        Node current = head;
        while(current.Next != null){
            if(current.Next.Data == Data){
                current.Next = current.Next.Next;
                return;
            }
            current = current.Next;

        }
    }
}