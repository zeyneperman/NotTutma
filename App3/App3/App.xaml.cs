using App3.Deneme;
using App3.SQlite;
using BkmKitap.SQlite;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App3
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            FolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData));

            MainPage = new NavigationPage(new LoginMVM()); //NotesPage

        }

        public static string FolderPath { get; private set; }

        public static NoteDatabase database { get; set; }
        public static NoteDatabase Database
        {
            get
            {
                if (database == null)
                    database = new NoteDatabase(Path.Combine(App.FolderPath, "BooksDb.db3")); //
                return database;
            }
        }

        public static NoteDatabase bkmdatabase { get; set; }
        public static NoteDatabase BkmDatabase
        {
            get
            {
                if (database == null)
                    database = new NoteDatabase(Path.Combine(App.FolderPath, "NotesDb.db3"));
                return database;
            }
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
