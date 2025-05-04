using HotelProject.Shared.Dtos;
using HotelProject.Shared.Dtos.Dtos;
using HotelProjectMauiApp.Services;

namespace HotelProjectMauiApp.Pages;

public partial class UpdateCategoryPage : ContentPage
{
    private readonly CategoryService _categoryService;
    private readonly ResultCategoryDto _category;

    public UpdateCategoryPage(ResultCategoryDto category)
    {
        InitializeComponent();
        _categoryService = new CategoryService();
        _category = category;
        CategoryNameEntry.Text = _category.CategoryName;
    }

    private async void OnUpdateClicked(object sender, EventArgs e)
    {
        var newName = CategoryNameEntry.Text;

        if (string.IsNullOrWhiteSpace(newName))
        {
            await DisplayAlert("Hata", "Kategori adý boþ olamaz.", "Tamam");
            return;
        }

        var updateDto = new UpdateCategoryDto
        {
            CategoryId = _category.CategoryId,
            CategoryName = newName
        };

        await _categoryService.UpdateCategoryAsync(updateDto);
        await DisplayAlert("Baþarýlý", "Kategori güncellendi.", "Tamam");
        await Navigation.PopAsync(); // Geri dön
    }
}
