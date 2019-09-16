using System;

namespace Perusals
{
    internal class ExploreGenerics
    {
        static string[] GenerateNames()
        {
            string[] names = new string[4];
            names[0] = "Gamma";
            names[1] = "Vlissides";
            names[2] = "Johnson";
            names[3] = "Helm";
            return names; 
        }

        static ArrayList TheGenerator()
        {
            ArrayList names = new ArrayList();
            names.Add("Gamma");
            names.Add("Vlissides");
            names.Add("Johnson");
            names.Add("Helm");
            return names;
        }
        
        static void PrintNames(ArrayList names)
        {
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
        
        public static void Main(string[] args)
        {
            PrintNames(TheGenerator());
        }
    }
}