using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Basic;

public class OperatorsExample
{
    public void arithmetic()
    {
        int result;
        int x = 10, y = 5;

        // Addition
        result = (x + y);
        Console.WriteLine("Addition Operator: " + result);

        // Subtraction
        result = (x - y);   
        Console.WriteLine("Subtraction Operator: " + result);

        // Multiplication
        result = (x * y);
        Console.WriteLine("Multiplication Operator: " + result);

        // Division
        result = (x / y);
        Console.WriteLine("Division Operator: " + result);

        // Modulo
        result = (x % y);
        Console.WriteLine("Modulo Operator: " + result);
    }

    public void incredec()
    {
        int a = 10, res;

        // post-increment example:
        // res is assigned 10 only,
        // a is not updated yet
        res = a++;

 
        //a becomes 11 now
        Console.WriteLine("a is {0} and res is {1}", a, res);


        // post-decrement example:
        // res is assigned 11 only, a is not updated yet
        res = a--;

        //a becomes 10 now
        Console.WriteLine("a is {0} and res is {1}", a, res);


        // pre-increment example:
        // res is assigned 11 now since a
        // is updated here itself
        res = ++a;

        // a and res have same values = 11
        Console.WriteLine("a is {0} and res is {1}", a, res);


        // pre-decrement example:
        // res is assigned 10 only since
        // a is updated here itself
        res = --a;

        // a and res have same values = 10
        Console.WriteLine("a is {0} and res is {1}", a, res);
    }

    public void Relational()
    {
        bool result;
        int x = 5, y = 10;

        // Equal to Operator
        result = (x == y);
        Console.WriteLine("Equal to Operator: " + result);

        // Greater than Operator
        result = (x > y);
        Console.WriteLine("Greater than Operator: " + result);

        // Less than Operator
        result = (x < y);
        Console.WriteLine("Less than Operator: " + result);

        // Greater than Equal to Operator
        result = (x >= y);
        Console.WriteLine("Greater than or Equal to: " + result);

        // Less than Equal to Operator
        result = (x <= y);
        Console.WriteLine("Lesser than or Equal to: " + result);

        // Not Equal To Operator
        result = (x != y);
        Console.WriteLine("Not Equal to Operator: " + result);
    }

    public void Logical()
    {
        bool a = true, b = false, result;

        // AND operator
        result = a && b;
        Console.WriteLine("AND Operator: " + result);

        // OR operator
        result = a || b;
        Console.WriteLine("OR Operator: " + result);

        // NOT operator
        result = !a;
        Console.WriteLine("NOT Operator: " + result);

    }

    public void Bitwise()
    {
        int x = 5, y = 10, result;

        // Bitwise AND Operator
        result = x & y;
        Console.WriteLine("Bitwise AND: " + result);

        // Bitwise OR Operator
        result = x | y;
        Console.WriteLine("Bitwise OR: " + result);

        // Bitwise XOR Operator
        result = x ^ y;
        Console.WriteLine("Bitwise XOR: " + result);

        // Bitwise AND Operator
        result = ~x;
        Console.WriteLine("Bitwise Complement: " + result);

        // Bitwise LEFT SHIFT Operator
        result = x << 2;
        Console.WriteLine("Bitwise Left Shift: " + result);

        // Bitwise RIGHT SHIFT Operator
        result = x >> 2;
        Console.WriteLine("Bitwise Right Shift: " + result);
    }

    public void Conditional()
    {
        int x = 5, y = 10, result;

        // To find which value is greater
        // Using Conditional Operator
        result = x > y ? x : y;

        // To display the result
        Console.WriteLine("Result: " + result);

        // To find which value is greater
        // Using Conditional Operator
        result = x < y ? x : y;

        // To display the result
        Console.WriteLine("Result: " + result);
    }
}
