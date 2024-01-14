using ProiectFinalSemestru.Models;

namespace ProiectFinalSemestru;

public partial class ListEntryPageCategorii : ContentPage
{
	public ListEntryPageCategorii()
	{
		InitializeComponent();
	}
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        listView.ItemsSource = await App.Database.GetCategorieAsync();
    }
    async void OnCategorieAddedClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ListPageCategorii
        {
            BindingContext = new Categorie()
        });
    }
    async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem != null)
        {
            await Navigation.PushAsync(new ListPageCategorii
            {
                BindingContext = e.SelectedItem as Categorie
            });
        }
    }
}