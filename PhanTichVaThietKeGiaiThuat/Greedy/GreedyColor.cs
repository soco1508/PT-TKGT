using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Greedy
{
    public partial class GreedyColor : Form
    {
        List<Vertex> G = new List<Vertex>();
        List<Color> color = new List<Color>();
        public GreedyColor()
        {
            InitializeComponent();
            TaoMau();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen blackPen = new Pen(Color.Black, 2);
            e.Graphics.DrawLine(blackPen, a.Location, b.Location);
            e.Graphics.DrawLine(blackPen, b.Location, f.Location);
            e.Graphics.DrawLine(blackPen, f.Location, c.Location);
            e.Graphics.DrawLine(blackPen, c.Location, _g.Location);
            e.Graphics.DrawLine(blackPen, _g.Location, d.Location);
            e.Graphics.DrawLine(blackPen, b.Location, this.e.Location);
            e.Graphics.DrawLine(blackPen, this.e.Location, c.Location);
            e.Graphics.DrawLine(blackPen, this.e.Location, d.Location);
            e.Graphics.DrawLine(blackPen, d.Location, a.Location);            
        }
        private void TaoList() // Đưa các đỉnh vào List G
        {
            Vertex[] v = new Vertex[7];
            for (int i = 0; i < 7; i++)
                v[i] = new Vertex(i + 1);
            v[0].DinhKe.AddRange(new List<int>() { 2, 4 });
            v[1].DinhKe.AddRange(new List<int>() { 1, 5, 6 });
            v[2].DinhKe.AddRange(new List<int>() { 5, 6, 7 }); // - 6
            v[3].DinhKe.AddRange(new List<int>() { 1, 5, 7 }); // + 6
            v[4].DinhKe.AddRange(new List<int>() { 2, 3, 4 });
            v[5].DinhKe.AddRange(new List<int>() { 2, 3 }); // 2 4 5
            v[6].DinhKe.AddRange(new List<int>() { 3, 4 });
            for (int i = 0; i < 7; i++)
                G.Add(v[i]);
        }
        private void TaoMau()
        {
            color.Add(Color.Yellow);
            color.Add(Color.HotPink);
            color.Add(Color.DarkCyan);
            color.Add(Color.Orange);
            color.Add(Color.Red);
            color.Add(Color.RoyalBlue);
            color.Add(Color.Black);
            color.Add(Color.White);
        }
        private void ToMau()
        {
            ColoringGraph gc = new ColoringGraph();
            int N = gc._ColoringGraph(G);
            List<Vertex> Graph = gc.Graph;
            TapMau.Text = N.ToString();
            a.ForeColor = color[Graph[0].Mau];
            b.ForeColor = color[Graph[1].Mau];
            c.ForeColor = color[Graph[2].Mau];
            d.ForeColor = color[Graph[3].Mau];
            e.ForeColor = color[Graph[4].Mau];
            f.ForeColor = color[Graph[5].Mau];
            _g.ForeColor = color[Graph[6].Mau]; 
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            TaoList();
            ToMau();
        }
    }
}
