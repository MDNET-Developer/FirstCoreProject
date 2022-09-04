using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    internal interface IGenericService<T>
    {
        void TInsert(T t);
        void TUpdate(T t);
        void TRemove(T t);
        T TGetById(int id);
        List<T> TGetAll();
    }
}
