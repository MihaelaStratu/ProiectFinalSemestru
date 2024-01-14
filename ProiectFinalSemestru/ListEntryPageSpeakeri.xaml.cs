using ProiectFinalSemestru.Models;
namespace ProiectFinalSemestru;

public partial class ListEntryPageSpeakeri : ContentPage
{
	public ListEntryPageSpeakeri()
	{
		InitializeComponent();
	}
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        listView.ItemsSource = await App.Database.GetSpeakerAsync();
    }
    async void OnSpeakerAddedClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ListPageSpeaker
        {
            BindingContext = new Speaker()
        });
    }
    async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem != null)
        {
            await Navigation.PushAsync(new ListPageSpeaker
            {
                BindingContext = e.SelectedItem as Speaker
            });
        }
    }

}