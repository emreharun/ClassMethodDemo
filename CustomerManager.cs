using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Customer Added: " + customer.Name + " " + customer.Surname);
        }
        public void List(Customer customer)
        {
            Console.WriteLine("Customer List: " + customer.Name + " " +customer.Surname);
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine("Customer Deleted: " + customer.Name + " " + customer.Surname);
        }
    }
}
