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
        public BookDetailsPage(string Name, string Author, string source)
        {
            InitializeComponent();
            ItemNameShow.Text = Name;
            //AuthorItemShow.Text = Author;
            //ImageCall.Source = new UriImageSource()
            //{
            //    Uri = new Uri(source)
            //};
        }

        private async void AddToBasket(object sender, EventArgs e)
        {
            var book = BindingContext as BasketBook;
            await App.BasketDatabase.SaveBasketBookAsync(book);
            await Navigation.PushAsync(new BasketPage());
        }
    }
}