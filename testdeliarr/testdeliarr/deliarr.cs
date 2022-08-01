using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testdeliarr
{
    public class deliarr<T>
    {
        public delegate void mydel(T o1, T o2);
        public void sort(T [] arr, mydel d)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = i + 1; j < arr.Length; j++)
                {
                    d(arr[i], arr[j]);
                }
            }
        }
    }
}
