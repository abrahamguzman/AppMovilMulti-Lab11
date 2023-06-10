using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab11XamarinOpe
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Lab11XamarinOpe.Views.CalculatorPage();
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
