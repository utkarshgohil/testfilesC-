using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testoperatorover
{
    public class Cpoint
    {
        int x, y;
        public Cpoint()
        {
            x = 10;
            y = 20;
        }
        public Cpoint (int i,int j)
        {
            x = i;
            y = j;
        }
        public int X
        {
            set
            {
                x = value;
            }
            get
            {
                return x;
            }
        }
        public int Y
        {
            set
            {
                y = value;
            }
            get
            {
                return y;
            }
        }

        public void prnt()
        {
            Console.WriteLine("value of x & y "+x+" "+y);
        }
        public static Cpoint operator+(Cpoint p1,Cpoint p2)
        {
            Cpoint temp=new Cpoint();
            temp.x = p1.x + p2.x;
            temp.y = p1.y + p2.y;
            return temp;
        }
        public static Cpoint operator ++(Cpoint p1)
        {
            p1.x++;
            p1.y++;
            return p1;
        }
        public static bool operator >(Cpoint p1,Cpoint p2)
        {
            if (p1.x > p2.x && p1.y > p2.y)
            {
                return true;
            }
            else return false;
        }
        public static bool operator <(Cpoint p1, Cpoint p2)
        {
            if (p1.x < p2.x && p1.y < p2.y)
            {
                return true;
            }
            else return false;
        }
        public static implicit operator Cpoint(int i)
        {
            Cpoint t = new testoperatorover.Cpoint(i, 10);
            return t;
        }
        public static explicit operator double(Cpoint c)
        {
            return (double)c.X;
        }
    }
}
