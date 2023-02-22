using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Müşteri Eklendi. " + customer.ID+" " + customer.FirstName+" " + customer.LastName+" " + customer.Gender);
        }
        public void Del(Customer customer)
        {
            Console.WriteLine("Müşteri Silindi. " + customer.ID + " " + customer.FirstName + " " + customer.LastName + " " + customer.Gender);
        }
        public void Listed(string FirstName, string LastName, string Gender, int ID)
        {
            Console.WriteLine("ID= " + ID);
            Console.WriteLine("FirstName= " + FirstName);
            Console.WriteLine("Lastname= " + LastName);
            Console.WriteLine("Gender = " + Gender);
        }
        public void Update(params Customer[] customer)
        {
            foreach (var customers in customer)
            {
                Console.WriteLine("");
                Console.WriteLine("ID = " + customers.ID);
                Console.WriteLine("FirstName = " + customers.FirstName);
                Console.WriteLine("LastName = " + customers.LastName);
                Console.WriteLine("Gender = " + customers.Gender);
                Console.WriteLine("Customer is Updated....!");


            }

        }
    }
}
