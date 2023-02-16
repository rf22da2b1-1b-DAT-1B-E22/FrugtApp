using FrugtLib.generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrugtLib.model
{
    public class NyFrugt:AbstractModelClass
    {
        public string Navn { get; set; }
        public double Pris { get; set; }

        public NyFrugt(int id, string navn, double pris):base(id)
        {
            Navn = navn;
            Pris = pris;
        }

        public NyFrugt():base(-1)
        {
            Navn = "";
            Pris = 0;
        }

        public override string ToString()
        {
            return $"{{{base.ToString()}, {nameof(Navn)}={Navn}, {nameof(Pris)}={Pris.ToString()}}}";
        }

    }
}
