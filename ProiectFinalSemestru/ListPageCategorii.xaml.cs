using ProiectFinalSemestru.Models;

namespace ProiectFinalSemestru;

public partial class ListPageCategorii : ContentPage
{
	public ListPageCategorii()
	{
		InitializeComponent();
	}
    async void OnSaveButtonClicked(object sender, EventArgs e)
    {
        var slist = (Categorie)BindingContext;
        await App.Database.SaveCategorieAsync(slist);
        await Navigation.PopAsync();
    }
    async void OnDeleteButtonClicked(object sender, EventArgs e)
    {
        var slist = (Categorie)BindingContext;
        await App.Database.DeleteCategorieAsync(slist);
        await Navigation.PopAsync();
    }
}