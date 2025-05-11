using System;
using Microsoft.Maui.Controls;
using HotelProjectMauiApp.Pages;
using System.Collections.ObjectModel;

namespace HotelProjectMauiApp.Pages
{
    public class Room
    {
        public string? Name { get; set; }
        public string? Image { get; set; }
        public string? Price { get; set; }
    }

    public class Testimonial
    {
        public string? Author { get; set; }
        public string? Image { get; set; }
        public string? Text { get; set; }
    }

    public partial class MainPage : ContentPage
    {
        public ObservableCollection<Room> Rooms { get; set; }
        public ObservableCollection<Testimonial> Testimonials { get; set; }
        public ObservableCollection<string> AdultsOptions { get; set; } = new() { "1", "2", "3", "4+" };
        public ObservableCollection<string> ChildrenOptions { get; set; } = new() { "0", "1", "2", "3", "4+" };

        public MainPage()
        {
            InitializeComponent();

            Rooms = new ObservableCollection<Room>
            {
                new Room { Name = "Single Room", Image = "img_1.jpg", Price = "90$ / per night" },
                new Room { Name = "Family Room", Image = "img_2.jpg", Price = "120$ / per night" },
                new Room { Name = "Presidential Room", Image = "img_3.jpg", Price = "250$ / per night" }
            };

            Testimonials = new ObservableCollection<Testimonial>
            {
                new Testimonial { Author = "Jean Smith", Image = "person_1.jpg", Text = "A small river named Duden flows by their place and supplies it with the necessary regelialia. It is a paradisematic country, in which roasted parts of sentences fly into your mouth." },
                new Testimonial { Author = "John Doe", Image = "person_2.jpg", Text = "Even the all-powerful Pointing has no control about the blind texts it is an almost unorthographic life." }
            };

            BindingContext = this;
        }

        //private async void OnCheckAvailabilityClicked(object sender, EventArgs e)
        //{
            //Tarihleri al
            //DateTime checkIn = CheckInDate.Date;
            //DateTime checkOut = CheckOutDate.Date;

            // Oda ve misafir sayısını kontrol et
            //bool isRoomValid = int.TryParse(RoomCount.Text, out int rooms);
            //bool isGuestValid = int.TryParse(GuestCount.Text, out int guests);

            // Basit doğrulama
            //if (checkOut <= checkIn)
            //{
            //    await DisplayAlert("Hata", "Check-out tarihi, check-in tarihinden sonra olmalıdır.", "Tamam");
            //    return;
            //}

            //if (!isRoomValid || rooms <= 0)
            //{
            //    await DisplayAlert("Hata", "Geçerli bir oda sayısı girin.", "Tamam");
            //    return;
            //}

            //if (!isGuestValid || guests <= 0)
            //{
            //    await DisplayAlert("Hata", "Geçerli bir misafir sayısı girin.", "Tamam");
            //    return;
            //}

            // Başarılıysa (örnek mesaj)
            //await DisplayAlert("Durum", $"Rezervasyon Aranıyor:\nGiriş: {checkIn:dd MMM yyyy}\nÇıkış: {checkOut:dd MMM yyyy}\nOda: {rooms}\nMisafir: {guests}", "Tamam");

            // Burada gerçek rezervasyon API'si çağırılabilir
        //}
        //private async void OnExploreRoomsClicked(object sender, EventArgs e)
        //{
        //    await Navigation.PushAsync(new RoomsPage());
        //}
    }
}
