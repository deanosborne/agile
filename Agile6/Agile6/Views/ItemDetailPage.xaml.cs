using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Agile6.Models;
using Agile6.ViewModels;

namespace Agile6.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class ItemDetailPage : ContentPage
    {
        ItemDetailViewModel viewModel;

        public ItemDetailPage(ItemDetailViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }

        public ItemDetailPage()
        {
            InitializeComponent();

            var item = new Item
            {
                Text = "Item 1",
                Description = "This is an item description.",
                Price = "1123",
            };

            viewModel = new ItemDetailViewModel(item);
            BindingContext = viewModel;
        }

        async void OrderButton_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Thanks", "Your coffee has been ordered", "Back");
            await Navigation.PopAsync();
        }
    }
}