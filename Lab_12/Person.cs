using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12
{
    class Person
    {
        private string name;
        private string address;
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public string Address
        {
            set { address = value; }
            get { return address; }
        }
        public Person(string _name,string _address)
        {
            name = _name;
            address = _address;
        }
        public virtual string ToString()
        {
           return $"Persson name={name},address={address}";


        }
    }
}
