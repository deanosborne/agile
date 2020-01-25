using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Agile6.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class R2Page : ContentPage
    {
        public R2Page()
        {
            InitializeComponent();
        }

        SearchBar searchBar = new SearchBar
        {
            Placeholder = "Search items...",
            PlaceholderColor = Color.Gray,
            TextColor = Color.Gray,
            HorizontalTextAlignment = TextAlignment.Center,
            FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(SearchBar)),
            FontAttributes = FontAttributes.Italic
        };
    }
}