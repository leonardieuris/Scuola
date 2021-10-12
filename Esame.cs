using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scuola
{
    public class Esame
    {
        public int Voto { get; set; }
        public Materie Materia { get; set; }
        public Insegnanti Insegnante { get; set; }
        public Studenti Studenti { get; set; }
        public DateTime Data { get; set; }

        public bool Lode { get; set; }


    }
}
