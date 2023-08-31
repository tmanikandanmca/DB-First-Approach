using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Basic
{
    public class Complex
    {
        private int real;
        private int img;
        public Complex(int r = 0, int i = 0)
        {
            real = r;
            img = i;
        }
        public static Complex Add(Complex c1, Complex c2)
        {
            Complex temp = new Complex();
            temp.real = c1.real + c2.real;
            temp.img = c1.img + c2.img;
            return temp;
        }
        public void Display()
        {
            Console.WriteLine($"{real} + i{img}");
        }
    }



    public class OpertaorComplex
    {
        private int real;
        private int img;
        public OpertaorComplex(int r = 0, int i = 0)
        {
            real = r;
            img = i;
        }
        public static OpertaorComplex operator +(OpertaorComplex c1, OpertaorComplex c2)
        {
            OpertaorComplex temp = new OpertaorComplex();
            temp.real = c1.real + c2.real;
            temp.img = c1.img + c2.img;
            return temp;
        }
        public void Display()
        {
            Console.WriteLine($"{real} + i{img}");
        }
    }
}
