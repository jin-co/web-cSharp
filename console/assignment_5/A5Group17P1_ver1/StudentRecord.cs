using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace A5Group17P1
{
    public class StudentRecord
    {
        private string name = "";
        private string age = "";
        private string address = "";

        public StudentRecord()
        {
        }

        public StudentRecord(string name, string age, string address)
        {
            this.name = name;
            this.age = age;
            this.address = address;
        }

        public string Name
        {
            return CallConvThiscall.n;
        }
        public string DisplayStudentInformation()
        {
            return name + ", " + age + ", " + address;
        }

        public void EditStudentInformation(string name1, string age1, string address1)
        {
            name = name1;
            age = age1;
            address = address1;
        }

        public void DisplayInformation()
        {
            throw new NotImplementedException();
        }

        public string GetName()
        {
            throw new NotImplementedException();
        }
    }
}
