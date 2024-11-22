using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PB_503_OOPTask
{
    public class User : IAccount
    {
        private string _password;
        private static int _count;
        public int Id { get; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password
        {
            get => _password;
            set
            {

                if (PasswordChecker(value))
                {
                    _password = value;
                }
                else { Console.WriteLine("Password is not true"); }
            }
        }


        public User(string email, string fullname, string password)
        {
            _count++;
            Id = _count;
            Email = email;
            FullName = fullname;
            Password = password;
        }

        public bool PasswordChecker(string password)
        {
            if (string.IsNullOrEmpty(password) || password.Length < 8)
                return false;

            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsUpper(password[i]))
                {
                    for (int j = 0; j < password.Length; j++)
                    {
                        if (char.IsLower(password[j]))
                        {
                            for (int k = 0; k < password.Length; k++)
                            {
                                if (char.IsDigit(password[k]))
                                {
                                    return true;
                                }
                            }
                        }
                    }
                }
            }
            return false;

        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Id:{Id},  Fullname:{FullName},  Email:{Email}");
        }
    }
}
