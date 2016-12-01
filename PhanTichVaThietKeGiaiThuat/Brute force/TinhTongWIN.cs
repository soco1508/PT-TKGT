using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanTichVaThietKeGiaiThuat
{
    public partial class TinhTongWIN : Form
    {
        public TinhTongWIN()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            TinhTong t = new TinhTong();
            lbKQ.Text = t.Tong(int.Parse(txtN.Text)).ToString();
        }
    }
}
