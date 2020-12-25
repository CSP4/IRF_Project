using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoversenySzimulator.Entities
{

    class Lovacska : Label
    {
        public int VersenyzoID { get; set; }
        public Lovacska()
        {
            AutoSize = false;
            Width = 30;
            Height = 19;
            Paint += Lovacska_Paint;
            BackColor = Color.Transparent;
        }

        private void Lovacska_Paint(object sender, PaintEventArgs e)
        {
            Rajz(e.Graphics);
        }

        public void Rajz(Graphics g)
        {
            Image imageFile = Image.FromFile("Images/lo"+(VersenyzoID+1)+".png");
            g.DrawImage(imageFile, new Rectangle(0, 0, Width, Height));
        }

        public void Fut(int szint)
        {
            Random rnd = new Random();
            Left+=rnd.Next(szint) + 5;
        }
    }



}
