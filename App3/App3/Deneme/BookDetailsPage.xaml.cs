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
    public partial class BookDetailsPage : ContentPage
    {
        public BookDetailsPage()
        {
            InitializeComponent();
        }

        private async void AddToBasket(object sender, EventArgs e)
        {
            var book = BindingContext as Book;

            await App.Database.SaveBookAsync(book);

            await Navigation.PushAsync(new BasketPage()
            { 
                BindingContext = await App.Database.GetBooksAsync()
            });
        }
    }
}