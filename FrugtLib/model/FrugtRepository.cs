using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrugtLib.model
{
    public class FrugtRepository : IFrugtRepository
    {
        private readonly List<Frugt> _repository;

        public FrugtRepository()
        {
            _repository = new List<Frugt>();
        }

        public Frugt Create(Frugt frugt)
        {
            _repository.Add(frugt);
            return frugt;
        }

        public Frugt Delete(int id)
        {
            Frugt frugt = GetById(id);

            _repository.Remove(frugt);
            return frugt;
        }

        public List<Frugt> GetAll()
        {
            return new List<Frugt>(_repository);
        }

        public Frugt GetById(int id)
        {
            foreach(Frugt f in _repository)
            {
                if (f.Id == id)
                {
                    return f;
                }
            }

            throw new KeyNotFoundException();
        }

        public Frugt Update(int id, Frugt frugt)
        {
            Frugt updateFrugt = GetById(id);

            int ix = _repository.IndexOf(updateFrugt);
            _repository[ix] = frugt;

            return frugt;
        }
    }
}
