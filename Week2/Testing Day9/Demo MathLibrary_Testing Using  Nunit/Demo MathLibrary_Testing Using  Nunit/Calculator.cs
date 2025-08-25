using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_MathLibrary_Testing_Using__Nunit
{
    public class Calculator
    {
        public int Add(int x,int y) { return x + y; }
        public int Subs(int a, int b) => a - b;  // Returning values using lamda expression =>
    }
}
