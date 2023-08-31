using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Basic;

public class Conditionaland_Lopping
{

    public void checkIf()
    {
        int a = 20, b = 10;
        if (a > b)
        {
            Console.WriteLine("A is Big");
        }
    }
    public void checkIfElse()
    {
        int a = 20, b = 10;
        if (a > b)
        {
            Console.WriteLine("A is Big");
        }
        else
        {
            Console.WriteLine("B is Big");

        }
    }
    public void CheckElseIf()
    {
        int time = 22;
        if (time < 10)
        {
            Console.WriteLine("Good morning.");
        }
        else if (time < 20)
        {
           
            Console.WriteLine("Good day.");
        }
        else
        {
            Console.WriteLine("Good evening.");
        }
    }


    // switch(expression) 
    //{
    //  case x:
    //    // code block
    //    break;
    //  case y:
    //    // code block
    //    break;
    //  default:
    //    // code block
    //    break;
    //}

    public void CheckSwitch()
    {
        int day = 4;
        switch (day)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            case 7:
                Console.WriteLine("Sunday");
                break;
        }
    }


    //    while (condition) 
    //{
    //  // code block to be executed
    //}
    public void ExplainWhile()
    {
        int i = 0;
        while (i < 5)
        {
            Console.WriteLine(i);
             
        }
    }


 
    public void Explainfor()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(i);
        }
    }

    public void ExplainBreak()
    {
        for (int i = 0; i < 10; i++)
        {
            if (i == 4)
            {
                break;
            }
            Console.WriteLine(i);
        }
    }

    public void ExplainContinue()
    {
        for (int i = 0; i < 10; i++)
        {
            if (i == 4)
            {
                continue;
            }
            Console.WriteLine(i);
        }
    }

    public void ExpplainForEach()
    {
        List<int> z = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, };
        List<string> z1 = new List<string>() { "asdhjg","asjhdfgajs" };

        foreach (var i in z1)
        {
            Console.WriteLine(i);
        }
    }

}


