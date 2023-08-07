using System;
using EmployeeClass;
using System.IO;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of Employee
        Employee employee = new Employee
        {
            Id = 246,
            FirstName = "Gai-3",
            LastName = "Karthikeyan",
            Salary = 80000.0
        };

        // XML serialization
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(Employee));
        using (FileStream stream = new FileStream("F:\\Day - 21\\Assignment - 24\\Employee.xml", FileMode.Create))
        {
            xmlSerializer.Serialize(stream, employee);
        }

        // XML deserialization
        using (FileStream stream = new FileStream("F:\\Day - 21\\Assignment - 24\\Employee.xml", FileMode.Open))
        {
            Employee deserializedEmployee = (Employee)xmlSerializer.Deserialize(stream);
            DisplayEmployeeInfo(deserializedEmployee);
        }
    }

    static void DisplayEmployeeInfo(Employee employee)
    {
        Console.WriteLine($"ID: {employee.Id}");
        Console.WriteLine($"Name: {employee.FirstName} {employee.LastName}");
        Console.WriteLine($"Salary: {employee.Salary}");
    }
}
