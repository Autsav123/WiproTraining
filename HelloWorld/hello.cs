using System;
class Hello
{
    public static void Main(String[] args)
    {
        Console.WriteLine("This is my first C# Program");
        Console.Write("This Line will put the cusor on same line");
        Console.WriteLine("WriteLine is used for next Line");
        var i = 10;// Var is used only if you dont know the data type
        var name = "Utsav";
        Console.WriteLine($"The Value of i:{i}  The name of person is :{name}");
        char ch = 'B';
        // Int16
        short num= 234;
        //int 32
        int num1 = 456;
        // int64
        long number = 99934;
        double marks = 87.33;
        Decimal marks1 = 81.8M;  // M will be use as a suffix in case of decimal
        float x = 2.34F; //  in case of Float F wiil be use as a suffix
         Console.WriteLine("The num is " + num);
         Console.WriteLine("The num is " + number);
          Console.WriteLine($"The num1 is : {num1}");
           Console.WriteLine("The marks is " + marks);
            Console.WriteLine("The marks1 is " + marks1);
            Console.WriteLine($"The marks1 is : {x} ");
        Console.WriteLine("The Character is " + ch);
        Console.WriteLine("The equivalent no is " + (byte)ch);
        Console.WriteLine("Mimimum & Maximum value of char" + (int)char.MinValue + " " + (int)char.MaxValue);
        Console.WriteLine("Size of char is " + sizeof(char));
        Console.ReadKey();
    }
}