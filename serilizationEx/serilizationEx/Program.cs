using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using Person;

namespace serilizationEx
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Person obj = new Person() { Name="Viya", Contact = "7397090543", Age =22 };   
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("F:/person.bin", FileMode.Create))
            {
                formatter.Serialize(fs, obj);
            }
            Console.WriteLine("File created object is serilized");
            Console.ReadKey();  
        }
    }
}
