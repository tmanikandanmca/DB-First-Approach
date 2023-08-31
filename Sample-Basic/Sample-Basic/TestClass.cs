using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Basic;

public class TestClass 
{
    public string mic;
    public int same;

    //protected internal string dat =

    //accessmodifier returntype method_name( datatype param)
    //{

    //}

    public void funtion1()
    {
        Console.WriteLine(same);
    }

    public string function2()
    {
        string v1 = "this is from function 2";
        return v1;
    }

    public string function2(string Name)
    {
        string v1 = "this is from function 2" + Name;
        return v1;
    }
}
