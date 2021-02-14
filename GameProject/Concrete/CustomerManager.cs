using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerControlService _customerControlService; //Kontrol Servisi

        public CustomerManager(ICustomerControlService customerControlService)
        {
            _customerControlService = customerControlService;
        }

        public void Add(Customer customer)
        {
            if (_customerControlService.CheckIfRealPerson(customer))
            {
                Console.WriteLine("Customer: {0} added.", customer.FirstName);
            }
            else
            {
                Console.WriteLine("Invalid person.");
            }
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Customer: {0} deleted.", customer.FirstName);
        }

        public void Update(Customer customer)
        {
            Console.WriteLine("Customer: {0} updated.", customer.FirstName);
        }
    }
}
