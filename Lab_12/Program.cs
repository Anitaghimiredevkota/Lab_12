using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Person newPerson = new Person("Anita", "30259 macintosh lane");
            Console.WriteLine(newPerson.ToString());
            Student newStudent = new Student("C#", 2019, 8500, "Anita", "30259 macintosh lane");
            Console.WriteLine(newStudent.ToString());
            Staff newStaff = new Staff("Grand Circus", 8000, "Anita", "30259 macintosh lane");
            Console.WriteLine(newStaff.ToString());
        }
    }
}
