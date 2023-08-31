using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Basic;


public class A1
{
    public int Getnumber(int x, int y)
    {
        return x + y;
    }
}

public class B1 : A1
{
    public string GetString(string x, string y)
    {
        return x + y;
    }
}


public class C1 : A1
{
    public string Output(string x, string y)
    {
        return x + y;
    }

}

public  class HierInh : A1
{
}
