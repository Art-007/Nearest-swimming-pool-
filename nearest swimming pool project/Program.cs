using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    class Program
    {
        static void Main(string[] args)
        {

            Location start = new Location("Start Point", 0, 0);
            Location A = new Location(">> A", 4, 8);
            Location B = new Location(">> B", 1, 3);
            Location C = new Location(">> C", 4, 2);
            Location D = new Location(">> D", 13, 1);
            Location E = new Location(">> E", 12, 9);
            Location F = new Location(">> F", 10, 5);
            Location G = new Location(">> G", 6, 6);
            Location[] poolsLoc = new Location[7] { A, B, C, D, E, F, G };

            Random rand = new Random();
            int randNum;

            Pool[] Pools = new Pool[7];
            for (int i = 0; i < Pools.Length; i++)
            {
                randNum = rand.Next(98, 104);
                Pools[i] = new Pool(randNum, poolsLoc[i]);
            }

            Console.WriteLine(start);
            int list = 0;
            string orgin = " A";
            for (int i = 0; i < Pools.Length; i++)
            {
                double closest = Utilites.Distance(ref start, poolsLoc, ref list, ref orgin);

                if (i == 0)
                    Console.WriteLine(" (The shortest distance {0} from {1} to {2})\n",
                                String.Format("{0:0.00}", closest), "'start point'", Pools[list].Loc.Name);
                else
                    Console.WriteLine(" (The shortest distance {0} from {1} to {2})\n",
                        String.Format("{0:0.00}", closest), orgin, Pools[list].Loc.Name);
                Console.WriteLine(Pools[list]);
                if (i == Pools.Length - 1)
                    Console.WriteLine(" (THE END)");
            }
            Console.ReadLine();



        }
    }
}