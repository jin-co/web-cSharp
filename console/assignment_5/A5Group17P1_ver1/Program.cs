using System;


namespace A5Group17P1
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentSize = 0, whileCheck = 0;
            string optionInput = "";
            string inputName, inputAge, inputAddress, recordCheck;
            bool mainGoOn = true, optionGoOn = true, optionStop = false, nameCheck = false;
            var studentArray = new StudentRecord[studentSize];

            
            
            while (mainGoOn)
            {
                Console.WriteLine("*************** Menu ***************");
                Console.WriteLine("A. Add a new student\nB. Edit an existing student record\n" +
                    "C. Display the student information\nD. Exit the program");
                Console.WriteLine("************************************");
                Console.Write("Choose an option: ");
                optionInput = Console.ReadLine();

                optionGoOn = true;
                if (optionInput == "a" || optionInput == "A")
                {
                    Console.Write("Please enter the number of the students: ");
                    studentSize = int.Parse(Console.ReadLine());
                    while (optionGoOn)
                    {

                        Console.Write("Enter your name: ");
                        inputName = Console.ReadLine();
                        Console.Write("Enter your age: ");
                        inputAge = Console.ReadLine();
                        Console.Write("Enter your address: ");
                        inputAddress = Console.ReadLine();

                        Console.WriteLine(studentSize);
                        Console.WriteLine(whileCheck);

                        if (whileCheck < studentSize)
                        {
                            Console.WriteLine(inputName);
                            for (int i = 0; i < 4; i++)
                            {

                                Console.WriteLine(studentArray[i].Name);
                                Console.WriteLine(inputName);

                                studentArray[whileCheck] = new StudentRecord(inputName, inputAge, inputAddress);
                                Console.WriteLine("Record stored");
                                whileCheck += 1;

                                if (studentArray[i].Name == inputName)
                                {
                                    Console.WriteLine("Record already exists");
                                    nameCheck = false;
                                    break;
                                }

                                else
                                {
                                    nameCheck = true;
                                    break;
                                }
                            }

                            if (nameCheck == true)
                            {
                                studentArray[whileCheck] = new StudentRecord(inputName, inputAge, inputAddress);
                                Console.WriteLine("Record stored");
                                whileCheck += 1;
                            }

                        }

                        else
                        {
                            Console.WriteLine("Record is full");
                            optionGoOn = false;
                        }

                        for (int i = 0; i < studentArray.Length; i++)
                        {
                            Console.WriteLine(studentArray[i].DisplayStudentInformation());
                        }

                        Console.Write("Do you want to stop? (enter 'QUIT'): ");
                        string quitA = Console.ReadLine();
                        if (quitA == "QUIT" || quitA == "quit")
                        {
                            optionGoOn = false;
                        }
                    }

                }

                else if (optionInput == "b" || optionInput == "B")
                {

                }

                else if (optionInput == "c" || optionInput == "C")
                {
                    while (optionGoOn)
                    {
                        for (int i = 0; i < studentArray.Length; i++)
                        {
                            Console.WriteLine(studentArray[i].DisplayStudentInformation());
                        }

                        Console.Write("Please enter to quit: ");
                        string quit = Console.ReadLine();
                        if (quit == "")
                        {
                            optionGoOn = false;
                        }
                    }
                    
                }

                else if (optionInput == "d" || optionInput == "D")
                {
                    mainGoOn = false;
                }

                else
                {
                    throw new ArgumentException("Option out of range");
                }
            }
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
                            if (i.Name() == name)
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

