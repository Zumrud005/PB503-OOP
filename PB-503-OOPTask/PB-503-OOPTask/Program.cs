using System.Reflection.Metadata;

namespace PB_503_OOPTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the new user values");
            Console.WriteLine("1-User email:");
            string email = Console.ReadLine();
            Console.WriteLine("2-User's fullname");                                          
            string fullName = Console.ReadLine();
            Console.WriteLine("3-User password");
            string password = Console.ReadLine();



            User user = new User(email, fullName, password);
            if (user.PasswordChecker(password))
            {


                Console.WriteLine("User has been created");
            }
            else
            {
                while (!user.PasswordChecker(password))
                {
                    Console.WriteLine("try again password...");
                    password = Console.ReadLine();

                }
                Console.WriteLine("User has been created");
            }

            Console.WriteLine("Please add student point:");
            double point = double.Parse(Console.ReadLine());
            Student student1 = new Student(user.Email,user.FullName,user.Password,point);
            


            Console.WriteLine("Please choose a process ");
            Console.WriteLine("1- Show datas for user ");
            Console.WriteLine("2- Create a new group");
            int count;

            do
            {
                count = int.Parse(Console.ReadLine());
                switch (count)
                {
                    case 1:
                        user.ShowInfo();
                        break;
                    case 2:
                        Console.WriteLine("Plase add gropu no and student limit");
                        Console.WriteLine("GroupNo:");
                        string groupNo = Console.ReadLine();
                        
                        Console.WriteLine("Student limit:");
                        int studentLimit = int.Parse(Console.ReadLine());
                        Group group = new Group(groupNo, studentLimit);

                        Console.WriteLine("Group has been created");
                        group.AddStudent(student1);

                        int input;

                        Console.WriteLine("Please choose group process");
                        Console.WriteLine("1- Show all students");
                        Console.WriteLine("2-Get student by id");
                        Console.WriteLine("3-Add students");
                        Console.WriteLine("0-Quit");

                        do
                        {
                            input = int.Parse(Console.ReadLine());
                            switch (input)
                            {
                                case 1:
                                    foreach (var students in group.GetAllStudents())
                                    {
                                        students.StudentInfo();
                                    }

                                    break;

                                case 2:

                                    Console.WriteLine("Please enter id:");
                                    int id = int.Parse(Console.ReadLine());
                                    Student newstudent = group.GetStudent(id);
                                    if (newstudent != null)
                                    {
                                        newstudent.StudentInfo();
                                    }
                                    else { Console.WriteLine("Student not found"); }

                            
                                    

                                    break;

                                case 3:
                                    Console.WriteLine("Please enter new student value");
                                    Console.WriteLine("Student email:");
                                    string emailStudent = Console.ReadLine();
                                    Console.WriteLine("Student fullname:");
                                    string fullnameStudent= Console.ReadLine();
                                    Console.WriteLine("Student password:");
                                    string passwordStudent= Console.ReadLine();
                                    Console.WriteLine("Student point");
                                    double pointStudent = double.Parse(Console.ReadLine());

                                    Student student= new Student(emailStudent, fullnameStudent, passwordStudent, pointStudent);
                                    group.AddStudent(student);
                                    Console.WriteLine("New student has been added...");
                                    break;
                                case 0: 
                                    Console.WriteLine("the process is finished");
                                    break;
                                default: 
                                    Console.WriteLine("lease choose correct process");
                                    break;
                            }
                        } while (input != 0);

                        break;
                    default:
                        Console.WriteLine("Please choose correct process");
                        break;
                }
            } while (count != 3);
        }

    }
}




                                    

























