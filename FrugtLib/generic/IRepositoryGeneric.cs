using FrugtLib.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrugtLib.generic
{
    public interface IRepositoryGeneric<T>
    {
        List<T> GetAll();
        T GetById(int id);
        T Create(T obj);
        T Delete(int id);
        T Update(int id, T obj);
    }
}
