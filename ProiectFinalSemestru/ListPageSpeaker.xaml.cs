using ProiectFinalSemestru.Models;
namespace ProiectFinalSemestru;

public partial class ListPageSpeaker : ContentPage
{
	public ListPageSpeaker()
	{
		InitializeComponent();
	}
    async void OnSaveButtonClicked(object sender, EventArgs e)
    {
        var slist = (Speaker)BindingContext;
        await App.Database.SaveSpeakerAsync(slist);
        await Navigation.PopAsync();
    }
    async void OnDeleteButtonClicked(object sender, EventArgs e)
    {
        var slist = (Speaker)BindingContext;
        await App.Database.DeleteSpeakerAsync(slist);
        await Navigation.PopAsync();
    }
}