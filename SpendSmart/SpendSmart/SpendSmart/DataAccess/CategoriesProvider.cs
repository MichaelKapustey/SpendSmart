using SpendSmart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpendSmart.DataAccess
{
    public class CategoriesProvider
    {
        private IDataAccessor _dataAccessor;

        public CategoriesProvider(IDataAccessor dataAccessor)
        {
            _dataAccessor = dataAccessor;
        }

        public async Task<List<Category>> GetData()
        {
            return await _dataAccessor.GetDataAsync<Category>();
        }

        public async void Save(Category category)
        {
            await _dataAccessor.SaveDataAsync(category);
        }

    }
}
