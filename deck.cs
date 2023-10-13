// Declare TWO 2D Jagged Arrays without sizes
int [][,] deck = new int[2][,];

// Declare Lower Deck 1 with 3 rows and 10 columns (dont forget the double curly braces for 2D arrays)
// Dont forget the comma for each row except the final row
deck[0] = new int[3,10] {
    {1, 2, 3, 4, 5, 6, 7, 8 ,9 ,10},
    {11, 12, 13, 14, 15, 16, 17, 18, 19, 20},
    {21, 22, 23, 24, 25, 26, 27, 28, 29, 30}
};
// ^ dont forget the semi-colon here


// Declare Lower Deck 2 with 5 rows and 10 columns (dont forget the double curly braces for 2D arrays)
// Dont forget the comma for each row except the final row
deck[1] = new int[5,10] {
    {1, 2, 3, 4, 5, 6, 7, 8 ,9 ,10},
    {11, 12, 13, 14, 15, 16, 17, 18, 19, 20},
    {21, 22, 23, 24, 25, 26, 27, 28, 29, 30},
    {31, 32, 33, 34, 35, 36, 37, 38, 39, 40},
    {41, 42, 43, 44, 45, 46, 47, 48, 49, 50}
};
// ^ dont forget the semi-colon here


//Write Lower Deck 1 seats
System.Console.Write("\nLower deck 1\n");

// row, we use .GetLength(0) to get the size of the rows for the first deck index [0]
// this is equal to 3
    for (int i = 0; i < deck[0].GetLength(0); i++){
        
        // column, we use .GetLength(1)
        // this is equal to 10
        for(int j = 0; j < 10; j++){

            // syntax: deck[0][row, col]
            System.Console.Write($"{deck[0][i,j]} ");
        }
    System.Console.WriteLine("");
    }

//Write Lower Deck 2 seats
System.Console.Write("\nLower deck 2\n");

// row, we use .GetLength(0) to get the size of the rows for the first deck index [0]
// this is equal to 5
    for (int i = 0; i < deck[1].GetLength(0); i++){
        
        // column, we use .GetLength(1)
        // this is equal to 10
        for(int j = 0; j < 10; j++){

            // syntax: deck[0][row, col]
            System.Console.Write($"{deck[1][i,j]} ");
        }
    System.Console.WriteLine("");
    }


// Take inputs for reservation
System.Console.Write("\nPlease enter the deck number (1 or 2): ");
int decknum = Convert.ToInt32(Console.ReadLine());

// We reduced the decknum by 1 so that we can accurately point to the jagged array/deck index
// if we input 2, deck[2] does not exist. So we reduce 1 to point to the real second deck: deck[1]
decknum = decknum - 1;

System.Console.Write("Please enter the seat number: ");
int seatnum = Convert.ToInt32(Console.ReadLine());

// flag for checking if seat exists
bool flag  = false;

// .GetLength(0) to get the number of rows in a 2D array
for (int i = 0; i < deck[decknum].GetLength(0); i++){

    // .GetLength(1) to get the number of columns in a 2D array
    for (int j = 0; j < deck[decknum].GetLength(1); j++){
        
        // syntax: deck[deck 0 or 1][row, col]
        if(deck[decknum][i,j] == seatnum){
            flag = true;
        }
    }   
}

if (flag == false){
    System.Console.WriteLine("\nInvalid Seat Number.");
}else{
    System.Console.WriteLine("\nReservation saved.");
}
