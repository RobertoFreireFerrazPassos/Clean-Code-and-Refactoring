using System;

namespace ComposingMethods.ReplaceMethodWithMethodObject
{
    /*
     * 
     * Problem:
     * You have a long method in which the local variables are so intertwined that you can’t apply Extract Method.
    */
    public class Point
    {
        private double Latitude;
        private double Longitude;

        public Point(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }

        public double CalculateDistance(Point anotherPoint)
        {
            double radian = 180 / 3.1415;
            var radiansLatitude = this.Latitude / radian;
            var anotherRadiansLatitude = anotherPoint.Latitude / radian;
            var radiansLongitude = this.Longitude / radian;
            var anotherRadiansLongitude = anotherPoint.Longitude / radian;
            var radius = 6371;
            var arc = Math.Acos(Math.Sin(radiansLatitude) * Math.Sin(anotherRadiansLatitude)
                      + Math.Cos(radiansLatitude) * Math.Cos(anotherRadiansLatitude)
                         * Math.Cos(radiansLongitude - anotherRadiansLongitude));
            return Math.Round(arc * radius,3);
        }
    }
}

