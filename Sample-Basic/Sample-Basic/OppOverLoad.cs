using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Basic
{
    public class OppOverLoad
    {

        private int r = 0;
        private int g = 0;

        public OppOverLoad()
        {

        }

        public OppOverLoad(int _r,int _g)
        {
            r = _r;
            g = _g;
        }

        public static OppOverLoad operator +(OppOverLoad c1, OppOverLoad c2)
        {
            OppOverLoad re = new OppOverLoad();
            re.r = c1.r+c2.r;
            re.g = c1.g+c2.g;
            return re;

        }
        public void display()
        {
            Console.WriteLine($"{r} + i{g}");
        }
    }
}
