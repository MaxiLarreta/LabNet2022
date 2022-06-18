using MVC.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Logic
{
    public interface ILogic<T, idType> where T : Base
    {
        List<T> GetAll();
        bool Add(T newL);
        bool Delete(idType id);
        bool Update(T newL);
    }
}
