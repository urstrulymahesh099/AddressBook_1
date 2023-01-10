using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_1
{

    internal class Addressbook
    {
        public string FirstName, LastName, Address, City, State, email;
        public int Zip;
        public long PhoneNumber;
        public Addressbook(string firstName, string lastName, string address, string city, string state, string Email, int zip, long phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            City = city;
            State = state;
            Email = email;
            Zip = zip;
            PhoneNumber = phoneNumber;
        }
        public void DisplayContect()
        {
            Console.WriteLine("Name:   {0} {1},", FirstName, LastName);
            Console.WriteLine("Adrdess:  {0} ", Address);
            Console.WriteLine("City:  {0}", City);
            Console.WriteLine("State: {0} ", State);
            Console.WriteLine("Email: {0}", email);
            Console.WriteLine("Zip: {0}", Zip);
            Console.WriteLine("PhoneNumber: {0}", PhoneNumber);
        }
    }
}