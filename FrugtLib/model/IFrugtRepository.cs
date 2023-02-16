using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrugtLib.model
{
    public interface IFrugtRepository
    {
        List<Frugt> GetAll();
        Frugt GetById(int id);
        Frugt Create(Frugt frugt);
        Frugt Delete(int id);
        Frugt Update(int id, Frugt frugt);
    }
}
