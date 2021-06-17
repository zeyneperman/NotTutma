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
        private async void AddNoteButton(object sender, EventArgs e)
        {
            var note = BindingContext as Note;
            await App.Database.SaveNoteAsync(note);
            await Navigation.PopAsync();
        }

        //Handle delete
        private async void DeleteButton(object sender, EventArgs e)
        {
            var note = BindingContext as Note;
            await App.Database.DeleteNoteAsync(note);
            await Navigation.PopAsync();

        }

    }
}