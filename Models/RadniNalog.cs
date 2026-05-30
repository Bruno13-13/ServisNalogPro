using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServisNalogPro.Models
{
    public class RadniNalog
    {
        public int IdNaloga { get; set; }
        public string OpisKvara { get; set; }
        public DateTime Datum { get; set; }
        public string Status{ get; set; }
        public int IdZaposlenika { get; set; }
    }
}
