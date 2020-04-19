
using System;

namespace _1
{
    /// <summary>
    /// class of Circle figure
    /// </summary>
    public class Circle
    {
        int R;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="R_">Radius</param>
        public Circle(int R_)
        {
            R = R_;
        }
        /// <summary>
        /// Method for getting Lenght
        /// </summary>
        /// <returns>Lenght</returns>
        public double Lenght()
        {
            return 2 * 3.14 * R;
        }
        /// <summary>
        /// Method for getting Square
        /// </summary>
        /// <returns>Square</returns>
        public double Square()
        {
            return 3.14 * R * R;
        }
        /// <summary>
        /// Method for getting Diameter
        /// </summary>
        /// <returns>Diameter</returns>
        public int Diameter()
        {
            return 2 * R;
        }
    }
}