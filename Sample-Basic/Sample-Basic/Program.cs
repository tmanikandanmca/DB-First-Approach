// See https://akas/new-console-template for more information


using Sample_Basic;


Console.WriteLine("Enter sample string");
string sentense = Console.ReadLine();
List<char> charlist= new List<char>();

for(int i = 0;i<= sentense.Length;i++)
{
    if (sentense[i] ==' ' || i== sentense.Length-1)
    {
        if(i== sentense.Length-1 )
        {
            charlist.Add(sentense[i]);

        }
        
    }

}




//MultiLevel m= new MultiLevel();




//Console.WriteLine( m.Output("besant", "Technologies"));
//Console.WriteLine(m.GetString("Trining", "Program"));
//Console.WriteLine(m.Getnumber(5, 8));


//InheritanceBasic ob = new InheritanceBasic();
//ob.z = 30;
//ob.Display1();
//ob.Display2();

//base1 b1= new base1();
//b1.z = 30;
//b1.Display1();
//b1.Display2();



//OppOverLoad cp1 = new OppOverLoad(2, 7);
//cp1.display();


//OppOverLoad cp2 = new OppOverLoad(8, 23);
//cp2.display();

//OppOverLoad cp3= cp1 + cp2;
//cp3.display();

//Complex c1 = new Complex(3, 7);
//c1.Display();
//Complex c2 = new Complex(5, 2);
//c2.Display();
//Complex c3 = Complex.Add(c1, c2);
//c3.Display();
//Console.ReadKey();

//OpertaorComplex oc1 = new OpertaorComplex(3, 7);
//oc1.Display();
//OpertaorComplex oc2 = new OpertaorComplex(5, 2);

//OpertaorComplex oc3 = oc1 + oc2;
//oc3.Display();
Console.ReadKey();




//int x = 6, sum = 0;
//for (int i = 1; i < x; i++)
//{
//    if ((x / i) == 0)
//    {
//        sum = sum + i;
//    }
//}

////condition? first_expression : second_expression;


//string res= (sum == x) ? "its a  perfect numer" : "its a  perfect numer";

//Console.WriteLine(res);

//OverRidingExample onj = new OverRidingExample();
//onj.Show();

//OverLoadingExample op = new OverLoadingExample();
//Console.WriteLine(op.Generic(4));
//Console.WriteLine(op.Generic("from mail class"));
//Console.WriteLine(op.Generic(4,6));

Console.ReadKey();


//6 1,2,3 == 6 