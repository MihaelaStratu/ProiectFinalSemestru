using ProiectFinalSemestru.Models;
namespace ProiectFinalSemestru;

public partial class ListPage : ContentPage
{
	public ListPage()
	{
		InitializeComponent();
	}
    async void OnSaveButtonClicked(object sender, EventArgs e)
    {
        var slist = (Sponsor)BindingContext;
        await App.Database.SaveSponsorAsync(slist);
        await Navigation.PopAsync();
    }
    async void OnDeleteButtonClicked(object sender, EventArgs e)
    {
        var slist = (Sponsor)BindingContext;
        await App.Database.DeleteSponsorAsync(slist) ;
        await Navigation.PopAsync();
    }

}