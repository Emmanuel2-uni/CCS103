using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics.Contracts;
using System.Linq;

public class Contactlist{
    // The Contactlist object will contain a List of Contacts from the Contact object.
    // Each entry in the List will have a name, order, email, and number associated with it.
    private List<Contact> contacts;



    // Constructor for the Contactlist object.
    public Contactlist()
    {
        contacts = new List<Contact>();
    }

    
    // Function that will Add(add an index) to the contacts List.
    // Accepts a name, an order, an email, and a number.
    public void add_name(string name, int order, string email, string number)
    {
        contacts.Add(new Contact(name, order, email, number));
    }

    
    public void display_Contacts()
    {
        // Function to display the entire contactlist.
        System.Console.WriteLine("====== Contact List ====== ");   
       
        // the first four code e.g {0, -3}, {1, -20}, etc. are called "Padding", it will take the first variable "0" after which is "Order" etc.
        System.Console.WriteLine("{0, -3}\t{1,-20}\t   {2,-30}\t   {3,-15}","Order", "Name", "E-mail", "Number");
        
        for(int i = 0; i < contacts.Count; i++)
        {
            System.Console.WriteLine("{0, -3}===\t{1, -20}\t-- {2,-30}\t-- {3,-15}", contacts[i].order, contacts[i].name, contacts[i].email, contacts[i].number);
        }

        System.Console.WriteLine("\n");
    }

    
    // Function for searching the contactlist using a given name.
    public void search_Contacts(string name)
    {   

        bool found = false;
        for(int i = 0; i < contacts.Count; i++)
        {
            // ToLower is used so that the search is case insensitive and lets the program accept examples like:
            // bEa == bea, true
            // BEa == bea, true
            // if there exists a name Bea, and is equal to the thrown name in the function, we print their details.
            if(contacts[i].name.ToLower() == name.ToLower())
            {
                found = true;
                System.Console.WriteLine("\n");
                System.Console.WriteLine(contacts[i].name + " contact found.");
                System.Console.WriteLine("Contact Name: " + contacts[i].name);
                System.Console.WriteLine("1. Email: " + contacts[i].email);
                System.Console.WriteLine("2. Number: " + contacts[i].number);
                System.Console.WriteLine("3. Exit" );
                break;
            }
        }
        if(found == false)
        {
            System.Console.WriteLine(name + " not found in the Contact list.");
        }

    }


    // Function for sorting the contactlist.
    public void sort_Contacts(int choice)
    {
        // LINQ based sorting.
        // OrderBy accepts a key from an object x => x.Variable.
        // x.order means it'll use the order and will sort ascending (1 -> 9)
        // x.name means it'll use the names and will sort descending (a -> z)
        // ToList() stores the ordered list to a new list on memory. So we equal our current existing "contacts" list to the new, ordered list in the memory.
        
        if(choice == 1)
            contacts = contacts.OrderBy(x => x.order).ToList();
        if(choice == 2)
            contacts = contacts.OrderBy(x => x.name).ToList();
    }

    
    // Function for removing contacts.
    public bool remove_Contacts(string name)
    {   
        int index = 0;
        int order_saved = 0;
        bool found = false;
        for(int i = 0; i < contacts.Count; i++)
        {
            if(contacts[i].name.ToLower() == name.ToLower())
            {
                found = true;
                index = i;
                order_saved = contacts[i].order;
                System.Console.WriteLine(contacts[i].name + " removed.");
                System.Console.WriteLine(contacts[i].email + " removed.");
                System.Console.WriteLine(contacts[i].number + " removed.");
                contacts.RemoveAt(i);
                break;

            }
        }

        // If the order is found and we successfully remove it, we adjust the entire order list by minus 1.
        // This will let us do edit by orders and count users correctly.
        if(found == true)
        {
            for(int i = 0; i < contacts.Count; i++)
            {
                //remove 3, if order is 4, go down.
                // if order is 3, go down.
                if(contacts[i].order >= order_saved)
                    contacts[i].order--;
            }
            return true;
        }
        else if(found == false)
        {
            System.Console.WriteLine(name + " is not found in the Contact List...");
            return found;
        }
    return false;

    }

