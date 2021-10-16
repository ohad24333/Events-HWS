using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events2.Librery
{
    public class Square : Shape
    {
        public override event EventHandler Outch;
        protected override void OnOutch(object sender, EventArgs e)
        {
            var s = sender as Point;
            if (s.X >= TopRight.X && s.X <= TopRight.X + Lenght )
            {
                Outch(sender, e);
            }

            if (s.Y >= TopRight.Y && s.Y <= TopRight.Y + Lenght)
            {
                Outch(sender, e);
            }
        }

    }
}
