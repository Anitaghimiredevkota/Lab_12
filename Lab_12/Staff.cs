using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12
{
    class Staff:Person
    {
        private string school;
        private double pay;
        public string School
        {
            set { school = value; }
            get { return school; }
        }
        public double Pay
        {
            set { pay = value; }
            get { return pay; }
        }
        public Staff(string _school,double _pay, string _name, string _address):base(_name,_address)
        {
            school = _school;
            pay = _pay;
        }
        public override string ToString()
        {
            return $"Staff Person name={Name}, address={Address}, school={school}, pay={pay}";
        }
    }
}
