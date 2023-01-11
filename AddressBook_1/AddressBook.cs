﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_1
{
    public class Addressbook : Icontact
    {
        public Dictionary<string, Contacts> addressbook = new Dictionary<string, Contacts>();
        public Dictionary<string, Addressbook> addressBookDic = new Dictionary<string, Addressbook>();



        public void CreateContact(string firstName, string lastName, string address, string city, string state, string Email, int zip, long phoneNumber, string BookName)
        {
            Contacts co = new Contacts();
            co.FirstName = firstName;
            co.LastName = lastName;
            co.Address = address;
            co.City = city;
            co.State = state;
            co.Email = Email;
            co.Zip = zip;
            co.PhoneNumber = phoneNumber;
            addressBookDic[BookName].addressbook.Add(co.FirstName, co);
            Console.WriteLine("Added succsesfully");
        }
        public void ViewContact(string name, string BookName)
        {
            foreach (KeyValuePair<string, Contacts> item in addressBookDic[BookName].addressbook)
            {
                if (item.Key.ToLower().Equals(name.ToLower()))
                {
                    Console.WriteLine("FirstName;" + item.Value.FirstName);
                    Console.WriteLine("LastName;" + item.Value.LastName);
                    Console.WriteLine("Address;" + item.Value.Address);
                    Console.WriteLine("City;" + item.Value.City);
                    Console.WriteLine("State;" + item.Value.State);
                    Console.WriteLine("Zip;" + item.Value.Zip);
                    Console.WriteLine("Email;" + item.Value.Email);
                    Console.WriteLine("PhoneNumber;" + item.Value.PhoneNumber);
                }
            }
        }
        public void ViewContact(string BookName)
        {
            foreach (KeyValuePair<string, Contacts> item in addressBookDic[BookName].addressbook)
            {
                Console.WriteLine("FirstName;" + item.Value.FirstName);
                Console.WriteLine("LastName;" + item.Value.LastName);
                Console.WriteLine("Address;" + item.Value.Address);
                Console.WriteLine("City;" + item.Value.City);
                Console.WriteLine("State;" + item.Value.State);
                Console.WriteLine("Zip;" + item.Value.Zip);
                Console.WriteLine("Email;" + item.Value.Email);
                Console.WriteLine("PhoneNumber;" + item.Value.PhoneNumber);

            }

        }


        public void EditContact(string name, string BookName)
        {
            foreach (KeyValuePair<string, Contacts> item in addressBookDic[BookName].addressbook)
            {
                if (item.Key.Equals(name))
                {
                    Console.WriteLine("Enter Field ToBE Modify\n1.FirstNmae\n2.LastName\n3.Address\n4.City\n5.State\n6.Zip\n7.Email\n8.PhoneNUmber");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Enter the Modifed Value");
                            string FName = Console.ReadLine();
                            item.Value.FirstName = FName;
                            break;
                        case 2:
                            Console.WriteLine("Enter the Modifed Value");
                            string LName = Console.ReadLine();
                            item.Value.LastName = LName;
                            break;
                        case 3:
                            Console.WriteLine("Enter the Modifed Value");
                            string Add = Console.ReadLine();
                            item.Value.Address = Add;
                            break;
                        case 4:
                            Console.WriteLine("Enter the Modifed Value");
                            string city = Console.ReadLine();
                            item.Value.City = city;
                            break;
                        case 5:
                            Console.WriteLine("Enter the Modifed Value");
                            string StateN = Console.ReadLine();
                            item.Value.State = StateN;
                            break;
                        case 6:
                            Console.WriteLine("Enter the Modifed Value");
                            int ZipN = Convert.ToInt32(Console.ReadLine());
                            item.Value.Zip = ZipN;
                            break;
                        case 7:
                            Console.WriteLine("Enter the Modifed Value");
                            string MailID = Console.ReadLine();
                            item.Value.Email = MailID;
                            break;
                        case 8:
                            Console.WriteLine("Enter the Modifed Value");
                            long PhnNum = Convert.ToInt64(Console.ReadLine());
                            item.Value.PhoneNumber = PhnNum;
                            break;
                    }
                    Console.WriteLine("Edited Successfully");
                }

            }

        }
        public void DeleteContact(string name, string BookName)
        {
            if (addressBookDic[BookName].addressbook.ContainsKey(name))
            {
                addressBookDic[BookName].addressbook.Remove(name);
                Console.WriteLine("Deleted Successfully");
            }
            else
            {
                Console.WriteLine("Not found Try Again");
            }
        }
        public void AddAddressBook(string BookName)
        {
            Addressbook book = new Addressbook();
            addressBookDic.Add(BookName, book);
            Console.WriteLine("AddressBook Created");
        }
        public Dictionary<string, Addressbook> GetaddressBook()
        {
            return addressBookDic;
        }
    }
}