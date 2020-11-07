using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RFPanda_dev
{
    class Hunter
    {
        private const string Охотник = "C:\\Users\\RFPanda\\source\\repos\\GameHunter_SW_main_last\\Player.png";
        /* Draw icon Hunter */
        public void Jamis(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(new Bitmap(Охотник), 390, 400);
        }
    }
}


