using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class AddressBookRepo
    {
        static string connectionString = @"Data Source=PRIYANSHU\SPARTA;Integrated Security=True;Connect Timeout=30; Database=AddressBook";

        SqlConnection connection = new SqlConnection(connectionString);

        public void AddContacts()
        {
            AddressBook contact = new AddressBook();
            try
            {
                Console.WriteLine("Enter Contact Details");
                Console.Write("Enter First Name: ");
                contact.firstName = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Enter Last Name: ");
                contact.lastName = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Enter city Name: ");
                contact.city = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Enter phone number: ");
                contact.phoneNumber = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Enter state: ");
                contact.state= Console.ReadLine();
                Console.WriteLine();
                Console.Write("Enter Zip code: ");
                contact.zipcode = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Enter Email");
                contact.email = Console.ReadLine();

                string query = $"insert into contacts(FirstName,LastName,phoneNumber,city,state,zip,email) values({contact.firstName},{contact.lastName},{contact.phoneNumber},{contact.city},{contact.state},{contact.zipcode},{contact.email});";

                SqlCommand cmd = new SqlCommand(query,this.connection);

                this.connection.Open();
                cmd.ExecuteNonQuery();
                
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { connection.Close(); }
        }

    }
}
