using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Adapters
{
    public class CustomerControlManagerAdapter : ICustomerControlService
    {
        
        public bool CheckIfRealPerson(Customer customer)
        {
            if (customer.TcNo=="12345678901" && customer.FirstName=="Bulut" && customer.LastName=="Çalışkan" && customer.BirthOfYear==2007 )
            {
                return true;
            }
            return false;
        }
    }
}
