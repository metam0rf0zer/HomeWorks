using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Task_10_1.Models
{
    internal class AuthModel
    {
        public const string ValidUsername = "admin";
        public const string ValidPassword = "12345";

        public static bool Authenticate(string username, string password)
        {
            return username == ValidUsername && password == ValidPassword;
        }
    }
}
