using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_TeamSuperGao.DAL
{
    public interface IChangeDataBase
    {
        void Add(object o);
        void Edit();
        void Delete();
    }
}
