using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanTichVaThietKeGiaiThuat
{
    public class TinhTong
    {
        public int Tong(int n)
        {
            int s = 0;
            for (int i = 1; i <= n; i++)
                s += i * i;
            return s;
        }
    }
}
