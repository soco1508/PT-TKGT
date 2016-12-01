using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIBONACCI
{
    public class ChienLuocQuiHoachDong
    {
        public int Fibonacci(int n)
        {
            int[] array = new int[100];
            array[0] = 0;
            array[1] = 1;
            for (int i = 2; i <= n; i++)
                array[i] = array[i - 1] + array[i - 2];
            return array[n];
        }
        public string GetValue(int n)
        {
            return "f[" + n + "] = " + Fibonacci(n);
        }       
    }
}
