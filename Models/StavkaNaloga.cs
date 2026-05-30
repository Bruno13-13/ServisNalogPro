using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServisNalogPro.Models
{
    public class StavkaNaloga
    {
        public int IdStavke { get; set; }
        public string Opis { get; set; }
        public decimal Cijena { get; set; }
        public int IdNaloga { get; set; }
    }
}
