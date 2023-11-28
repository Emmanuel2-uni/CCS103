using System.Collections;
using System.Collections.Generic;

int run = 1;
int ch = 0;
int seatRes = 0;
int flag = 0;

int[] seats = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
LinkedList<int> mySeats = new LinkedList<int>(seats);  

do{

//Console.Clear();
System.Console.WriteLine("\n1. Reserve a seat");
System.Console.WriteLine("2. Cancel a reservation");
System.Console.WriteLine("3. Display available seats");
System.Console.WriteLine("4. Quit");
System.Console.Write("Enter your choice: ");
ch = Convert.ToInt32(System.Console.ReadLine());    

switch(ch){
    case 1:
    
        foreach(var num in mySeats){
            System.Console.Write(num + " ");
        }

        System.Console.Write("\nEnter the seat number to reserve: ");
        seatRes = Convert.ToInt32(System.Console.ReadLine());
        mySeats.Remove(seatRes);
        System.Console.WriteLine($"Seat {seatRes} has been reserved.");
    break;

    case 2:
        foreach(var num in mySeats){
            System.Console.Write(num + " ");
        }
    
        System.Console.Write("\nEnter the seat number to cancel the reservation: ");
        seatRes = Convert.ToInt32(System.Console.ReadLine());

        //mySeats.AddLast(seatRes);

        foreach(var num in mySeats){
            if(num == seatRes){  
                flag = 0;
                //System.Console.WriteLine("break");
                break;
            }else{
                flag = 1;
            }
        }
            if(flag == 1){
                mySeats.AddLast(seatRes);
            }

        System.Console.WriteLine($"Reservation for Seat {seatRes} has been canceled.");
    break;

    //Display available seats

    case 3:
        foreach(var num in mySeats){
            System.Console.Write(num + " ");
        }
    break;


    case 4:
        run = 0;

    break;
}

}while(run == 1);
