using CarEvents.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CarEvents.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        async void SignInProcedure(object sender, EventArgs args)
        {
            //await label.RelRotateTo(360, 1000);
            User user = new User(Entry_Username.Text, Entry_Password.Text);
            if (user.checkInformation())
            {
                await Navigation.PushModalAsync(new NavigationPage(new ItemsPage()));
                DisplayAlert("Login", "LoginSuccess", "Oke");
            }
            else
            {
                DisplayAlert("Login", "not Success", "Oke");
            }

        }
    }
}