using FrugtLib.generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrugtLib.model
{
    public class FrugtRepositoryUsingGenericInterface:IRepositoryGeneric<NyFrugt>
    {
        private readonly List<NyFrugt> _repository;

        public FrugtRepositoryUsingGenericInterface()
        {
            _repository = new List<NyFrugt>();
        }

        public NyFrugt Create(NyFrugt frugt)
        {
            _repository.Add(frugt);
            return frugt;
        }

        public NyFrugt Delete(int id)
        {
            NyFrugt frugt = GetById(id);

            _repository.Remove(frugt);
            return frugt;
        }

        public List<NyFrugt> GetAll()
        {
            return new List<NyFrugt>(_repository);
        }

        public NyFrugt GetById(int id)
        {
            foreach (NyFrugt f in _repository)
            {
                if (f.Id == id)
                {
                    return f;
                }
            }

            throw new KeyNotFoundException();
        }

        public NyFrugt Update(int id, NyFrugt frugt)
        {
            NyFrugt updateFrugt = GetById(id);

            int ix = _repository.IndexOf(updateFrugt);
            _repository[ix] = frugt;

            return frugt;
        }
    }
}
