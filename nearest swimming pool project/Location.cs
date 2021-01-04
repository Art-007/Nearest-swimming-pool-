using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    class Location
    {
        private int xaxis;
        private int yaxis;

        public Location()
        {
            Name = " ";
            xaxis = 0;
            yaxis = 0;
        }

        public Location(int x, int y)
        {
            Name = "";
            xaxis = x;
            yaxis = y;
        }

        public Location(string n, int x, int y)
        {
            Name = n;
            xaxis = x;
            yaxis = y;
        }

        public int X_value
        {
            get { return xaxis; }
            set
            {
                if (xaxis < 0) xaxis = -99;
                else xaxis = value;
            }
        }

        public int Y_value
        {
            get { return yaxis; }
            set
            {
                if (yaxis < 0) yaxis = -999;
                else yaxis = value;
            }
        }

        public string Name { get; set; }
        public override string ToString()
        {
            return Name + "(" + xaxis + "," + yaxis + ")";
        }

        ~Location() { }

    }

}

