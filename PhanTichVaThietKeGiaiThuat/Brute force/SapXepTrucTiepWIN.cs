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
    public partial class SapXepTrucTiepWIN : Form
    {
        
        public SapXepTrucTiepWIN()
        {
            InitializeComponent();
            txtInput.Text = "11\r\n3\r\n9\r\n22\r\n10\r\n5\r\n4\r\n7\r\n15\r\n2\r\n1\r\n0";
        }

        private void SapXepTrucTiepWIN_Load(object sender, EventArgs e)
        {
            
        }
        int[] nhap, xuat;
        int n;
        private void btnSapXep_Click(object sender, EventArgs e)
        {
            DocDuLieu();
            SapXep();
            XuatDuLieu();
        }
        private void DocDuLieu()
        {
            n = txtInput.Lines.Length;
            nhap = new int[n];
            xuat = new int[n];
            int i = 0;
            foreach (string line in txtInput.Lines)
            {
                nhap[i++] = int.Parse(line);
            }
        }
        private void SapXep()
        {
            SapXepTrucTiep sx = new SapXepTrucTiep();
            xuat = sx.Sort(nhap, n);
        }
        private void XuatDuLieu()
        {
            txtOutput.Text = "";
            for(int i = 0; i < n; i++)
            {
                txtOutput.Text += xuat[i] + "\r\n";
            }
        }
    }
}
