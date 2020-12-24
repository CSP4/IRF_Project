using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoversenySzimulator.Entities
{
    class Versenyzo
    {
        public int VersenyzoID { get; set; }
        public int LoID { get; set; }
        public string LoNev { get; set; }
        public int ZsokeID { get; set; }
        public string Zsokenev { get; set; }
        public int LoEredmeny { get; set; }
        public int ZsokeEredmeny { get; set; }
        private int _eredmeny;

        public int Eredmeny
        {
            get { return _eredmeny; }
            set 
            {
                value = (LoEredmeny + ZsokeEredmeny) / 2;
                _eredmeny = value; 
            }
        }


    }
}
