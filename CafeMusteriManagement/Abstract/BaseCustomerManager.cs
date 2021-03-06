using System;
using System.Collections.Generic;
using System.Text;
using CafeMusteriManagement.Entities;

namespace CafeMusteriManagement.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Saved to db. "+ customer.FistName);
        }
    }
}
