using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testperf
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> li = new List<int>(1000);
            Stopwatch sw = new Stopwatch();
            sw.Start();

            for(int i = 0; i < 1000; i++)
            {
                li.Add(i);
            }
            sw.Stop();
            Console.WriteLine("forloop " + sw.ElapsedTicks);
            sw.Reset();

            sw.Start();

            foreach (int i in li)
            {
                //Console.WriteLine(+i);
            }
            sw.Stop();
            Console.WriteLine("foreachloop " + sw.ElapsedTicks);
            
        }
    }
}
