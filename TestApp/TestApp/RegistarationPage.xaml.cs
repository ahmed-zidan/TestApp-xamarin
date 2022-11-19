using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistarationPage : ContentPage
    {
        public RegistarationPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(usernameEntry.Text))
            {
                DisplayAlert("Wrong", "please add username", "Ok!");
                return;
            }
            if (string.IsNullOrEmpty(passwordEntry.Text))
            {
                DisplayAlert("Wrong", "please add password", "Ok!");
                return;
            }
            if (string.IsNullOrEmpty(ConfirmPassEntry.Text))
            {
                DisplayAlert("Wrong", "please add confirm pass", "Ok!");
                return;
            }
            if (string.IsNullOrEmpty(emailEntry.Text))
            {
                DisplayAlert("Wrong", "please add email", "Ok!");
                return;
            }

            if(passwordEntry.Text != ConfirmPassEntry.Text)
            {
                DisplayAlert("Wrong", "error with password" ,"Ok!");
                return;
            }

            Navigation.PushAsync(new MainPage());

        }
    }
}