using BkmKitap.SQlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App3.SQlite
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        //List<Note> notes = new List<Note>();
        //protected override async void OnAppearing()
        //{
        //    base.OnAppearing();

        //    foreach (var item in  await App.Database.GetNotesAsync())
        //    {
        //        notes.Add(item);
        //    }
        //}

        private async void Button_Clicked(object sender, EventArgs e)
        {
            //var note = BindingContext as Note;
            foreach (var item in await App.Database.GetNotesAsync())
            {
                if (item.Password == editor1.Text && item.Email == editor.Text)
                {
                    editor.Text = "Giriş Başarılı";
                    break;
                }
            }
        }
    }
}