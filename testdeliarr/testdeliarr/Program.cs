using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testdeliarr
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 40, 50, 20, 30 };
            
            deliarr<int> p = new deliarr<int>();
            Program p1 = new Program();
            deliarr<int>.mydel d = new deliarr<int>.mydel(p1.cmp);
            Console.WriteLine("before");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            p.sort(arr, d);
            Console.WriteLine("After");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            char[] carr = { 'a', 's', 'b', 'z', 'e' };
            deliarr<char> p3 = new deliarr<char>();
            deliarr<char>.mydel d2 = new deliarr<char>.mydel(p1.cmp1);
            p3.sort(carr, d2);

            Console.WriteLine("After");
            for (int i = 0; i < carr.Length; i++)
            {
                Console.WriteLine(carr[i]);
            }
        }
        public void cmp(int o1,int o2)
        {
            if (o1 < o2)   // If taken object typecast.......(int) o1 < (int) o2
            {
                int temp = o1;
                o1 = o2;
                o2 = temp;
            }
        }

        public void cmp1(char o1, char o2)
        {
            if ((int)o1 < (int)o2)   // If taken object typecast.......(int) o1 < (int) o2
            {
               int temp = o1;
                o1 = o2;
                o2 = (char)temp;
            }
        }
    }
}
