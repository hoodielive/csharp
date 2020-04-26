namespace StartOver
{
    public class Person
    {
        private string _middleName = "Granola Bar";
        public string FirstName { get; set; }         
        public string LastName { get; set; }

        public string FullName
        {
            get
            {
                return FirstName +  " " + LastName;
            }
        }
        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }
    }
}