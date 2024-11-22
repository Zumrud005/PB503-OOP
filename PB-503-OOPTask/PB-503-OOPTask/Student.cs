using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PB_503_OOPTask
{
    public class Student :User
    {
       
        public double Point { get; set; }
        private int _id;



        public Student(string email, string fullname, string password, double point) : base(email, fullname, password)
        {
            
            Point = point;
        }

        
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Point: {Point}, Passsword: {Password}");
        }

        public void StudentInfo()
        {
            ShowInfo();
        }

    }
}
