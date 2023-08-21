
using System;

class abcde
{

   
    static int Addition(int a)
    {

        
        int add = a + a;

        
        return add;
    }


    static public void Main()
    {
        int number = 2;


        int result = Addition(number);
        Console.WriteLine("The addition is {0}", result);
    }
}
