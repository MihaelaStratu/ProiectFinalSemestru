using ProiectFinalSemestru.Models;

namespace ProiectFinalSemestru;

public partial class ListEntryPageEvenimente : ContentPage
{
	public ListEntryPageEvenimente()
	{
		InitializeComponent();
	}
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        listView.ItemsSource = await App.Database.GetEvenimenteAsync();
    }
    async void OnEvenimenteAddedClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ListPageEvenimente
        {
            BindingContext = new Evenimente()
        });
    }
    async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem != null)
        {
            await Navigation.PushAsync(new  ListPageEvenimente
            {
                BindingContext = e.SelectedItem as Evenimente
            });
        }
    }

}