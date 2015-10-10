using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpendSmart.DataAccess
{
    public interface IDataAccessor
    {
        Task<List<T>> GetDataAsync<T>();

        Task SaveDataAsync(object data);



    }
}
