using App3;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BkmKitap.SQlite
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NoteEntryPage : ContentPage
    {
        public NoteEntryPage()
        {
            InitializeComponent();
        }


        //Handle Save
        private async void Button_Clicked(object sender, EventArgs e)
        {
            var note = BindingContext as Note;

            note.Date = DateTime.Now;
            await App.Database.SaveNoteAsync(note);
            await Navigation.PopAsync();
        }

        //Handle delete
        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            var note = BindingContext as Note;
            await App.Database.DeleteNoteAsync(note);
            await Navigation.PopAsync();

        }
    }
}