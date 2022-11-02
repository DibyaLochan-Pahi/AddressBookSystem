using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookSystem
{
    public class ContactPerson
    {
        //Declaring variables for Address Book System

        private String firstName;
        private String lastName;
        private String address;
        private String city;
        private String state;
        private String zip;
        private String phoneNumber;
        private String email;

        //Declaring a parameterized constructor by means of which we can set up the values for instance variables above.
        public ContactPerson(String firstName, String lastName, String address, String city, String state, String zip, String phoneNumber, String email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.phoneNumber = phoneNumber;
            this.email = email;
        }


        //Creating toString methods to grab the values.
        //Override
        public String toString()
        {
            return "\n AddressBook" +
                   "\n ------------" +
                    "\n FirstName=" + firstName +
                    "\n LastName=" + lastName +
                    "\n Address=" + address +
                    "\n City=" + city +
                    "\n State=" + state +
                    "\n Zip=" + zip +
                    "\n PhoneNumber=" + phoneNumber +
                    "\n Email=" + email;

        }

    }
}
