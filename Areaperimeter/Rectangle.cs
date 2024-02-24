using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Areaperimeter
{
    internal class Rectangle
    {
        protected double basee;
        public double Basee
        {  get { return basee; }
           set { basee = value; }
        }
        protected double height;
        public double Height
        { 
            get { return height; }

            set { height = value; }

        }

        public Rectangle(double basee, double height)
        {
            this.basee = basee;
            this.height = height;
        }
        public double GetArea() 
        { 
            return basee * height; 
        }

        public double GetPerimeter()
        {
            return (basee * 2) + (height * 2);

        }
        ~Rectangle()
        {
        }
    }
}
