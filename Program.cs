using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Name = "A";
            customer1.Surname = "B";
            customer1.Id = 1;

            Customer customer2 = new Customer();
            customer2.Name = "C";
            customer2.Surname = "D";
            customer2.Id = 2;

            CustomerManager customerManager = new CustomerManager();
            Console.WriteLine("ADDED");
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            Console.WriteLine("DELETED");
            customerManager.Delete(customer1);
            customerManager.Delete(customer2);
            Console.WriteLine("LIST");
            customerManager.List(customer1);
            customerManager.List(customer2);

        }
    }
}
