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

            // Oda ve misafir say�s�n� kontrol et
            bool isRoomValid = int.TryParse(RoomCount.Text, out int rooms);
            bool isGuestValid = int.TryParse(GuestCount.Text, out int guests);

            // Basit do�rulama
            //if (checkOut <= checkIn)
            //{
            //    await DisplayAlert("Hata", "Check-out tarihi, check-in tarihinden sonra olmal�d�r.", "Tamam");
            //    return;
            //}

            if (!isRoomValid || rooms <= 0)
            {
                await DisplayAlert("Hata", "Ge�erli bir oda say�s� girin.", "Tamam");
                return;
            }

            if (!isGuestValid || guests <= 0)
            {
                await DisplayAlert("Hata", "Ge�erli bir misafir say�s� girin.", "Tamam");
                return;
            }

            // Ba�ar�l�ysa (�rnek mesaj)
            //await DisplayAlert("Durum", $"Rezervasyon Aran�yor:\nGiri�: {checkIn:dd MMM yyyy}\n��k��: {checkOut:dd MMM yyyy}\nOda: {rooms}\nMisafir: {guests}", "Tamam");

            // Burada ger�ek rezervasyon API'si �a�r�s� yap�labilir
        }
        //private async void OnExploreRoomsClicked(object sender, EventArgs e)
        //{
        //    await Navigation.PushAsync(new RoomsPage());
        //}
    }
}
