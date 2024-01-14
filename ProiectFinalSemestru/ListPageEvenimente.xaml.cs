using ProiectFinalSemestru.Models;

namespace ProiectFinalSemestru;

public partial class ListPageEvenimente : ContentPage
{
	public ListPageEvenimente()
	{
		InitializeComponent();
	}
    async void OnSaveButtonClicked(object sender, EventArgs e)
    {
        var slist = (Evenimente)BindingContext;
        await App.Database.SaveEvenimenteAsync(slist);
        await Navigation.PopAsync();
    }
    async void OnDeleteButtonClicked(object sender, EventArgs e)
    {
        var slist = (Evenimente)BindingContext;
        await App.Database.DeleteEvenimenteAsync(slist);
        await Navigation.PopAsync();
    }
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        var speaker = await App.Database.GetSpeakerAsync();
        SpeakerPicker.ItemsSource = (System.Collections.IList)speaker;
        SpeakerPicker.ItemDisplayBinding = new Binding("Nume");
        var partener = await App.Database.GetPartenerAsync();
        PartenerPicker.ItemsSource = (System.Collections.IList)partener;
        PartenerPicker.ItemDisplayBinding = new Binding("Nume");
        var sponsor = await App.Database.GetSponsorAsync();
        SponsorPicker.ItemsSource = (System.Collections.IList)sponsor;
        SponsorPicker.ItemDisplayBinding = new Binding("Name");
        var categorie = await App.Database.GetCategorieAsync();
        CategoriePicker.ItemsSource = (System.Collections.IList)categorie;
        CategoriePicker.ItemDisplayBinding = new Binding("Denumire");
    }
} 