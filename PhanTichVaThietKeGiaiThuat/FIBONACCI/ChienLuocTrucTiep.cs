using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIBONACCI
{
    public class ChienLuocTrucTiep
    {
        public string GetValue(int n)
        {
            int a = 1;
            int b = 1;
            for (int i = 2; i < n; i++)
            {
                int temp = a + b;
                a = b;
                b = temp;
            }
            return "F[" + n + "]=" + b;
        }
    }
}
