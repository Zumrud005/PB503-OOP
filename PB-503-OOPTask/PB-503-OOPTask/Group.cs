using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PB_503_OOPTask
{
    public class Group
    {
        private int _studentlimit;
        public string GroupNo { get; }

        public int StudentLimit
        {
            get => _studentlimit;
            set
            {
                if (value >= 5 && value <= 18)
                {
                    _studentlimit = value;
                }
                else
                {
                    Console.WriteLine("Studentlimit is not true");


                }
            }


        }

        private Student[] students = new Student[0];
        public  Group(string groupno, int studentlimit)
        {
            if (CheckGroupNo(groupno))
            {
                GroupNo = groupno;
            }
            else { Console.WriteLine("GroupNo is not true"); }

            StudentLimit = studentlimit;

        }


        public bool CheckGroupNo(string groupno)
        {
            if (!string.IsNullOrEmpty(groupno) && groupno.Length == 5)
            {

                if (char.IsUpper(groupno[0]) && char.IsUpper(groupno[1]) && char.IsDigit(groupno[2]) && char.IsDigit(groupno[3]) && char.IsDigit(groupno[4]))
                {
                    return true;
                }
            }

            return false;
        }


        public Student[] AddStudent(Student student)
        {

            Array.Resize(ref students, students.Length + 1);
            if (students.Length <= 18)
            {
                students[students.Length - 1] = student;
            }
            else { Console.WriteLine("Array size is not true"); }

            return students;
        }



        public Student GetStudent(int id)
        {
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].Id == id)
                {
                    return students[i];
                }
            }
            return null;
        }

        public Student[] GetAllStudents()
        {
            return students;
        }





    }
}
