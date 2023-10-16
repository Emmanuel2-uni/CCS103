LinkedList myLinkedList = new LinkedList();

myLinkedList.Add(25);
myLinkedList.Add(7);
myLinkedList.Add(3);
myLinkedList.Add(58);
myLinkedList.Add(96);
myLinkedList.Add(100);


myLinkedList.Display();

System.Console.WriteLine("\nRemoving 7...");
myLinkedList.Remove(7);

myLinkedList.Display();




/*
Node nodeA = new Node(25);
Node nodeB = new Node(7);
Node nodeC = new Node(1);

nodeA.Next = nodeB;
nodeB.Next = nodeC;

System.Console.WriteLine(nodeA.Next.Data);
System.Console.WriteLine(nodeB.Next.Data);

*/
