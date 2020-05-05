using System;

namespace ClassesClass
{
    public class User
    {
        public string Firstname { get; set; }
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