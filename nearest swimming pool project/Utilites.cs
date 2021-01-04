using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    class Utilites
    {
        static public double Distance(ref Location L1, Location[] L2, ref int list, ref string start)
        {
            list = 0;
            double closest = Math.Sqrt(Math.Pow(Math.Abs(L1.X_value - L2[0].X_value), 2) + (Math.Pow(Math.Abs(L1.Y_value - L2[0].Y_value), 2)));

            double temp = 0;
            for (int i = 0; i < L2.Length; i++)
            {
                temp = Math.Sqrt(Math.Pow(Math.Abs(L1.X_value - L2[i].X_value), 2) + (Math.Pow(Math.Abs(L1.Y_value - L2[i].Y_value), 2)));

                if (closest > temp)
                {
                    closest = temp;
                    list = i;
                }
            }


            start = L1.Name;
            L1 = L2[list];
            L2[list] = new Location(L2[list].Name, 99, 99);

            return closest;

        }
    }
}
