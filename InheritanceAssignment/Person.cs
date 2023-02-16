using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAssignment
{
    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public double Phone { get; set; }
        public Person( int id,string name, string address, double phone)
        {
            this.Id = id;
            this.Name = name;
            this.Address = address;
            this.Phone = phone;
        }
        public virtual void Details()
        {
            Console.WriteLine("Id :" + Id);
            Console.WriteLine("Name :" + Name);
            Console.WriteLine("Address :" + Address);
            Console.WriteLine("Phone Number  :" + Phone);
        }
    }
}
