using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanTichVaThietKeGiaiThuat
{
    class ClosestPair
    {
        public ClosestPairDTO ClosestPairBUS(List<Point> p)
        {
            if (p.Count < 2) return null;
            ClosestPairDTO m = new ClosestPairDTO();
            m.distance = double.MaxValue;
            double temp;
            for (int x = 0; x < p.Count - 1; x++)
            {
                for (int y = x + 1; y < p.Count; y++)
                {
                    temp = CalculateDistance(p[x], p[y]);
                    if (temp < m.distance)
                    {
                        m.distance = temp;
                        m.p1 = p[x];
                        m.p2 = p[y];
                    }
                }
            }
            return m;
        }
        public double CalculateDistance(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow((p1.X - p2.X), 2) + Math.Pow((p1.Y - p2.Y), 2));
        }
    }
    public class ClosestPairDTO
    {
        public double distance { get; set; }
        public Point p1 { get; set; }
        public Point p2 { get; set; }
    }
}
