using System;
using System.Collections.Generic;
using System.Text;
using CafeMusteriManagement.Abstract;

namespace CafeMusteriManagement.Entities
{
    public class Customer : IEntity
    {
        public int Id { get; set; }
        public string FistName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string NationalityId { get; set; }
    }
}
