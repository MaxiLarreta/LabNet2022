using EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Logic
{
    public interface ILogic<T, idType> where T : Base
    {
        List<T> GetAll();
        void Add(T newL);
        void Delete(idType id);
        void Update(T newL);
    }
}
