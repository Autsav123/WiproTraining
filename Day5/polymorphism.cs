using System;
//Ability to take many forms
/*Method Overloading--Where all the methods in a class are with the same namebut the arguments will differ(either data type will be different or the arguments or order of arguments will differ
)
Static Binding:When compiler will identify which method needs to be called at compile time*/
namespace oops.poly
 {
    /*class InfoPrinter
    {
        public int Pages;
        InfoPrinter()
        {
            Console.WriteLine("Constructor Called");
        }

       InfoPrinter(int Pages)
        {
            this.Pages = Pages;
            this.Pages = this.Pages + 1;
            Console.WriteLine("Total Pages Printed"+Pages);
       }

        public void Print(string Name)
        {
            Console.WriteLine("Name " + Name);
        }
        public void Print(string Name, int Emp_Id)
        {
            Console.WriteLine("Name " + Name + " " + "Employee Id" + Emp_Id);
        }


        public static void Main()
        {
            InfoPrinter p = new InfoPrinter();
            InfoPrinter p1 = new InfoPrinter();
            InfoPrinter p2 = new InfoPrinter(23);
            p.Print("Utsav");
            p.Print("UTSAV", 4428);
            
        }
    }*/
}