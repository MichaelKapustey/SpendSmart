using SpendSmart.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SpendSmart.DataAccess
{
    public class SpendingProvider
    {
        private IDataAccessor _dataAccessor;

        public SpendingProvider(IDataAccessor dataAccessor)
        {
            _dataAccessor = dataAccessor;
        }

        public async Task<List<Spending>> GetData()
        {
            return await _dataAccessor.GetDataAsync<Spending>();
        }

        public async void Save(Spending spending)
        {
            await _dataAccessor.SaveDataAsync(new List<Spending> { spending });
        }
    }
}
