using System;
using System.Collections.Generic;
using System.Text;

namespace App3.Deneme
{
    public class InMemoryBasketDal
    {
        public List<Book> basketBooks;
        public InMemoryBasketDal()
        {
            basketBooks = new List<Book>();
        }

        public void AddToBasket(Book book)
        {
            basketBooks.Add(book);
        }

        public List<Book> GetAll()
        {
            return basketBooks;
        }
    }
}
