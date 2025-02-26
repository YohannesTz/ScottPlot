﻿using System;

namespace ScottPlot
{
    /// <summary>
    /// Describes an X/Y position in coordinate space
    /// </summary>
    public struct Coordinate
    {
        public double X;
        public double Y;

        public Coordinate(double x, double y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// True as lone as neither coordinate is NaN or Infinity
        /// </summary>
        public bool IsFinite()
        {
            return
                !double.IsNaN(X) &&
                !double.IsNaN(Y) &&
                !double.IsInfinity(X) &&
                !double.IsInfinity(Y);
        }

        /// <summary>
        /// Return the distance to another coordinate (in coordinate units)
        /// </summary>
        public double Distance(Coordinate other)
        {
            double dX = Math.Abs(other.X - X);
            double dY = Math.Abs(other.Y - Y);
            return Math.Sqrt(dX * dX + dY * dY);
        }
    }
}
