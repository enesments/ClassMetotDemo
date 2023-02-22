using System;
using System.ComponentModel;
using System.Reflection;

namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Gender = "Erkek";
            customer1.FirstName = "Salih";
            customer1.LastName = "Satın";
            customer1.ID = 14;
            Customer customer2 = new Customer();
            customer2.Gender = "Kadın";
            customer2.FirstName = "Ayse";
            customer2.LastName = "Gül";
            customer2.ID = 13;
            Customer customer3 = new Customer();
            customer3.Gender = "Kadın";
            customer3.FirstName = "Aysel";
            customer3.LastName = "Tepeci";
            customer3.ID = 23;

            Customer[] customer = new Customer[] { customer1, customer2, customer3 };

            foreach (var customers in customer)
            {
                Console.WriteLine("ID= " + customers.ID);
                Console.WriteLine("Name= " + customers.FirstName);
                Console.WriteLine("Surname= " + customers.LastName);
                Console.WriteLine("Gender= " + customers.Gender);
            }

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2); 
            customerManager.Add(customer3);

            customerManager.Listed("Salih", "Satın", "Erkek", 14);
            customerManager.Listed("Ayse", "Gül", "Kadın", 13);
            customerManager.Listed("Aysel", "Tepeci", "Kadın", 23);
            customerManager.Del(customer1);
            customerManager.Del(customer2);
            customerManager.Del(customer3);

            customer1.ID = 25;
            customer1.FirstName = "Ahmet";
            customer1.LastName = "Baklavacı";
            customer1.Gender = "Erkek";
            customerManager.Update(customer1);


        }
    }
}
