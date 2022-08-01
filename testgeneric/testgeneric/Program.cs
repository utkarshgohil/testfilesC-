using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testgeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            Testgen<int,string> t = new Testgen<int,string>();
            t.setdata(10);
            int i=t.getdata();
            Console.WriteLine(+i);
            t.bprop = "abc";
            Console.WriteLine(t.bprop);

            List<int> l1 = new List<int>();
            l1.Add(10);
            l1.Add(20);
            l1.Add(30);
            l1.Add(40);

            foreach(int l in l1)
            {
                Console.WriteLine(l);
            }

            Stack<int> s = new Stack<int>();
            s.Push(10);
            s.Push(20);
            s.Push(30);

            HashSet<string> hs = new HashSet<string>();
            hs.Add("abc");
            hs.Add("xyz");
            hs.Add("lmn");
            foreach (var h in hs)
            {
                Console.WriteLine(h);
            }

            Dictionary <int,string> d= new Dictionary<int, string>();
            d.Add(1,"ABC");
            d.Add (2,"xyz");
            d.Add(3, "xyz23323");
            d.Add(4, "xyzsrys4453");

            //foreach (KeyValuePair<int, string> kvp in d)
            //    Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);

            Dictionary<int, string>.Enumerator e = d.GetEnumerator ();
            while(e.MoveNext())
            {
                Console.WriteLine(e.Current.Key);
                Console.WriteLine(e.Current.Value);
            }

            Classd<int, int> cd = new testgeneric.Classd<int, int>();
            Classd<int, int>.mydel d1 = new testgeneric.Classd<int, int>.mydel(delinv);
            cd.fn1(10, 20, d1);


            Classd<string, int> cd1 = new testgeneric.Classd<string, int>();
            Classd<string, int>.mydel d2 = new Classd<string, int>.mydel(delinv);
            cd1.fn1("abc", 20, d2);

            X x = new testgeneric.X();
            Y y = new testgeneric.Y();
            Z<X,Y> z= new Z<X,Y>();
            Z<X, W> z1 = new Z<X, Y>();
            //Z<Y, W> z3 = new Z<X, Y>();

        }
        public static void delinv(int i,int j)
        {
            Console.WriteLine("Delegate fn invoked int-int");
        }
        public static void delinv(string i, int j)
        {
            Console.WriteLine("Delegate fn invoked string-int");
        }
    }
}
