using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrugtLib.generic
{
    public abstract class AbstractModelClass
    {
        public int Id { get; set; }

        protected AbstractModelClass(int id)
        {
            Id = id;
        }

        protected AbstractModelClass():this(-1)
        {
        }

        public override string ToString()
        {
            return $"{{{nameof(Id)}={Id.ToString()}}}";
        }
    }
}
