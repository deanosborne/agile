using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Agile6.Services;
using Agile6.Views;

namespace Agile6
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new LoginPage();
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
