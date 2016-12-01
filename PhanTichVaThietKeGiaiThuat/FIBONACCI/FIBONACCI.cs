using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIBONACCI
{
    public partial class FIBONACCI : Form
    {
        public FIBONACCI()
        {
            InitializeComponent();
        }

        private void btnQHD_Click(object sender, EventArgs e)
        {
            ChienLuocQuiHoachDong c = new ChienLuocQuiHoachDong();
            MessageBox.Show((c.GetValue(int.Parse(txtN.Text))).ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTT_Click(object sender, EventArgs e)
        {
            ChienLuocTrucTiep c = new ChienLuocTrucTiep();
            MessageBox.Show((c.GetValue(int.Parse(txtN.Text))).ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
