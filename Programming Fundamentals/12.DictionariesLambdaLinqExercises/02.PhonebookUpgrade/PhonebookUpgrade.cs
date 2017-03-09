using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Phonebook
{
    class Phonebook
    {
        public static SortedDictionary<string, string> phoneBook = new SortedDictionary<string, string>();

        static void Main(string[] args)
        {
            string[] command = Console.ReadLine().Split();

            while (command[0] != "END")
            {
                switch (command[0])
                {
                    case "ListAll":
                        PrintAllContacts();
                        break;
                    case "A":
                        AddContact(command[1], command[2]);
                        break;
                    case "S":
                        SearchInContacts(command[1]);
                        break;
                }

                command = Console.ReadLine().Split();

                Console.WriteLine();
            }
        }

        private static void PrintAllContacts()
        {
            foreach (var item in phoneBook)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }

        private static void SearchInContacts(string name)
        {
            if (phoneBook.ContainsKey(name))
            {
                Console.WriteLine($" -> {phoneBook[name]}");
                return;
            }

            Console.WriteLine($"Contact {name} does not exist.");
        }

        private static void AddContact(string name, string phoneNumber)
        {
            if (!phoneBook.ContainsKey(name))
            {
                phoneBook.Add(name, phoneNumber);
                return;
            }

            phoneBook[name] = phoneNumber;
        }
    }
}
