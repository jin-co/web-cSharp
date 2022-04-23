using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A5Group17P1
{
    class StudentRecord
    {
        private string name, age, address;

        public StudentRecord()
        {
        }

        public StudentRecord(string name1, string age1, string address1)
        {
            name = name1;
            age = age1;
            address = address1;
        }

        public string GetName()
        {
            return name;
        }

        public void DisplayInformation()
        {
            Console.WriteLine(name + ", age " + age + ", " + address);
        }

        public void EditInformation(string name1, string age1, string address1)
        {
            name = name1;
            age = age1;
            address = address1;
        }
    }
}
