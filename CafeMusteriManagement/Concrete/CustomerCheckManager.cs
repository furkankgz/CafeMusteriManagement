using System;
using System.Collections.Generic;
using System.Text;
using CafeMusteriManagement.Abstract;
using CafeMusteriManagement.Entities;

namespace CafeMusteriManagement.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
