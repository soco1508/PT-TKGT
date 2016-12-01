using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanTichVaThietKeGiaiThuat
{
    public class SoTrungMau
    {
        public int StringMatch(string chuoi, string mau)
        {
            int n = chuoi.Length;
            int m = mau.Length;
            int j;
            for (int i = 0; i <= n - m; i++)
            {
                j = 0;
                while (j < m && mau[j] == chuoi[i + j])
                {
                    j += 1;
                }
                if (j == m) return i;
            }
            return -1;
        }
    }
}
