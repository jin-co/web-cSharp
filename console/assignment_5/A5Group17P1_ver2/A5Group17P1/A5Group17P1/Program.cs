using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A5Group17P1
{
    class Program
    {
        static void Main()
        {
            

        
        }
        static StudentRecord[] AddStudent(StudentRecord[] students, int totalNumOfStudents)
        {
            int numberOfStudents = 0;
            string name, age, address;
            bool end = false;
            foreach (StudentRecord i in students)
            {
                if (i != null)
                {
                    numberOfStudents++;
                }
            }
            do
            {
                if (numberOfStudents != totalNumOfStudents)
                {
                    int studentIndex = -1;
                    Console.Write("Enter the name of the student you wish to add. Enter 'QUIT' to go back to the main menu:  ");
                    name = Console.ReadLine();
                    if (name == "QUIT")
                    {
                        end = true;
                    }
                    else
                    {
                        Console.Write("Enter the students age: ");
                        age = Console.ReadLine();
                        Console.Write("Enter the students address: ");
                        address = Console.ReadLine();

                        foreach (StudentRecord i in students)
                        {
                            if (i != null)
                            {
                                if (i.GetName() == name)
                                {
                                    studentIndex = 1;
                                }
                            }
                        }

                        if (studentIndex == 1)
                        {
                            Console.WriteLine("That student already exists, please enter a different student.");
                        }
                        else
                        {
                            students[numberOfStudents] = new StudentRecord(name, age, address);
                            Console.WriteLine(name + " is now in the database.");
                            numberOfStudents++;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("The database is full. You have already entered all the students you said there would be.");
                    Console.WriteLine("You can edit students but you can not add anymore students here.");
                    end = true;
                }
            } while (end == false);

            return students;
        }

        static StudentRecord[] EditStudent(StudentRecord[] students)
        {
            string name, age, address;
            int studentIndex = -1, index = 0;
            Console.Write("Enter the name of the student you wish to edit: ");
            name = Console.ReadLine();
            foreach (StudentRecord i in students)
            {
                if (i != null)
                {
                    if (name == i.GetName())
                    {
                        studentIndex = index;
                    }
                }
                index++;
            }
            if (studentIndex == -1)
            {
                Console.WriteLine("No student record exists.");
            }
            else
            {
                index = -1;
                Console.WriteLine("The student record does exist.\nThis is the current student record.\n");
                students[studentIndex].DisplayInformation();
                Console.WriteLine("\nPlease enter the updated information.");
                Console.Write("Enter the name of the student you wish to add. Enter 'QUIT' to go back to the main menu:  ");
                name = Console.ReadLine();
                if (name == "QUIT")
                {
                    return students;
                }
                else
                {
                    Console.Write("Enter the students age: ");
                    age = Console.ReadLine();
                    Console.Write("Enter the students address: ");
                    address = Console.ReadLine();

                    foreach (StudentRecord i in students)
                    {
                        if (i != null)
                        {
                            if (i.GetName() == name)
                            {
                                studentIndex = 1;
                            }
                        }
                    }

                    if (studentIndex == 1)
                    {
                        Console.WriteLine("That student already exists.");
                    }
                    else
                    {
                        students[studentIndex] = new StudentRecord(name, age, address);
                        Console.WriteLine("Student record has been updated.");
                    }
                }
            }
            return students;
        }
    }
}
