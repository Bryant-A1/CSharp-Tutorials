using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValRefs
{
    class ValManipulator
    {
        public int Factorial(int num)
        {
            if (num == 1)
            { return 1; }
            else
            { return num * Factorial(num - 1); }
        }

        public void Out2(out int num1, out int num2)
        {
            num1 = 100;
            num2 = 200;
        }

        public void Swap(ref int x, ref int y)
        {
            int temp;
            temp = x; x = y; y = temp;
        }

        static void Main(string[] args)
        {
            ValManipulator foo = new ValManipulator();

            int a;
            int b;
            foo.Out2(out a, out b);
            //Console.WriteLine("a ={0}", a); Console.WriteLine("b ={0}", b);
            //foo.Swap(ref a, ref b);
            //Console.WriteLine("a ={0}", a); Console.WriteLine("b ={0}", b);
            Console.ReadKey();
        }
    }
}
