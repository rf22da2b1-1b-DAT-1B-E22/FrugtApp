using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrugtLib.model
{
    public class Frugt
    {
        public int Id { get; set; }
        public string Navn { get; set; }
        public double Pris { get; set; }

        public Frugt(int id, string navn, double pris)
        {
            Id = id;
            Navn = navn;
            Pris = pris;
        }

        public Frugt()
        {
            Id = -1;
            Navn = "";
            Pris = 0;
        }

        public override string ToString()
        {
            return $"{{{nameof(Id)}={Id.ToString()}, {nameof(Navn)}={Navn}, {nameof(Pris)}={Pris.ToString()}}}";
        }
    }
}
