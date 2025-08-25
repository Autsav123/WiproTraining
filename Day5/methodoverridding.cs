// // // /*method overriding -- where some methods in base class and in inherited or child class are with the same name
// // // run time  binding -- when compiler will identify which method
// // // needs to be called at run time when the object will be created*/

// // //Method Overriding in Polymorphism can be done using virtual + override keyword

// // // /*method overriding -- where some methods in base class and in inherited or child class are with the same name
// // // run time  binding -- when compiler will identify which method
// // // needs to be called at run time when the object will be created*/

// // //Method Overriding in Polymorphism can be done using virtual + override keyword
// using System;
// public class Person
// {

//     public void GetRole()
//     {

//         Console.WriteLine("Person class");

//     }

// }

// public class Teacher : Person
// {

//     // Generally it's overriden but you are hiding that method in the inherited class
//     public  void GetRole()
//     {

//         Console.WriteLine("She is a teacher");

//     }

// }

// public class Mother : Person
// {

// //     //Generally it's overriden but you are hiding that method in the inherited class
//     public  void GetRole()
//     {

//         Console.WriteLine("She is a Mother");

//     }

// }

// public class MainProgram
// {

//      static void Main(string[] args)
//     {
//         //Late Binding - RunTime Polymorphism
//         Person p = new Teacher();
//         Person p1 = new Mother();

//         p.GetRole();
//         p1.GetRole();
//     }
// }

// // // both are having the Car() method but without virtual and override keyword it's not overriding -- they just hide 

using System;

// Base class
public class Person
{
    // Marking the method as virtual to allow overriding
    public virtual void GetRole()
    {
        Console.WriteLine("Person class");
    }
}

// Derived class 1
public class Teacher : Person
{
    // Overriding the base class method
    public override void GetRole()
    {
        Console.WriteLine("She is a teacher");
    }
}

// Derived class 2
public class Mother : Person
{
    // Overriding the base class method
    public override void GetRole()
    {
        Console.WriteLine("She is a Mother");
    }
}

// Main class with Main method as entry point
public class MainProgram
{
    public static void Main(string[] args)
    {
        // Runtime polymorphism
        Person p = new Teacher();
        Person p1 = new Mother();

        // These will now call the overridden methods
        p.GetRole();   // Output: She is a teacher
        p1.GetRole();  // Output: She is a Mother
    }
}
