using System;
using System.Linq;
using Xamarin.Forms;

namespace CustomizableListView
{
    public partial class SongsPage : ContentPage
    {
        private ViewModel viewModel = new ViewModel();

        public SongsPage()
        {
            InitializeComponent();
            this.BindingContext = this.viewModel;
        }

        private void LoveButtonClick(object sender, EventArgs e)
        {
            var song = (sender as Button).BindingContext as Song;
            song.IsFavourite = !song.IsFavourite;
        }

        private void DeleteButtonClick(object sender, EventArgs e)
        {
            var song = (sender as Button).BindingContext as Song;
            this.viewModel.Songs.Remove(song);
        }
    }
}