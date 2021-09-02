using System;
using System.Collections.Generic;
using System.Text;
using CafeMusteriManagement.Entities;

namespace CafeMusteriManagement.Abstract
{
    public interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
