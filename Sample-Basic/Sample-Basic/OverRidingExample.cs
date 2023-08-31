using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Basic;


public class Class1
{ 
    public void Show()
    {
        Console.WriteLine("This from Parent Class");
    }
}

//public class Class2 : Class1
//{ 
//    public override void Show()
//    {
//        Console.WriteLine("This from child Class");
//    }
//}


public class OverRidingExample : Class1
{

    public new void Show()
    {
        Console.WriteLine("This from child Class");
    }
}
