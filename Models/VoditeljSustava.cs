using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServisNalogPro.Models
{
    public class VoditeljSustava
    {
        public int IdVoditelja { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int IdKorisnika { get; set; }
    }
}
