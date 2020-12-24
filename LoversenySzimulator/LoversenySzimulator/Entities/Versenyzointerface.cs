using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoversenySzimulator.Entities
{
    class Versenyzointerface : Button
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
                    FlatStyle = FlatStyle.Flat;
                    FlatAppearance.BorderColor = System.Drawing.Color.Blue;
                    FlatAppearance.BorderSize = 3;
                }
                else
                {
                    FlatStyle = FlatStyle.Standard;
                    FlatAppearance.BorderColor = System.Drawing.Color.White;
                    FlatAppearance.BorderSize = 1;
                } 
            }
        }

    }
}
