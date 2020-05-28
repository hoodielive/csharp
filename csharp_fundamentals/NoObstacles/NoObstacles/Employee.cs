using System;

class Employee
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }

    static void Main(string[] args)
    {
        Employee employee = new Employee();
        employee.Id = 1;
        employee.FirstName = "Nick";
        employee.LastName = "Wise";
        employee.Address = "Somewhere in America";
    }
    public void Display()
    {
        Console.WriteLine("Employee Id: "  + Id);
        Console.WriteLine("Name: " + FirstName + " " + LastName);
        Console.WriteLine("Address: " + Address);
    }
}
