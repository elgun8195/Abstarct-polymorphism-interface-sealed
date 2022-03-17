using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Models
{
    internal class Square:Figure
    {
        private double _side;
        public Square(double side)
        {
            if (side > 0)
            {
                this._side = side;
            }
            
        }


        public double side { get 
            {
                return _side;
            } 
            set 
            {
                if (value>0)
                {
                    _side = value;
                }
            } 
        }
        
        public override void CalcArea()
        {
            Console.WriteLine($"Area of Square:  {this._side * this._side}");            
        }
    }
}
