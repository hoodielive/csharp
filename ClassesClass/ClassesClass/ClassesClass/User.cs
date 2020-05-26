using System;

namespace ClassesClass
{
    public class User
    { 
        string _firstName = "King";
        public string Firstname
        {
            get
            {
                return _firstName;
            }
            set
            {
               _firstName = value.ToLower();
            }
        }
        public string Lastname { get; set; }

        public string Output(int times)
        {
            string message = "";
            for (int i = 0; i < times; i++)
            {
                message += Firstname + " " + Lastname + "\n";
            }

            return message;
        }
    }
}

