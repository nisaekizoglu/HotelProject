using System;
using Microsoft.Maui.Controls;
using HotelProjectMauiApp.Pages;

namespace HotelProjectMauiApp.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCheckAvailabilityClicked(object sender, EventArgs e)
        {
            // Tarihleri al
            //DateTime checkIn = CheckInDate.Date;
            //DateTime checkOut = CheckOutDate.Date;

            // Oda ve misafir sayýsýný kontrol et
            bool isRoomValid = int.TryParse(RoomCount.Text, out int rooms);
            bool isGuestValid = int.TryParse(GuestCount.Text, out int guests);

            // Basit doðrulama
            //if (checkOut <= checkIn)
            //{
            //    await DisplayAlert("Hata", "Check-out tarihi, check-in tarihinden sonra olmalýdýr.", "Tamam");
            //    return;
            //}

            if (!isRoomValid || rooms <= 0)
            {
                await DisplayAlert("Hata", "Geçerli bir oda sayýsý girin.", "Tamam");
                return;
            }

            if (!isGuestValid || guests <= 0)
            {
                await DisplayAlert("Hata", "Geçerli bir misafir sayýsý girin.", "Tamam");
                return;
            }

            // Baþarýlýysa (örnek mesaj)
            //await DisplayAlert("Durum", $"Rezervasyon Aranýyor:\nGiriþ: {checkIn:dd MMM yyyy}\nÇýkýþ: {checkOut:dd MMM yyyy}\nOda: {rooms}\nMisafir: {guests}", "Tamam");

            // Burada gerçek rezervasyon API'si çaðrýsý yapýlabilir
        }
        //private async void OnExploreRoomsClicked(object sender, EventArgs e)
        //{
        //    await Navigation.PushAsync(new RoomsPage());
        //}
    }
}
