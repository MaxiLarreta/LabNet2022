using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.UI
{
    internal interface IUI<idType>
    {
        void GetAll();
        bool Add(string name, string phone);
        bool Delete(idType shipperId);
        bool Update(idType shipperId, string shipperPhone);
    }
}
