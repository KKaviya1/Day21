using System;
using EmployeeClass;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


class Program
{
    static void Main(string[] args)
    {
        // Create an instance of Employee
        Employee employee = new Employee
        {
            Id = 369,
            FirstName = "Viya",
            LastName = "Gandhi",
            Salary = 30000.0
        };

        // Binary serialization
        BinaryFormatter binaryFormatter = new BinaryFormatter();
        using (FileStream stream = new FileStream("F:\\Day - 21\\Assignment - 24\\Employee.bin", FileMode.Create))
        {
            binaryFormatter.Serialize(stream, employee);
        }

        // Binary deserialization
        using (FileStream stream = new FileStream("F:\\Day - 21\\Assignment - 24\\Employee.bin", FileMode.Open))
        {
            Employee deserializedEmployee = (Employee)binaryFormatter.Deserialize(stream);
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
