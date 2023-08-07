using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using simplilib;

namespace readout
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream fs = new FileStream("F:\\Day - 21\\Players.bin", FileMode.Open))
            {

                Player dp = (Player)formatter.Deserialize(fs);

                Console.WriteLine("Player ID " + dp.Id);

                Console.WriteLine("Player Name " + dp.Name);

                Console.WriteLine("Player Type " + dp.PlayerType);

                Console.WriteLine("Player Team" + dp.Team);
            }

            Console.ReadKey();
        }
    }
}
