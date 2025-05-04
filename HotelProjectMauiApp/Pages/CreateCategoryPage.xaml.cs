using HotelProject.Shared.Dtos;
using HotelProject.Shared.Dtos.Dtos;
using HotelProjectMauiApp.Services;

namespace HotelProjectMauiApp.Pages;

public partial class CreateCategoryPage : ContentPage
{
    private readonly CategoryService _categoryService;

    public CreateCategoryPage()
    {
        InitializeComponent();
        _categoryService = new CategoryService();
    }

    private async void OnSaveClicked(object sender, EventArgs e)
    {
        var categoryName = CategoryNameEntry.Text;

        if (string.IsNullOrWhiteSpace(categoryName))
        {
            await DisplayAlert("Hata", "Kategori adý boþ olamaz.", "Tamam");
            return;
        }

        var newCategory = new CreateCategoryDto { CategoryName = categoryName };
        await _categoryService.CreateCategoryAsync(newCategory);

        await DisplayAlert("Baþarýlý", "Kategori eklendi.", "Tamam");
        await Navigation.PopAsync(); // Önceki sayfaya dön
    }
}
