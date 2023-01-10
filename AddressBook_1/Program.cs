using AddressBook_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Wellcome to Address Book program");
            Addressbook Add = new Addressbook("Mahesh", "H", "KGF", "kolar", "Karnataka", "mahesh@gmail.com", 56434, 7829303710);
            Add.DisplayContect();

        }
    }
}