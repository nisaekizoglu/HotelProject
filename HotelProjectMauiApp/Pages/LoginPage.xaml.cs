using System;
using Microsoft.Maui.Controls;

namespace HotelProjectMauiApp.Pages
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void OnLoginClicked(object sender, EventArgs e)
        {
            string email = EmailEntry.Text?.Trim();
            string password = PasswordEntry.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                await DisplayAlert("Hata", "Lütfen tüm alanları doldurun.", "Tamam");
                return;
            }

            // Gerçek kimlik doğrulama işlemi burada yapılabilir
            // Şimdilik doğrudan başarılı varsayıyoruz
            await DisplayAlert("Başarılı", "Giriş yapıldı!", "Tamam");

            // MainPage'e yönlendir ve LoginPage'i yığından kaldır
            Application.Current.MainPage = new NavigationPage(new MainPage());
        }

        private async void OnNavigateToRegister(object sender, EventArgs e)
        {
            // Kayıt sayfasına yönlendirme
            await Navigation.PushAsync(new RegisterPage());
        }
    }
}
