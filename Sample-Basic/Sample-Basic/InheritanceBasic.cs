using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Basic;

public class base1
{

    public int z = 0;
	public base1()
	{
		Console.WriteLine("This is base class private contructor");	
	}

	public void Display1()
	{
        Console.WriteLine("This is base class  display");

    }
}

public class InheritanceBasic : base1
{

    public void Display2()
    {
        Console.WriteLine("This is base class  display");

    }

}


