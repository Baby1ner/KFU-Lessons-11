using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T00Much_12_
{
    class C
    {
        public double real;
        double imaginary;
        public C(double real, double imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }

        public C() { }

        public static C operator +(C c1, C c2)
        {
            C c3 = new C();
            c3.real = c1.real + c2.real;
            c3.imaginary = c1.imaginary + c2.imaginary;
            return c3;
        }
        public static C operator -(C c1, C c2)
        {
            C c3 = new C();
            c3.real = c1.real - c2.real;
            c3.imaginary = c1.imaginary - c2.imaginary;
            return c3;
        }
        public static C operator *(C c1, C c2)
        {
            C c3 = new C();
            c3.real = c1.real * c2.real - c1.imaginary * c2.imaginary;
            c3.imaginary = c1.real * c2.imaginary + c1.imaginary * c2.real;
            return c3;
        }
        public static bool operator ==(C c1, C c2)
        {
            return (c1.real == c2.real && c1.imaginary == c2.imaginary);
        }
        public static bool operator !=(C c1, C c2)
        {
            return !(c1.real == c2.real && c1.imaginary == c2.imaginary);
        }
        public override bool Equals(object obj)
        {
            C c = (C)obj;
            return (real == c.real && imaginary == c.imaginary); ;
        }
        public string ToString()
        { return real.ToString() + " + " + imaginary.ToString() + "i"; }



    }
}
