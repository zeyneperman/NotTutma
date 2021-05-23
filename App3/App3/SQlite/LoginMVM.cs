using BkmKitap.SQlite;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App3.SQlite
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public class LoginMVM : ContentPage
    {
        Editor editor;
        Editor editor1;
        Button girisButton;
        StackLayout stackLayout;

        public LoginMVM()
        {
            editor = new Editor
            {
                Placeholder = "Email girişi",
                TextColor = Color.White,
                BackgroundColor = Color.WhiteSmoke,
                AutomationId = "EmailEditor"
            };
            editor1 = new Editor
            {
                Placeholder = "Şifre girişi",
                TextColor = Color.White,
                BackgroundColor = Color.WhiteSmoke,
                AutomationId = "ŞifreEditor"
            };
            girisButton = new Button
            {
                Text = "Giriş",
                BackgroundColor = Color.DarkOrange,
                CornerRadius = 5,
                AutomationId = "GirişButonu"
            };
            girisButton.Clicked += async (sender, e) =>
            {
                foreach (var item in await App.Database.GetNotesAsync())
                {
                    if (item.Password == editor1.Text && item.Email == editor.Text)
                    {
                        editor.Text = "Giriş Başarılı";
                        await Navigation.PushAsync(new NotesPage());
                        break;
                    }
                }
            };
            stackLayout = new StackLayout
            {
                Padding = new Thickness(20, 70, 20, 10),
                Children = { editor, editor1, girisButton}
            };

            Content = new StackLayout
            {
                BackgroundColor = Color.Black,
                Children = { stackLayout }
            };

        }
    }
}
