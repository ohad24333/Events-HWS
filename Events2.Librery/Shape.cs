using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events2.Librery
{
    public class Shape
    {
        public virtual event EventHandler Outch;

        public Point TopRight { get; set; }

        public int Lenght { get; set; }
        protected virtual void OnOutch(object sender,EventArgs e)
        {
            if (Outch != null)
            {
                Outch(sender, e);
            }
        }

    }


}
