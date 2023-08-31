using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Basic;

public class ConstructorExp
{
    private int num;
    private string name;

    static ConstructorExp()
    {
        Console.WriteLine("this is from static constructor");
    }

    public ConstructorExp()
    {
        Console.WriteLine("this is from Constructor");
    }


    public ConstructorExp(int x,string name)
    {
        this.num = x;
        this.name = name;
        Console.WriteLine("this is from Constructor");
    }


    public ConstructorExp(ConstructorExp cons)
    {
        num= cons.num;
        name= cons.name;
    }
}
