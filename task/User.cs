using System;
using System.Collections.Generic;
using System.Text;

namespace task
{
    class User
    {

        public string UserName;
        private string _password;
        public User(string name)
        {
            if (name.Length > 5 && name.Length < 26)
            {
                this.UserName = name;
            }
        }
        public string Password
        {
            get => _password;
            set
            {
                if (value.Length > 7 && value.Length < 26 && HasDigit(value) && HasUpper(value) && HasLower(value))
                {
                    _password = value;
                }
            }
        }

        public bool HasDigit(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (!string.IsNullOrEmpty(str) && char.IsDigit(str[i]))
                {
                    return true;
                }
            }
            return false;
        }

        public bool HasUpper(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (!string.IsNullOrEmpty(str) && char.IsUpper(str[i]))
                {
                    return true;
                }
            }
            return false;
        }

        public bool HasLower(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (!string.IsNullOrEmpty(str) && char.IsLower(str[i]))
                {
                    return true;
                }
            }
            return false;
        }


    }
}
