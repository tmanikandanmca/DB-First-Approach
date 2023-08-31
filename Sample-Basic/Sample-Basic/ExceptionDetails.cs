using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Basic;

public class ExceptionDetails
{

    //System.IO.IOException -- File Read write Exception
    //System.IndexOutOfRangeException -- array/List outof index
    //System.ArrayTypeMismatchException -- Array copy 
    //System.NullReferenceException -- with out list declaration
    //System.DivideByZeroException - number / 0
    //System.InvalidCastException -  object obj = new Object(); int i;
    //System.OutOfMemoryException -- file size huge
    //System.StackOverflowException -- over flow data

    public void dataRead()
    {


        try
        {
            
            File.Copy(@"D:\Move\text1.txt", @"D:\Move\New\text1.txt");
        }
        catch (IOException Ex)
        {
            Console.WriteLine(Ex.ToString());
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
        finally
        {
            Console.WriteLine("This is from Finally Block");
        }
      

    }

    public void dividedByZero()
    {
        try
        {
            int x = 234, t = 0, z;
            z = x / t;
        }
        catch(DivideByZeroException ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }


     public void IndexOutOfRangeExceptio()
    {
        try
        {
            int[] res= new int[2] {1,6};
            int d = res[6];
        }
        catch(IndexOutOfRangeException ex)
        {

        }
    }

    
    public void ArrayTypeMismatchExceptio()
    {
        try
        {
            int[] res = new int[2] { 1, 6 };
            string[] te= new string[2];
            Array.Copy(res, te, 2);
        }
        catch (ArrayTypeMismatchException ex)
        {

        }
    }


    public void recursive(int x)
    {
        recursive(++x);
    }

}
