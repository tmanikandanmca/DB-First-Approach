using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Basic;

public class sample1
{



    public void res()
    {

    }
}

public class ClassSample : sample1
{ 
    public int x;
    string y;
    float z;

    enum days
    {
        monday,
        tuesday,
        wednesday,
        thursday,
        friday,
        saturday,
        sunday
    }



    public void function1()
    {
        Console.WriteLine(days.monday);
        Console.WriteLine((int)days.monday);

    }

}



//ClassSample c1 = new ClassSample();


//c1.x = 67;
//c1.function1();
//c1.res();


//structExample s1 = new structExample();
//s1.x = 23;
//s1.function1();


////ConstructorExp obj1 = new ConstructorExp();

////ConstructorExp obj1 = new ConstructorExp();
////ConstructorExp obj3 = new ConstructorExp();


////string word = "Level";
//////word = word;
////string initial = word,Last="";



//// for ,foreach,while



////int[] ar = new int[] { 4, 6, 8, 34, 56, 7 };

////int number = 153,sum=0;
////int Start = number;


////while (number>0)
////{
////    int digit=number%10;
////    sum=sum+(digit*digit*digit);
////    number=number/10;
////}

////if(Start == sum)
////{
////    Console.WriteLine("This is an Armstrong Number :" + Start);
////}
////else
////{
////    Console.WriteLine("This is Not an Armstrong Number");

////}

//// for,foreach,while









////ConstructorExp obj = new ConstructorExp(1,"data");

////ConstructorExp obj4 = new ConstructorExp(obj);






//////Console.WriteLine("Enter a Name");
//////string name = Console.ReadLine();

////OperatorsExample op = new OperatorsExample();

//////op.arithmetic();
//////op.incredec();
//////op.Relational();
//////op.Logical();
//////op.Bitwise();
//////op.Conditional();

//////int x = 0, y = 2, z = 5;



////Conditionaland_Lopping cp = new Conditionaland_Lopping();
////cp.checkIf();
////cp.checkIfElse();
////cp.CheckElseIf();
////cp.CheckSwitch();
////cp.Explainfor();
////cp.ExplainBreak();
////cp.ExplainContinue();
////cp.ExpplainForEach();


//Console.WriteLine("End of the program");