using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Basic;

public class A
{
    public int Getnumber(int x, int y)
    {
        return x + y;
    }
}

public class B : A
{
    public string GetString(string x, string y)
    {
        return x + y;
    }
}


public class MultiLevel : B
{
    public string Output(string x, string y)
    {
        return x + y;
    }

}
