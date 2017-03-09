using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.FixEmails
{
    class FixEmails
    {
        static void Main(string[] args)
        {
            var contacts = new Dictionary<string, string>();

            while (true)
            {
                string name = Console.ReadLine();

                if (name.Equals("stop")) break;

                string email = Console.ReadLine();

                if (!(email.EndsWith("us") || email.EndsWith("uk")))
                {
                    if (!contacts.ContainsKey(name))
                    {
                        contacts.Add(name, string.Empty);
                    }

                    contacts[name] = email;
                }
                //string domain = email.Substring(email.Length - 2).ToLower();
                //if (!domain.Equals("us") && !domain.Equals("uk"))
                //{
                //    if (!contacts.ContainsKey(name))
                //    {
                //        contacts.Add(name, string.Empty);
                //    }

                //    contacts[name] = email;
                //}
            }

            foreach (var contact in contacts)
            {
                Console.WriteLine($"{contact.Key} -> {contact.Value}");
            }
        }
    }
}
