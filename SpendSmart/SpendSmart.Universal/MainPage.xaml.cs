using SpendSmart.DataAccess;
using SpendSmart.Models;
using SpendSmart.Universal.Logic;
using SpendSmart.Universal.Spendings;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Документацию по шаблону элемента "Пустая страница" см. по адресу http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace SpendSmart.Universal
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
          
        }

        public async void Do()
        {
            JsonDataAccessor js = new JsonDataAccessor(new FileAccessor());
            object data=await js.GetDataAsync<Category>();

        }

        private void ButtonStatistics_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void ButtonSpendings_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(SpendingsPage));
        }

        private void ButtonCategories_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(CategoriesView));
        }
    }
}
