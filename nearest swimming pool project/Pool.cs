using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    class Pool
    {

       
        private Temperature temp= new Temperature();
        private Location loc= new Location();
        public static int count;

        public Pool(Temperature T, Location L)
        {
            temp = T;
            loc = L;
            
        }
        public Pool(int w, string name, int X_value, int Y_value )
        {
            temp = new Temperature(w);
            loc = new Location(name, X_value, Y_value);
        }
        public Pool(int w, Location l)
        {
            temp = new Temperature(w);
            loc = l;
        }

        public Temperature Temp
        {
            get { return temp; }
            set { temp = value; }
        }
        public Location Loc
        {
            get { return loc; }
            set { loc = value; }
        }
        public override string ToString()
        {
            return loc + " with temperature at " + temp;
        }


        ~Pool() { }

    }
}