using System;
using System.ComponentModel.Design;


namespace A5Group17P1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Josslyne Shants <Jshantz8979@conestogac.on.ca> -> part A, part B, student record class, editing, reviewing & testing
               Kwangjin Baek <Kbaek7943@conestogac.on.ca> -> main menu, part C, error handling, editing, reviewing & testing */

            // This application allows users to create, edit and see students record

            int studentSize = 0;
            string optionInput = "";
            bool mainGoOn = true, sizeTypeError = true;

            do
            {
                try
                {
                    // gets the size of the total record
                    Console.Write("Enter the number students that are going to be in the database: ");
                    studentSize = int.Parse(Console.ReadLine());
                    sizeTypeError = false;
                }

                catch (FormatException e)
                {
                    Console.WriteLine(e);
                }

                catch (ArgumentNullException e)
                {
                    Console.WriteLine(e);
                }

                catch (OverflowException e)
                {
                    Console.WriteLine(e);
                }

                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            } while (sizeTypeError);

            StudentRecord[] studentArray = new StudentRecord[studentSize];

            // Main menu: shows the choices
            while (mainGoOn)
            {
                try
                {
                    Console.WriteLine("*************** Menu ***************");
                    Console.WriteLine("A. Add a new student\nB. Edit an existing student record\n" +
                                      "C. Display the student information\nD. Exit the program");
                    Console.WriteLine("************************************");
                    Console.Write("Choose an option by letter: ");
                    optionInput = Console.ReadLine();
                    if (optionInput == "a" || optionInput == "A")
                    {
                        studentArray = AddStudent(studentArray, studentSize);
                    }

                    else if (optionInput == "b" || optionInput == "B")
                    {
                        studentArray = EditStudent(studentArray);
                    }

                    else if (optionInput == "c" || optionInput == "C")
                    {
                        ShowStudent(studentArray);
                    }

                    else if (optionInput == "d" || optionInput == "D")
                    {
                        Console.WriteLine("Have a great day");
                        mainGoOn = false;
                    }

                    else
                    {
                        throw new ArgumentException("*** Option out of range ***");
                    }
                }

                catch (ArgumentException e)
                {
                    Console.WriteLine(e);
                }
                
                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine(e);
                }
                
                catch (FormatException e)
                {
                    Console.WriteLine(e);
                }
                
                catch (OverflowException e)
                {
                    Console.WriteLine(e);
                }
                
                catch (Exception e)
                {
                    Console.WriteLine((e.Message));
                }
            }
        }
        
        // Option A: creates student records
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
                    Console.Write("\nEnter the name of the student you wish to add. Enter 'QUIT' to go back to the main menu:  ");
                    name = Console.ReadLine();
                    if (name == "QUIT" || name == "quit")
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
                            Console.WriteLine("\nThat student already exists, please enter a different student.");
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
                    Console.WriteLine("\nThe database is full. You have already entered all the students you said there would be.");
                    Console.WriteLine("You can edit students but you can not add anymore students here.\n");
                    end = true;
                }

            } while (end == false);

            return students;
        }

        // Option B: makes adjustment to existing records
        static StudentRecord[] EditStudent(StudentRecord[] students)
        {
            string name, age, address;
            int studentIndex = -1, index = 0;
            Console.Write("\nEnter the name of the student you wish to edit: ");
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

                else
                {
                    throw new Exception("\n*** No data exists ***");
                }
                index++;
            }

            if (studentIndex == -1)
            {
                Console.WriteLine("** *No student record exists. ***");
            }

            else
            {
                index = -1;
                Console.WriteLine("\nThe student record does exist.\nThis is the current student record.\n");
                students[studentIndex].DisplayStudentInformation();
                Console.WriteLine("\nPlease enter the updated information.");
                Console.Write("\nEnter the name of the student you wish to add.\n(Enter 'QUIT' to go back to the main menu): ");
                name = Console.ReadLine();
                if (name == "QUIT" || name == "quit")
                {
                    return students;
                }
                
                else
                {
                    Console.Write("\nEnter the students age: ");
                    age = Console.ReadLine();
                    Console.Write("\nEnter the students address: ");
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
                        Console.WriteLine("\n*** That student already exists. ***");
                    }
                   
                    else
                    {
                        students[studentIndex] = new StudentRecord(name, age, address);
                        Console.WriteLine("\n*** Student record has been updated. ***\n");
                    }
                }
            }
            return students;
        }

        // Option C: shows a student' record
        static StudentRecord[] ShowStudent(StudentRecord[] students)
        {
            int studentIndex = -1, index = 0;
            string name;
            bool end = true;
            do
            {
                Console.Write("\nEnter the name of the student to see the record\n(Enter 'QUIT' to go back to the main menu): ");
                name = Console.ReadLine();
                index = 0;
                if (name == "QUIT" || name == "quit")
                {
                    Console.WriteLine("");
                    end = false;
                    break;
                }

                foreach (StudentRecord i in students)
                {

                    if (i != null)
                    {
                        if (name == i.GetName())
                        {
                            studentIndex = index;
                        }
                    }

                    else
                    {
                        throw new Exception("\n*** No data exists ***\n");
                    }
                    index++;
                }

                if (studentIndex != -1)
                {
                    Console.WriteLine("\n******* Result *******");
                    Console.WriteLine((students[studentIndex].DisplayStudentInformation()));
                    end = false;
                    Console.WriteLine("\nPlease press any key to go back to the main: ");
                    Console.ReadKey();
                    Console.WriteLine("");
                }

                else
                {
                    Console.WriteLine("\nRecord does not exist\nPlease enter again");
                }

            } while (end);

            return students;
        }
    }
}

