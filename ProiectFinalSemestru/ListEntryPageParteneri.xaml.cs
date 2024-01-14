using ProiectFinalSemestru.Models;

namespace ProiectFinalSemestru;

public partial class ListEntryPageParteneri : ContentPage
{
	public ListEntryPageParteneri()
	{
		InitializeComponent();
	}
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        listView.ItemsSource = await App.Database.GetPartenerAsync();
    }
    async void OnPartenerAddedClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ListPageParteneri
        {
            BindingContext = new Partener()
        });
    }
    async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem != null)
        {
            await Navigation.PushAsync(new ListPageParteneri
            {
                BindingContext = e.SelectedItem as Partener
            });
        }
    }
}