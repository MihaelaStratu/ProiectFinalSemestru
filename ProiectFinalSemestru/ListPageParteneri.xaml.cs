using ProiectFinalSemestru.Models;
namespace ProiectFinalSemestru;

public partial class ListPageParteneri : ContentPage
{
	public ListPageParteneri()
	{
		InitializeComponent();
	}
    async void OnSaveButtonClicked(object sender, EventArgs e)
    {
        var slist = (Partener)BindingContext;
        await App.Database.SavePartenerAsync(slist);
        await Navigation.PopAsync();
    }
    async void OnDeleteButtonClicked(object sender, EventArgs e)
    {
        var slist = (Partener)BindingContext;
        await App.Database.DeletePartenerAsync(slist);
        await Navigation.PopAsync();
    }


}