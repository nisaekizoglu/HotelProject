using HotelProject.Shared.Dtos;
using HotelProject.Shared.Dtos.Dtos;
using HotelProjectMauiApp.Services;

namespace HotelProjectMauiApp.Pages;

public partial class CategoriesPage : ContentPage
{
    private readonly CategoryService _categoryService;

    public CategoriesPage()
    {
        InitializeComponent();
        _categoryService = new CategoryService();
        LoadCategories();
    }

    private async void LoadCategories()
    {
        var categories = await _categoryService.GetAllCategoriesAsync();
        CategoryListView.ItemsSource = categories;
    }

    private async void OnDeleteClicked(object sender, EventArgs e)
    {
        var button = (Button)sender;
        var category = (ResultCategoryDto)button.CommandParameter;

        bool confirm = await DisplayAlert("Sil", $"Kategori '{category.CategoryName}' silinsin mi?", "Evet", "Hayýr");
        if (confirm)
        {
            await _categoryService.DeleteCategoryAsync(category.CategoryId);
            LoadCategories();
        }
    }

    private async void OnUpdateClicked(object sender, EventArgs e)
    {
        var button = (Button)sender;
        var category = (ResultCategoryDto)button.CommandParameter;

        await Navigation.PushAsync(new UpdateCategoryPage(category)); // Update sayfan olmalý
    }

    private async void OnAddNewCategoryClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CreateCategoryPage()); // Yeni kategori sayfan olmalý
    }
}
