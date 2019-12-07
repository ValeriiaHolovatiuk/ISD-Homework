using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_1._5
{
    class Program
    {
        class User
        {
            private string login, name, lastName;
            DateTime dateOfCreation;
            private int age;
            bool isCreate = false;

            public User()
            {
                if(isCreate != true)
                {
                    dateOfCreation = DateTime.Now;
                }
                else
                {
                    Console.WriteLine("Already created.");
                }
            }

            public void CreateUserAnket()
            {
                Console.Write("Put your login: ");
                login = Console.ReadLine();

                Console.Write("\nPut your name: ");
                name = Console.ReadLine();

                Console.Write("\nPut your last name: ");
                lastName = Console.ReadLine();

                Console.Write("\nPut your age: ");
                age = Convert.ToInt32(Console.ReadLine());
            }

            public void ShowUserAnket()
            {
                Console.WriteLine("Login: {0}\nName: {1}\nLast name: {2}\nAge: {3}\nDate of creation: {4}", login, name, lastName, age, dateOfCreation.ToString("D"));
            }
        }

        static void Main(string[] args)
        {
            User user = new User();

            user.CreateUserAnket();
            user.ShowUserAnket();
        }
    }
}
