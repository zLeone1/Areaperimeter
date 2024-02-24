using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Areaperimeter
{
    internal class Square
    {
        protected double l1;
      
        public double L1
        {
            get { return l1; }
            set { l1 = value; }
        }
        
        public Square(double l1) 
        { 
            this.l1 = l1;
              
        }
        public double GetSquareArea()
        {
            return l1 * l1;
        }
       public double GetSquarePerimeter()
        {
            return l1 * 4;
        }

        ~Square()
        {
        }
    }
}
