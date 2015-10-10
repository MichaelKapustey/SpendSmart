using SpendSmart.DataAccess;
using SpendSmart.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpendSmart.Universal.Spendings
{
    class SpendingsViewModel
    {

        private SpendingProvider spendingProvider = new SpendingProvider(null);
        private CategoriesProvider categoriesProvider = new CategoriesProvider(null);

        public ObservableCollection<Spending> Spendings { get; set; }

        public ObservableCollection<Category> Categories { get; set; }

        public DateTime Date { get; set; }

        public async Task InitializeData()
        {
            Spendings = new ObservableCollection<Spending>(await spendingProvider.GetData());
            Categories = new ObservableCollection<Category>(await categoriesProvider.GetData());
        }

        
    }

}

