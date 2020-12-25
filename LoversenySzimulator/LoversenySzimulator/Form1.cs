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
        Fogadas f = new Fogadas();
        bool ujverseny;
        public Form1()
        {
            InitializeComponent();
            panelPalya.BackgroundImage = Image.FromFile("Images/runfield.jpg");
            
        }

        private void buttonUjVerseny_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            bool ugyanaz = false;

            panel3as.Enabled = true;
            panelHelyezes.Enabled = true;
            panelFogadasTipus.Enabled = true;
            buttonUjVerseny.Enabled = false;
            buttonVersenyStart.Enabled = true;

            ujverseny = true;
            comboBoxVersenyzo.SelectedIndex = 0;
            comboBoxHelyezes.SelectedIndex = 0;
            comboBox1hely.SelectedIndex = 0;
            comboBox2hely.SelectedIndex = 1;
            comboBox3hely.SelectedIndex = 2;
            ujverseny = false;

            for (int i = 0; i < 5; i++)
            {
                Versenyzo v = new Versenyzo();
                v.VersenyzoID = i;
                do
                {
                    ugyanaz = false;
                    v.LoID = rnd.Next(LoDB()) + 1;
                    for (int j = 0; j < Versenyzok.Count(); j++)
                    {
                        if (Versenyzok[j].LoID==v.LoID) ugyanaz = true;
                    }
                } while (ugyanaz);
                v.LoNev = LoNev(v.LoID);
                do
                {
                    ugyanaz = false;
                    v.ZsokeID = rnd.Next(ZsokeDB()) + 1;
                    for (int j = 0; j < Versenyzok.Count(); j++)
                    {
                        if (Versenyzok[j].ZsokeID == v.ZsokeID) ugyanaz = true;
                    }
                } while (ugyanaz);
                v.Zsokenev = ZsokeNev(v.ZsokeID);
                v.LoEredmeny = LoEredmeny(v.LoID);
                v.ZsokeEredmeny = ZsokeEredmeny(v.ZsokeID);
                v.Eredmeny = default;
                Versenyzok.Add(v);

                Versenyzointerface vi = new Versenyzointerface();
                vi.VersenyzoID = v.VersenyzoID;
                vi.Text = "Ló:" + v.LoNev + "Zsoké:" + v.Zsokenev + "Szint: " + v.Eredmeny;
                Image imageFile = Image.FromFile("Images/lo" + (vi.VersenyzoID + 1) + ".png");
                vi.Image = imageFile;
                vi.ImageAlign = ContentAlignment.BottomCenter;
                VersenyzoGombok.Add(vi);

                Lovacska lo = new Lovacska();
                lo.VersenyzoID = v.VersenyzoID;
                Babuk.Add(lo);
                
            }

            f.Helyezes = comboBoxHelyezes.SelectedIndex;
            f.VersenyzoID = comboBoxVersenyzo.SelectedIndex;
            f.Elso = comboBox1hely.SelectedIndex;
            f.Masodik = comboBox2hely.SelectedIndex;
            f.Harmadik = comboBox3hely.SelectedIndex;

            VersenyzoGombok[f.VersenyzoID].Aktive = true;

            for (int k = 0; k < VersenyzoGombok.Count; k++)
            {
                VersenyzoGombok[k].Left = k * (VersenyzoGombok[k].Width + 5);
                panelVersenyzok.Controls.Add(VersenyzoGombok[k]);
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

        public int ZsokeDB()
        {
            int i = (from x in context.Jockeys
                     select x).Count();

            return i;
        }

        public string ZsokeNev(int id)
        {
            string s = (from x in context.Jockeys
                        where x.JockeyID == id
                        select x.JockeyName).FirstOrDefault();
            return s;
        }

        public int LoEredmeny(int id)
        {
            int elso = (from x in context.Races
                        where x.H1 == id
                        select x).Count();
            int masodik = (from x in context.Races
                        where x.H2 == id
                        select x).Count();
            int harmadik = (from x in context.Races
                        where x.H3 == id
                        select x).Count();
            int negyedik = (from x in context.Races
                        where x.H4 == id
                        select x).Count();
            int otodik = (from x in context.Races
                        where x.H5 == id
                        select x).Count();

            if (elso + masodik + harmadik + negyedik + otodik != 0)
                return ((elso * 5 + masodik * 4 + harmadik * 3 + negyedik * 2 + otodik * 1) * 3 / (elso + masodik + harmadik + negyedik + otodik));
            else return 7;
        }

        public int ZsokeEredmeny(int id)
        {
            int elso = (from x in context.Races
                        where x.J1 == id
                        select x).Count();
            int masodik = (from x in context.Races
                           where x.J2 == id
                           select x).Count();
            int harmadik = (from x in context.Races
                            where x.J3 == id
                            select x).Count();
            int negyedik = (from x in context.Races
                            where x.J4 == id
                            select x).Count();
            int otodik = (from x in context.Races
                          where x.J5 == id
                          select x).Count();

            if (elso + masodik + harmadik + negyedik + otodik != 0)
                return ((elso * 5 + masodik * 4 + harmadik * 3 + negyedik * 2 + otodik * 1) * 3 / (elso + masodik + harmadik + negyedik + otodik));
            else return 7;
        }

        private void radio3as_CheckedChanged(object sender, EventArgs e)
        {
            panel3as.Top = 12;
            panelHelyezes.Top = -175;
            VersenyzoGombok[f.VersenyzoID].Aktive = false;
            VersenyzoGombok[f.Elso].Aktive = true;
            VersenyzoGombok[f.Masodik].Aktive = true;
            VersenyzoGombok[f.Harmadik].Aktive = true;
        }

        private void radioHelyezes_CheckedChanged(object sender, EventArgs e)
        {
            panel3as.Top = -175;
            panelHelyezes.Top = 12;
            VersenyzoGombok[f.Elso].Aktive = false;
            VersenyzoGombok[f.Masodik].Aktive = false;
            VersenyzoGombok[f.Harmadik].Aktive = false;
            VersenyzoGombok[f.VersenyzoID].Aktive = true;
        }

        private void comboBox1hely_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!ujverseny)
            {
                VersenyzoGombok[f.Elso].Aktive = false;
                if (comboBox1hely.SelectedIndex == comboBox2hely.SelectedIndex)
                {
                    if (comboBox2hely.SelectedIndex < 4) comboBox2hely.SelectedIndex++;
                    else comboBox2hely.SelectedIndex = 0;
                }
                if (comboBox1hely.SelectedIndex == comboBox3hely.SelectedIndex)
                {
                    if (comboBox3hely.SelectedIndex < 4) comboBox3hely.SelectedIndex++;
                    else comboBox3hely.SelectedIndex = 0;
                }
                f.Elso = comboBox1hely.SelectedIndex;
                VersenyzoGombok[f.Elso].Aktive = true;
            }
        }

        private void comboBox2hely_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!ujverseny)
            { 
                VersenyzoGombok[f.Masodik].Aktive = false;
                if (comboBox2hely.SelectedIndex == comboBox1hely.SelectedIndex)
                {
                    if (comboBox1hely.SelectedIndex < 4) comboBox1hely.SelectedIndex++;
                    else comboBox1hely.SelectedIndex = 0;
                }
                if (comboBox2hely.SelectedIndex == comboBox3hely.SelectedIndex)
                {
                    if (comboBox3hely.SelectedIndex < 4) comboBox3hely.SelectedIndex++;
                    else comboBox3hely.SelectedIndex = 0;
                }
                f.Masodik = comboBox2hely.SelectedIndex;
                VersenyzoGombok[f.Masodik].Aktive = true;
            }
        }

        private void comboBox3hely_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!ujverseny)
            {
                VersenyzoGombok[f.Harmadik].Aktive = false;
                if (comboBox3hely.SelectedIndex == comboBox1hely.SelectedIndex)
                {
                    if (comboBox1hely.SelectedIndex < 4) comboBox1hely.SelectedIndex++;
                    else comboBox1hely.SelectedIndex = 0;
                }
                if (comboBox3hely.SelectedIndex == comboBox2hely.SelectedIndex)
                {
                    if (comboBox2hely.SelectedIndex < 4) comboBox2hely.SelectedIndex++;
                    else comboBox2hely.SelectedIndex = 0;
                }
                f.Harmadik = comboBox3hely.SelectedIndex;
                VersenyzoGombok[f.Harmadik].Aktive = true;
            }
        }

        private void comboBoxHelyezes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!ujverseny) f.Helyezes = comboBoxHelyezes.SelectedIndex;
        }

        private void comboBoxVersenyzo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!ujverseny)
            {
                VersenyzoGombok[f.VersenyzoID].Aktive = false;
                f.VersenyzoID = comboBoxVersenyzo.SelectedIndex;
                VersenyzoGombok[f.VersenyzoID].Aktive = true;
            }
        }
    }
}
