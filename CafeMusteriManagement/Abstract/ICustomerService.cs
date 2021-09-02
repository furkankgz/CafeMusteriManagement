using System;
using System.Collections.Generic;
using System.Text;
using CafeMusteriManagement.Entities;

namespace CafeMusteriManagement.Abstract
{
    public interface ICustomerService
    {
        void Save(Customer customer);
    }
}
