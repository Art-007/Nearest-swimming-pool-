using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    class Temperature
    {
        private int degree;
        private string scale;

        public Temperature()
        {
            degree = 86;
            scale = "F";
        }

        public Temperature(int deg)
        {
            degree = deg;
            scale = "F";
        }

        public int Degree
        {
            get { return degree; }
            set
            {
                if (degree < 0) degree = 0;
                else degree = value;
            }
        }

        public string Scale
        {
            get { return scale; }
            set { scale = value; }
        }

        public override string ToString()
        {
            return degree + " degree " + scale;
        }
        ~Temperature() { }
    }
}
