using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Models
{
    internal class Rectangular : Figure
    {
        private double _width;
        private double _length;


        public double Width
        {
            get
            {
                return _width;
            }
            set
            {
                if (value > 0)
                {
                    _width = value;
                }
            }
        }


        public double Lenth
        {
            get
            {
                return _length;
            }
            set
            {
                if (value > 0)
                {
                    _length = value;
                }

            }
        }
        public Rectangular(double width, double length)
        {
            if (width > 0)
            {
                this._width = width;
            }
            if (length > 0)
            {
                this._length = length;
            }
            
        }
        public override void CalcArea()
        {
            Console.WriteLine($"Area of Rectangle:  { this._width * this._length}");
        }
    }
}
