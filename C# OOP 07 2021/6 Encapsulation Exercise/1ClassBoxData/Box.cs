using System;
using System.Collections.Generic;
using System.Text;

namespace ClassBoxData
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            if (length <= 0)
            {
                throw new ArgumentException("Length cannot be zero or negative.");
            }
            else if (width <= 0)
            {
                throw new ArgumentException("Width cannot be zero or negative.");
            }
            else if (height <= 0)
            {
                throw new ArgumentException("Height cannot be zero or negative.");
            }

            this.length = length;
            this.width = width;
            this.height = height;
        }

        public double SurfaceArea()
        {
            return 2 * (length + width) * height + 2 * length * width;
        }

        public double LateralSurfaceArea()
        {
            return 2 * (length + width) * height;
        }


        public double Volume()
        {
            return length * width * height;
        }
    }
}
