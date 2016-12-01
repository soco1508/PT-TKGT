using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanTichVaThietKeGiaiThuat
{
    public class SapXepTrucTiep
    {
        public int[] Sort(int[] a, int n)
        {
            int min;
            for (int i = 0; i <= n - 2; i++)
            {
                min = i;
                for (int j = i + 1; j <= n - 1; j++)
                {
                    if (a[j] < a[min])
                        min = j;
                }
                swap(ref a[i], ref a[min]);
            }
            return a;
        }
        private void swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
