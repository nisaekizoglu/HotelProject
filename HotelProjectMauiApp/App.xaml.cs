using HotelProjectMauiApp.Pages;
using Microsoft.IdentityModel.Tokens;

namespace HotelProjectMauiApp
{
    public partial class App : Application
    {
        //public static string BaseUrl {  get; private set; }
        public App()
        {
            //BaseUrl = DeviceInfo.Platform == DevicePlatform.Android ? "http://10.0.2.2/api" : "http://localhost:7237/api";
            InitializeComponent();

            MainPage = new NavigationPage(new CategoriesPage());
        }
    }
}