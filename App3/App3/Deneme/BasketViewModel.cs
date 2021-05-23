using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace App3.Deneme
{
    public class BasketViewModel : BindableObject
    {
        InMemoryBasketDal basketDal = new InMemoryBasketDal();

        List<Book> basketBooks;

        public BasketViewModel()
        {
            GetBasketBooks();
            basketBooks = new List<Book>();
        }

        private void GetBasketBooks()
        {
            foreach (var book in basketBooks)
            {
                Items.Add(book);
            }
        }

        private ObservableCollection<Book> _items = new ObservableCollection<Book>();
        public ObservableCollection<Book> Items
        {
            get
            {
                return _items;
            }
            set
            {
                if (_items != value)
                {
                    _items = value;
                    OnPropertyChanged(nameof(Items));
                }
            }
        }
    }
}
