using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Class1
    {

        public static void Main(string[] a)
        {
            calculator obj = new calculator();
 

        }
    }


  public class calculator
    {
        public int add (int a ,int b)
        {
            return a + b;
        }
        public int sub(int a, int b)
        {
            return a - b;
        }
        public int multiply(int a, int b)
        {
            return a * b;
        }
        public int division(int a, int b)
        {
            return a / b;
        }


    }


    // example of extension method 
    static class ExtMehtodClass
    {
        public static int  Mod(this calculator calculator ,int a,int b )
        {
            return (a % b);
        }
    }
}
