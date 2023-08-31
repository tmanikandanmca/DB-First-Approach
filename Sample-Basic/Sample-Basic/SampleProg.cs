using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Basic
{
    public class SampleProg
    {

        public void swapnumber()
        {
            //0,1,1,2,3
            int x = 8, a = 0, b = 1 ,temp=0;

            //for
            //while
            Console.WriteLine(a);
            Console.WriteLine(a);


            for (int i = 0; i < x; i++)
            {
                temp = a + b;
                Console.WriteLine(temp);

                a = b;
                b = temp;
            }


        }
    }
}
