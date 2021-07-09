﻿using System;
using System.Text;

namespace Shapes
{
    public class Rectangle : Shape
    {
        private double height;
        private double width;

        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
        }

        public double Height
        {
            get { return height; }
            private set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height1 must be a positive number!");
                }

                height = value;
            }
        }

        public double Width
        {
            get { return width; }
            private set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height1 must be a positive number!");
                }

                width = value;
            }
        }


        public override double CalculateArea()
        {
            return height * width;
        }

        public override double CalculatePerimeter()
        {
            return (2 * (height + width));
        }

        public override string Draw()
        {
            return base.Draw() + $" {this.GetType().Name}";
        }
    }
}
