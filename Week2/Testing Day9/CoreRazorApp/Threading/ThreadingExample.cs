using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threading
{
    public class ThreadingExample
    {
        public void Even()
        {
            for(int i = 0; i < 50; i+= 2)
            {
                Console.WriteLine(i);
            }
        }

        public void Odd()
        {
            for (int i = 1; i < 50; i += 2)
            {
                Console.WriteLine(i);
            }
        }

    }
}
