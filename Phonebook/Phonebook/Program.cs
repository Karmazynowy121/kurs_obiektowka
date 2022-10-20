using System;

namespace Phonebook
{
    public class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Hello from the PhoneBook app");

            Console.WriteLine("1 Add contact");
            Console.WriteLine("2 Display contact by number");
            Console.WriteLine("3 Display all contacts");
            Console.WriteLine("4 Search contacts");
            Console.WriteLine("to exit insert 'x'");

            var userInput = Console.ReadLine();

            var phoneBook = new PhoneBook();
            while (true)
            {
                switch (userInput)

                {
                    case "1":
                        Console.WriteLine("Insert Number" );
                        var number = Console.ReadLine();
                        Console.WriteLine("Insert Name");
                        var name = Console.ReadLine();

                        var newContact = new Contact(name, number);

                        phoneBook.AddContact(newContact);
                        break;
                    case "2":
                        Console.WriteLine("Insert Number");
                        var NumberToSearch = Console.ReadLine();

                        break;
                    case "3":
                        phoneBook.DisplayAllContacts();
                        break;
                    case "4":
                        Console.WriteLine("Insert search phrase");
                        var searchPhrase = Console.ReadLine();

                        phoneBook.DisplayMatchingContacts(searchPhrase);
                        break;
                    case "x":
                        return;
                    default:
                        Console.WriteLine("Invalid operation");
                        break;

                }
                Console.WriteLine("Select Operation");
                userInput = Console.ReadLine();


            }
           
        }
    }
}
