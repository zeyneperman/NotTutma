using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using App3;
using App3.Deneme;
using SQLite;

namespace BkmKitap.SQlite
{
    public class NoteDatabase
    {
        readonly SQLiteAsyncConnection _database;
        public NoteDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Note>();
            _database.CreateTableAsync<Book>();
            _database.CreateTableAsync<BasketBook>();
        }

        public Task<List<BasketBook>> GetBasketBooksAsync()
        {
            return _database.Table<BasketBook>().ToListAsync();
        }

        public Task<int> SaveBasketBookAsync(BasketBook book)
        {
            return _database.InsertAsync(book);
        }

        public Task<int> DeleteBasketBookAsync(BasketBook book)
        {
            return _database.DeleteAsync(book);
        }

        // // // // // // // // //

        public Task<List<Book>> GetBooksAsync()
        {
            return _database.Table<Book>().ToListAsync();
        }

        public Task<int> SaveBookAsync(Book book)
        {
            return _database.InsertAsync(book);
        }

        public Task<int> DeleteBookAsync(Book book)
        {
            return _database.DeleteAsync(book);
        }

        // // // // // // // // //

        public Task<List<Note>> GetNotesAsync()
        {
            return _database.Table<Note>().ToListAsync();
        }

        public Task<int> SaveNoteAsync(Note note)
        {
            if(note.Id != 0)
            {
                return _database.UpdateAsync(note);
            }
            else
                return _database.InsertAsync(note);
        }

        public Task<int> DeleteNoteAsync(Note note)
        {
            return _database.DeleteAsync(note);
        }
    }
}
