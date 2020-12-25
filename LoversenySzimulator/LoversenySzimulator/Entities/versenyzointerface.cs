using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoversenySzimulator.Entities
{
    class Versenyzointerface : Label
    {
        public int VersenyzoID { get; set; }

        private bool _aktive;

        public bool Aktive
        {
            get { return _aktive; }
            set 
            {
                _aktive = value;
                if (_aktive)
                {
                    BackColor= Color.PaleTurquoise;
                }
                else
                {
                    BackColor = Color.LightSalmon;
                } 
            }
        }
        public Versenyzointerface()
        {
            Height = 110;
            Width = 80;
            BackColor = Color.LightSalmon;
        }

    }
}
