using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10
{
    class radians
    {
        int gradus;
        int min;
        int second;

        public int Gradus
        { 
            get 
            { 
                return gradus; 
            } 
            set 
            { 
                gradus = value; 
            } 
        }
        public int Min
        { 
            get 
            { 
                return min; 
            } 
            set 
            { 
                min = value % 60; 
                Gradus += value / 60; 
            } 
        }
        public int Second
        { 
            get
            {
                return second; 
            } 
            set 
            { 
                second = value % 60; 
                Min += value / 60; 
            } 
        }
        public radians(int gradus, int min, int second)
        {
            Gradus = gradus;
            Min = min;
            Second = second;
        }


        public double ToRadians()
        {
            double Radians = (gradus + min + second) * Math.PI / 180;
            return Radians;
        }
    }
}