using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirLiteApiCore.DBUtil
{
    interface IManage<T>
    {
        IEnumerable<T> GetAll();
        T Get(int id);
    }
}
