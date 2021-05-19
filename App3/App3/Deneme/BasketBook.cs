using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace App3.Deneme
{
    public class BasketBook
    {
        [PrimaryKey, AutoIncrement]
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string Description { get; set; }
        public string BookImage { get; set; }
        public int BookCount { get; set; }
    }
}
