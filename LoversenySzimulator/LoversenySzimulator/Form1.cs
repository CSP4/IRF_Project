using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoversenySzimulator.Entities;

namespace LoversenySzimulator
{
    public partial class Form1 : Form   
    {
        LoversenyAdatbazisEntities context = new LoversenyAdatbazisEntities();
        List<Lovacska> Babuk = new List<Lovacska>();
        List<Versenyzo> Versenyzok = new List<Versenyzo>();
        List<Versenyzointerface> VersenyzoGombok = new List<Versenyzointerface>();
        public Form1()
        {
            InitializeComponent();
            panelPalya.BackgroundImage = Image.FromFile("Images/runfield.jpg");
            
        }

        private void buttonUjVerseny_Click(object sender, EventArgs e)
        {
            panel3as.Enabled = true;
            panelHelyezes.Enabled = true;
            panelFogadasTipus.Enabled = true;
            buttonUjVerseny.Enabled = false;
            buttonVersenyStart.Enabled = true;



            Random rnd = new Random();

            for (int i = 0; i < 4; i++)
            {
                Versenyzo v = new Versenyzo();
                v.VersenyzoID = i + 1;
                v.LoID = rnd.Next(LoDB()+1);
                Versenyzok.Add(v);

            }
        }

        public int LoDB()
        {
            int i = (from x in context.Horses
                     select x).Count();
          
            return i;
        }

        public string LoNev(int id)
        {
            string s = (from x in context.Horses
                        where x.HorseID == id
                        select x.HorseName).FirstOrDefault();
            return s;
        }
    }
}
