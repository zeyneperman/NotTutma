using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App3.Deneme
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BookListPage : ContentPage
    {
        public BookListPage()
        {
            InitializeComponent();
            BindingContext = new BookListViewModel();
        }

        private async void BooksListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var mydetails = e.Item as Book;
            await Navigation.PushAsync(new BookDetailsPage()
            {
                BindingContext = mydetails
            });
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BasketPage());
        }
    }
}