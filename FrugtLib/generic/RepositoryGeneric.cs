using FrugtLib.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrugtLib.generic
{
    public class RepositoryGeneric<T>:IRepositoryGeneric<T> where T : AbstractModelClass
    {

        private readonly List<T> _repository;

        public RepositoryGeneric()
        {
            _repository = new List<T>();
        }

        public T Create(T obj)
        {
            _repository.Add(obj);
            return obj;
        }

        public T Delete(int id)
        {
            T t = GetById(id);

            _repository.Remove(t);
            return t;
        }

        public List<T> GetAll()
        {
            return new List<T>(_repository);
        }

        public T GetById(int id)
        {
            foreach (T t in _repository)
            {
                if (t.Id == id)
                {
                    return t;
                }
            }

            throw new KeyNotFoundException();
        }

        public T Update(int id, T obj)
        {
            T updateT = GetById(id);

            int ix = _repository.IndexOf(updateT);
            _repository[ix] = obj;

            return obj;
        }
    }
}
