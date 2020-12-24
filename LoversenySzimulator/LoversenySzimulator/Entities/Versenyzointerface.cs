﻿using System;
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
                    BorderStyle = BorderStyle.Fixed3D;
                }
                else
                {
                    BorderStyle = BorderStyle.None;
                } 
            }
        }
        public Versenyzointerface()
        {
            Height = 110;
            Width = 75;
            BackColor = Color.LightSalmon;
        }

    }
}
