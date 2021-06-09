using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public static class DateModifier
    {

        public static int CompareDates(string date1, string date2)
        {
            string[] tokens1 = date1.Split();
            DateTime x1 = new DateTime(int.Parse(tokens1[0]), int.Parse(tokens1[1]), int.Parse(tokens1[2]));
            string[] tokens2 = date2.Split();
            DateTime x2 = new DateTime(int.Parse(tokens2[0]), int.Parse(tokens2[1]), int.Parse(tokens2[2]));
            TimeSpan diff = x1.Subtract(x2);
            return Math.Abs(diff.Days);
        }
    }
}
