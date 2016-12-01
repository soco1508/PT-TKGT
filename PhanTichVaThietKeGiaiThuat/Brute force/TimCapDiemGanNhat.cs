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
    public partial class TimCapDiemGanNhat : Form
    {
        List<Point> p = new List<Point>();
        public TimCapDiemGanNhat()
        {
            InitializeComponent();
            txtInput.Text = "20 22\r\n300 150\r\n190 60\r\n50 70\r\n0 250\r\n430 15\r\n50 110";
        }

        private void TimCapDiemGanNhat_Load(object sender, EventArgs e)
        {
            
        }
        public void Read()
        {
            p.Clear();
            string[] dot;
            Point point;
            int i;
            foreach (string line in txtInput.Lines)
            {
                i = 0;
                point = new Point();
                dot = new string[2];
                foreach (char c in line)
                {
                    if (c.ToString() == " ")
                    {
                        i++;
                        continue;
                    }
                    dot[i] += c;
                }
                point.X = int.Parse(dot[0]);
                point.Y = int.Parse(dot[1]);
                p.Add(point);
            }
        }
        private void Display()
        {
            panel1.Controls.Clear();
            foreach (Point pt in p)
            {
                Label label = new Label()
                {
                    Text = "(" + pt.X + "," + pt.Y + ")",
                    Location = pt,
                    BackColor = Color.Transparent
                };
                panel1.Controls.Add(label);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            Read();
            Display();
            ClosestPair findmin = new ClosestPair();
            ClosestPairDTO min = new ClosestPairDTO();
            min = findmin.ClosestPairBUS(p);
            lbPoints.Text = "(" + min.p1.X + "," + min.p1.Y + ")" + " và (" + min.p2.X + "," + min.p2.Y + ")";
            lbDistance.Text = min.distance.ToString();
        }
    }
}
