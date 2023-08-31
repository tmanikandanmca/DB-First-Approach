using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Basic;

public class OverLoadingExample
{

    public int Generic(int a)
    {
        return a * a;
    }
    public string Generic(string a)
    {
        return a;
    }
    public int Generic(int l,int b)
    {
        return l * b;
    }
    public float Generic(int l, float b)
    {
        return l * b;
    }

}
