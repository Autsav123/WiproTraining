class Employee
{
    public void Input()
    {
                  int a;
                  int b;
                  Console.WriteLine("Enter the first number : ");
                  a = Convert.ToInt32(Console.ReadLine());
                  Console.WriteLine("Enter the second number : ");
                  b = Convert.ToInt32(Console.ReadLine());
                  Console.WriteLine("Sum of 2 numbers : " + (a + b));
    }
    public void Display()
    {
        Console.WriteLine("This is employee class");
    }
}