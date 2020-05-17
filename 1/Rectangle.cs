using System;

namespace _1
{
    public class Rectangle
    {
        int A;
        int B;

        public Rectangle(int A_, int B_)
        {
            A = A_;
            B = B_;
        }

        public int Square()
        {
            return A * B;
        }

        public int Perimeter()
        {
            return 2 * A + 2 * B;
        }

        public double Diagonal()
        {
            return Math.Sqrt(A * A + B * B);
        }

        public int NumberOfFoursquaresInRectangle()
        {
            return Square() / (Math.Min(A, B) * Math.Min(A, B));
        }
    }
}
