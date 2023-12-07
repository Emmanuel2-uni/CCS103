using System.Collections;
using System.Collections.Generic;

//For do-whiles
int flag = 1;
int flag_search = 0;

string input_name;
string input_email;
string input_number;

int count_user = 1;

int choice = 0;

Contactlist contacts = new Contactlist();

do{
    System.Console.Clear();
    
    contacts.display_Contacts();

    System.Console.WriteLine("====== Options ====== ");    
    System.Console.WriteLine("1. Add Contact ");    
    System.Console.WriteLine("2. Remove Contact ");
    System.Console.WriteLine("3. Search Contact ");
    System.Console.WriteLine("4. Edit Contact by Order");
    System.Console.WriteLine("5. Sort Contact - By...");
    System.Console.WriteLine("6. Exit ");

    System.Console.WriteLine("77. Switch Orders ");
    System.Console.Write("\n\nEnter choice: ");
    choice = Convert.ToInt32(System.Console.ReadLine());


    switch(choice){

        //============
        //Add contact
        case 1:
            System.Console.Clear();
            contacts.display_Contacts();
            System.Console.Write("\nEnter name for new contact [0 to cancel]: ");    
            input_name = System.Console.ReadLine();
                if(input_name == "0"){
                    break;
                }

            System.Console.Write("Enter email for new contact [0 to cancel]: ");    
            input_email = System.Console.ReadLine();
                if(input_email == "0"){
                    break;
                }

            System.Console.Write("Enter number for new contact [0 to cancel]: ");    
            input_number = System.Console.ReadLine();
                if(input_number == "0"){
                    break;
                }
            contacts.add_name(input_name, count_user, input_email, input_number);
            count_user++;
            break;


        //============
        //Remove Contact
        case 2:
            bool found_user = false;
            System.Console.Clear();
            contacts.display_Contacts();
            System.Console.Write("\nEnter contact name to delete [0 to cancel]: ");  
            input_name = System.Console.ReadLine();
                if(input_name == "0"){
                    break;
                }
            found_user = contacts.remove_Contacts(input_name);
            if(found_user == true)
                count_user--;
    
            break;
            


        //============
        //Search Contact
        case 3:
            int choice_editsearch = 0;
            int edit_search = 1;
            System.Console.Clear();
            contacts.display_Contacts();
            System.Console.Write("\nEnter contact name to search [0 to cancel]: ");  
            input_name = System.Console.ReadLine();
                if(input_name == "0"){
                    System.Console.WriteLine("Exiting search...");
                    break;
                }
            contacts.search_Contacts(input_name);
            System.Console.Write("\nWould you like to edit " + input_name + "? [1-Yes | 0-No] "); 
            choice_editsearch = Convert.ToInt32(System.Console.ReadLine());
                if(choice_editsearch == 1)
                    choice_editsearch = 1;
                else if(choice_editsearch ==2)
                    break;

            do
            {  
                int choice_data;
                string data_edit;
                System.Console.Clear();
                System.Console.Write("\nEditting " + input_name + "... "); 
                contacts.search_Contacts(input_name);
                System.Console.Write("\nChoose data to edit: ");
                choice_data = Convert.ToInt32(System.Console.ReadLine());
                    if(choice_data == 3)
                    {
                        edit_search = 0;
                        break;
                    }
                contacts.search_edit_Contact(choice_data, input_name);

            }while(edit_search == 1);

        break;


        //============
        //Edit Contact by Order
        case 4:
            int input_order;
            int flag_order = 1;
            int choice_order = 0;
            int edit_order = 0;

            System.Console.Clear();
            contacts.display_Contacts();
            System.Console.Write("\nEnter contact order to edit [0 to cancel]: ");  
            input_order = Convert.ToInt32(System.Console.ReadLine());
                if(input_order == 0){
                    flag_order = 0;
                    break;
                }
                else if(input_order > count_user || input_order <= 0)
                {
                    System.Console.WriteLine("Invalid choice. Returning to main menu...");
                    break;
                }            
            
            //If the input_order is valid, we decrement (reduce by 1) in order to accurately point at the proper index.
            input_order--;

            do
            {
                System.Console.Clear();
                contacts.order_search_Contact(input_order);
                System.Console.Write("\nEnter contact data to edit [0 to cancel]: ");
                edit_order = Convert.ToInt32(System.Console.ReadLine());
                if(edit_order == 3){
                    flag_order = 0;
                    break;
                }  
                contacts.order_edit_Contact(input_order, edit_order);


            }while(flag_order == 1);

        break;


        //============
        //Sort Contact
        case 5:
            int choice_sort = 0;
            System.Console.Clear();
            contacts.display_Contacts();
            System.Console.WriteLine("1. Sort by Order added ");  
            System.Console.WriteLine("2. Sort by Name ");

            System.Console.Write("\nEnter sorting choice: ");  
            choice_sort = Convert.ToInt32(System.Console.ReadLine());
            contacts.sort_Contacts(choice_sort);

            System.Console.WriteLine("Sorting...");
            System.Console.Write("\nPress any key to continue...");
            System.Console.ReadKey();
        break;    



        //============
        //Exit
        case 6:
            flag = 0;
        break;

        //============
        //Switch orders
        case 77:
            System.Console.Clear();
            contacts.display_Contacts();
            int order_one = 0;
            int order_two = 0;
            System.Console.WriteLine("Choose two orders to switch their places. \n");  

            System.Console.Write("Choose first order [0 to exit]: ");  
            order_one = Convert.ToInt32(System.Console.ReadLine());
                if(order_one == 0)
                    break;
            order_one--;
          
            System.Console.Write("Choose second order [0 to exit]: ");  
            order_two = Convert.ToInt32(System.Console.ReadLine());
                if(order_one == 0)
                    break;
            order_two--;


            contacts.switch_orders(order_one, order_two);




        break;

        default:

        break;

    }


}while(flag == 1);

