using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace serilization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee()
            {
                ID = 3,
                Name = "Viya",
                Designation = "Software Engineer"
            };
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(@"f:\student.txt", FileMode.Create, FileAccess.Write);

            //writing
            formatter.Serialize(stream, employee);
            stream.Close();

            //reading
            stream = new FileStream(@"f:\student.txt", FileMode.Open, FileAccess.Read);
            Employee objnew = (Employee)formatter.Deserialize(stream);

            Console.WriteLine(objnew.ID);
            Console.WriteLine(objnew.Name);
            Console.WriteLine(objnew.Designation);
            Console.ReadKey();
        }
    }
}
