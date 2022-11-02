using System;

namespace AddressBookSystem
{
    public class AddressBookSystemMain
    {

        //Default Constructor For Print Welcome Message
        public AddressBookSystemMain()
        {
            Console.WriteLine("Welcome to Address Book Program !!!");
        }

        public static void Main(String[] args)
        {

            //Initialize Object
            AddressBookSystemMain obj = new AddressBookSystemMain();

            //Calling Encapsulated Class object
            ContactPerson addressBook = new ContactPerson("DibyaLochan", "Pahi", "Jagdaa", "Rourkela",
                    "Odisha", "769008", "9658427217", "dibyalochan.pahi@gmail.com");

            Console.WriteLine("\n" + addressBook.toString());
        }
    }
}
