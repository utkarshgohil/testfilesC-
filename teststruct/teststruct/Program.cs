using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teststruct
{
    class Program
    {
        public enum days
        {
            sun=1,
            mon=2,
            tue=3,
        }
        struct emp
        {
            public int id;
            public string name;

            public emp(int empid,string empname)
            {
                id = empid;
                name = empname;
            }

            public void print()
            {
                Console.WriteLine("Id and name is "+id+" "+name);
            }

            public int val
            {
                set
                {
                    id = value;
                }
                get
                {
                    return id;
                }
            }
        }
        static void Main(string[] args)
        {
            emp e1=new teststruct.Program.emp(1,"a");
            emp e;
            e1.print();
            e.id = 2;
            e.name = "b";
            e.print();

            Console.WriteLine((int)days.mon);
            Console.ReadLine();
        }
    }
}
