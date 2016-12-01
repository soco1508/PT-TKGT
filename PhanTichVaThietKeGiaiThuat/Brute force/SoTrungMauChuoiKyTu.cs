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
    public partial class SoTrungMauChuoiKyTu : Form
    {
        public SoTrungMauChuoiKyTu()
        {
            InitializeComponent();            
        }

        private void SoTrungMauChuoiKyTu_Load(object sender, EventArgs e)
        {

        }

        private void btnSoChuoi_Click(object sender, EventArgs e)
        {
            SoTrungMau s = new SoTrungMau();
            MessageBox.Show("Mẫu có xuất hiện trong chuỗi và ở ký tự thứ " + s.StringMatch(txtChuoi.Text, txtMau.Text).ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
