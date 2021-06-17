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
        public string Header { get; set; }
        public string Content { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}
