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
           set
           {
               value.Split();
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
       public string Output(int times)
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