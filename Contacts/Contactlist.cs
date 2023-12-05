using System.Collections.Generic;
using System.Data.Common;
using System.Linq;

public class Contactlist{
    private List<Contact> contacts;


    public Contactlist()
    {
        contacts = new List<Contact>();
    }

    public void add_name(string name, int order)
    {
        contacts.Add(new Contact(name, order));
    }


    public void display_Contacts()
    {
        System.Console.WriteLine("List of names: ");
        foreach(Contact item in contacts)
        {
            System.Console.WriteLine("Name: " + item.name + "\t" + item.order);
        }
        System.Console.WriteLine("\n");
    }


    public void search_Contacts(string name)
    {
        // Contact find;
        // find = contacts.Find(x => x.name == name);
        // if(find == null)
        // {
        //     System.Console.WriteLine("No user.");
        // }
        // else{
        //     System.Console.WriteLine(find.name + " contact found.");
        // }
        // string found = contacts[1].name;
        
        for(int i = 0; i < contacts.Count; i++)
        {
            if(contacts[i].name == name)
            {
                System.Console.WriteLine(contacts[i].name + " contact found.");
            }
        }

        
    }

    public void sort_Contacts_name()
    {
        //linq
        contacts = contacts.OrderBy(x => x.name).ToList();
    }

        public void sort_Contacts_id()
    {
        //linq
        contacts = contacts.OrderBy(x => x.order).ToList();
    }


}