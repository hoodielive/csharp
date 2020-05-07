namespace Onibode
{
    public class User
    { 
       string _firstName;

       public string FullName
       {
           get
           {
               return FirstName + " " + LastName;
           }
       }

       public string FirstName
       {
           get
           {
               return _firstName;
           }

           set
           {
               _firstName.ToLower();
           }
       }
       public string LastName { get; set; }

       public string Output()
       {
           return "My name is " + FullName;
       }
       public string Output(int times = 1)
       {
           string message = "";
           for (int i = 0; i < times; i++)
           {
               message += FirstName + " " + LastName + "\n";
           }
           return message;
       }
    }
}