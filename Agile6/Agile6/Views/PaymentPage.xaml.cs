using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Agile6.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaymentPage : ContentPage
    {
        public PaymentPage()
        {
            InitializeComponent();
        }

        async void SubmitButton_Clicked(object sender, EventArgs args)
        {
            await DisplayAlert("Thanks", "Your credit has been added", "Back");
            await Navigation.PopModalAsync();
        }
    }
}