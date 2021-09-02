using System;
using CafeMusteriManagement.Abstract;
using CafeMusteriManagement.Adapters;
using CafeMusteriManagement.Concrete;
using CafeMusteriManagement.Entities;

namespace CafeMusteriManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer
            {
                DateOfBirth = new DateTime(1999,8,4),
                FistName = "Furkan",
                LastName = "KORKMAZGÖZ",
                NationalityId = "11111111111"
            });
        }
    }
}
