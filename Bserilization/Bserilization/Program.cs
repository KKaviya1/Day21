using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using simplilib;

namespace Bserilization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Console.WriteLine("enter player id");
            player.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("enter player name");
            player.Name = Console.ReadLine();
            Console.WriteLine("enter player type");
            player.PlayerType = Console.ReadLine();
            Console.WriteLine("enter player team");
            player.Team = Console.ReadLine();

            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("F:\\Day - 21\\Players.bin", FileMode.Create))
            {
                formatter.Serialize(fs, player);
            }
            Console.WriteLine("Created & serilized");

            Console.ReadKey();
        }

    }
}
