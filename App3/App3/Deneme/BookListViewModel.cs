using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace App3.Deneme
{
    public class BookListViewModel : BindableObject
    {
        public BookListViewModel()
        {
            GetGeneralHistoryBooks();
        }
        List<Book> _booksLiterature;
        public List<Book> GetAll()
        {
            _booksLiterature = new List<Book>
            {
                new Book
                {
                    BookId=6,BookName="Suç ve ceza",Description="Fyodor Dostoevsky",
                    BookImage="https://cdn.bkmkitap.com/suc-ve-ceza-356792-8092568-35-O.jpg",BookCount = 1
                },
                new Book
                {
                    BookId=7,BookName="Amcanın Rüyası",Description="Fyodor Dostoevsky",
                    BookImage="https://cdn.bkmkitap.com/amcanin-ruyasi-378274-1182654-37-O.jpg",BookCount = 1
                },
                new Book
                {
                    BookId=8,BookName="Öteki", Description="Fyodor Dostoevsky",
                    BookImage="https://cdn.bkmkitap.com/oteki-133194-7630563-13-K.jpg",BookCount = 1
                },
                new Book
                {
                    BookId=9,BookName="Yufka Yürekli",Description="Fyodor Dostoevsky",
                    BookImage="https://cdn.bkmkitap.com/bir-yufka-yurekli-soytari-7121144-17-K.jpg",BookCount = 1
                },
                new Book
                {
                    BookId=10,BookName="Büyük Umutlar",Description="Charles Dicknes",
                    BookImage="https://cdn.bkmkitap.com/buyuk-umutlar-356797-8114470-35-K.jpg",BookCount = 1
                },
                new Book
                {
                    BookId=11,BookName="Kazaklar", Description="Lev Nikolayeviç Tolstoy",
                    BookImage="https://cdn.bkmkitap.com/kazaklar-424758-7121550-42-K.jpg",BookCount = 1
                }
            };
            return _booksLiterature;
        }
        private void GetGeneralHistoryBooks()
        {
            foreach (var book in GetAll())
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
