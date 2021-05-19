using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace BkmKitap.SQlite
{
    public class Note
    {
        [PrimaryKey,AutoIncrement ]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FileName { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
    }
}
