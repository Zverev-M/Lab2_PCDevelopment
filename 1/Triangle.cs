using System;

namespace _1
{
    public class Triangle
    {
        int A;
        int B;
        int C;

        public Triangle(int A_, int B_, int C_)
        {
            A = A_;
            B = B_;
            C = C_;
        }

        public int GetA()
        {
            return A;
        }

        public int GetB()
        {
            return B;
        }

        public int GetC()
        {
            return C;
        }

        public int Perimeter()
        {
            return A + B + C;
        }

        public double SemiPerimeter()
        {
            return Perimeter() / 2;
        }

        public bool CompareWith(Triangle OtherTriangle)
        {
            return (A == OtherTriangle.A && B == OtherTriangle.B && C == OtherTriangle.C);
        }
    }
}