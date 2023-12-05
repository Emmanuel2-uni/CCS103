using System.Collections.Generic;

int flag = 1;
string input_user;
int count_user = 1;

Contactlist contacts = new Contactlist();

do{
    System.Console.Write("Enter contact to add: ");
    input_user = System.Console.ReadLine();

    if(input_user == "0"){
        flag = 0;
        break;
    }

    contacts.add_name(input_user, count_user);
    count_user++;

}while(flag == 1);


contacts.display_Contacts();

    System.Console.Write("Enter contact to search: ");
    input_user = System.Console.ReadLine();
    contacts.search_Contacts(input_user);

System.Console.WriteLine("Sort by name: ");
contacts.sort_Contacts_name();
contacts.display_Contacts();


System.Console.WriteLine("Sort by recently added: ");
contacts.sort_Contacts_id();
contacts.display_Contacts();

