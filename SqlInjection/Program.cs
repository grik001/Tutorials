using SqlInjection.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlInjection
{
    class Program
    {
        public static List<User> users = new List<User>()
        {
            new User() { Email = "123@test.com", Name = "Peter", Surname = "Borg", Username = "PB" },
            new User() { Email = "abc@test.com", Name = "Harvey", Surname = "Ross", Username = "AG" },
            new User() { Email = "gre@test.com", Name = "Paul", Surname = "Peterson", Username = "EF" },
            new User() { Email = "pqw@test.com", Name = "Louis", Surname = "Frederick", Username = "GF" },
            new User() { Email = "bfa@test.com", Name = "Mike", Surname = "Jenkins", Username = "QF" },
            new User() { Email = "eee@test.com", Name = "Ron", Surname = "Paul", Username = "LG" },
        };

        public static List<Product> products = new List<Product>()
        {
            new Product() { Name = "Book", Price = 10 },
            new Product() { Name = "Car", Price = 12},
            new Product() { Name = "Ball", Price = 14 },
            new Product() { Name = "Console", Price = 15 },
            new Product() { Name = "Bag", Price = 30 },
            new Product() { Name = "Hat", Price = 20 },
        };

        static void Main(string[] args)
        {
            var dbLocation = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Keith\Documents\Development-Git\Tutorials\SqlInjection\TestDatabase.mdf;Integrated Security=True";
            SqlConnection connection;

            using (connection = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={dbLocation};Integrated Security=True"))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("TRUNCATE TABLE [User]", connection))
                {
                    command.ExecuteNonQuery();
                }

                using (SqlCommand command = new SqlCommand("TRUNCATE TABLE [Product]", connection))
                {
                    command.ExecuteNonQuery();
                }

                foreach (var u in users)
                {
                    using (SqlCommand command = new SqlCommand($"INSERT INTO [User] (Name, Surname, Email, Username) Values ('{u.Name}', '{u.Surname}', '{u.Email}', '{u.Username}')", connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }

                foreach (var p in products)
                {
                    using (SqlCommand command = new SqlCommand($"INSERT INTO [Product] (Name, Price) Values ('{p.Name}', '{p.Price}')", connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }

                do
                {
                    Console.WriteLine("Search Product: ");
                    var product = Console.ReadLine();

                    using (connection = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={dbLocation};Integrated Security=True"))
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand($"SELECT * FROM Product WHERE Name LIKE '%{product}%'", connection))
                        {
                            SqlDataReader reader = command.ExecuteReader();


                            while (reader.Read())
                            {
                                Console.WriteLine(reader["Name"]);
                            }
                        }
                    }

                } while (true);
            }

            Console.ReadLine();
        }
    }
}
