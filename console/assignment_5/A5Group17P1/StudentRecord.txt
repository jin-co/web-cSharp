using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace A5Group17P1
{
    // Class for the student records
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

        public string GetName()
        {
            return name;
        }
        public string DisplayStudentInformation()
        {
            return name + ", " + age + ", " + address;
        }

        public void EditStudentInformation(string name, string age, string address)
        {
            this.name = name;
            this.age = age;
            this.address = address;
        }
    }
}
