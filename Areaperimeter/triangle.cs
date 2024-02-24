using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Areaperimeter
{
    internal class Triangle
    {
      
        protected double basee;

        public double Basee
        {
            get { return basee; }

            set { basee = value; }
         

        }

        protected double height;

        public double Height
        {
            get { return height; }

            set { height = value; }


        }
        public Triangle( double height, double basee)
        {
            
            this.basee = basee;   
            this.height = height;
        }

        public double GetTriangleArea()
        {
            return (basee * height) / 2;
        }

        public double GetTrianglePerimeter(double sideTriangle)
        {
            return (sideTriangle +  sideTriangle + basee);
        }
        ~Triangle()
        {
        }
    }

}