    // Function for editing the contact found through name search.
    public void search_edit_Contact(int flag, string name)
    {
        int index = 0;
        string input;
        for(int i = 0; i < contacts.Count; i++)
        {
            // ToLower is used so that the search is case insensitive and lets the program accept examples like:
            // bEa == bea, true
            // BEa == bea, true
            if(contacts[i].name.ToLower() == name.ToLower())
            {
                //this will store the index of the name that we want
                index = i;
            }
        }

        
        if(flag == 1)
        {
            //Editting email address
            System.Console.Write("\nInput new email address: ");
            input = System.Console.ReadLine();
                if(input == "0"){
                    return;
                }
            // Line below will let us edit the email of the found index.
            contacts[index].email = input;
        }
        else if(flag == 2)
        {
            //editting number
            System.Console.Write("\nInput new number: ");
            input = System.Console.ReadLine();
                if(input == "0"){
                    return;
                }
            contacts[index].number = input;
        }
        else
        {
            System.Console.WriteLine("Wrong data choice.");
        }
    }

    // Function for searching using the user's order.
    public void order_search_Contact(int index)
    {
        int new_index = 0;

        for(int i = 0; i < contacts.Count; i++)
        {
            // We add +1 to the index in order to accurately point at the order.
            // An index of 0 will then return 0+1 = 1 which will point at the user with the order: 1.
            if(contacts[i].order == index+1)
            {
                new_index = i;
                break;
            }
        }

        System.Console.WriteLine(contacts[new_index].name + " contact found.");
        System.Console.WriteLine("\nEditting..." + contacts[new_index].name);
        System.Console.WriteLine("\n");
        System.Console.WriteLine(contacts[new_index].name + " contact found.");
        System.Console.WriteLine("Contact Name: " + contacts[new_index].name);
        System.Console.WriteLine("1. Email: " + contacts[new_index].email);
        System.Console.WriteLine("2. Number: " + contacts[new_index].number);
        System.Console.WriteLine("3. Exit" );
    }


    
    public void order_edit_Contact(int index, int flag)
    {
        string input;      
        int new_index = 0;
        
        for(int i = 0; i < contacts.Count; i++)
        {
            // We add +1 to the index in order to accurately point at the order.
            // An index of 0 will then return 0+1 = 1 which will point at the user with the order: 1.
            if(contacts[i].order == index+1)
            {
                new_index = i;
                break;
            }
        }

        if(flag == 1)
        {
            //Editting email address
            System.Console.Write("\nInput new email address: ");
            input = System.Console.ReadLine();
                if(input == "0"){
                    return;
                }
            contacts[new_index].email = input;
        }
        else if(flag == 2)
        {
            //editting number
            System.Console.Write("\nInput new number: ");
            input = System.Console.ReadLine();
                if(input == "0"){
                    return;
                }
            contacts[new_index].number = input;
        }
        else
        {
            System.Console.WriteLine("Wrong data choice.");
        }

    }

    // Function for switching orders.
    public void switch_orders(int order_one, int order_two)
    {
        int index_one = 0;
        int index_two = 0;

        // We add +1 to the index in order to accurately point at the order.
        // An index of 0 will then return 0+1 = 1 which will point at the user with the order: 1.
        
        //find the first order.
        for(int i = 0; i < contacts.Count; i++)
        {
            if(contacts[i].order == order_one+1)
            {
                index_one = i;
                break;
            }
        }

        //find the second order.
        for(int i = 0; i < contacts.Count; i++)
        {
            if(contacts[i].order == order_two+1)
            {
                index_two = i;
                break;
            }
        }

        contacts[index_one].order = order_two+1;
        contacts[index_two].order = order_one+1;


    }
}
