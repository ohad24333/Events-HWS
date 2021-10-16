using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events2.Librery
{
    public class Dot : Shape
    {
        public override event EventHandler Outch;

        protected override void OnOutch(object sender, EventArgs e)
        {
            Point p = sender as Point;
            if(p.X == TopRight.X && p.Y == TopRight.Y)
            {
                Outch(sender, e);
            }
        }

    }
}
