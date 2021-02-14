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
            if (customer.TcNo=="22222222222" && customer.FirstName=="Kübra" && customer.LastName=="Kılıç" && customer.BirtOfYear==1997 )
            {
                return true;
            }
            return false;
        }
    }
}
