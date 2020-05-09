using System; 
using System.Collections.Generic;

namespace Onibode
{
    public class User
    {
        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}