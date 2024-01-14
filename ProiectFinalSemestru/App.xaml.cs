using System;
using ProiectFinalSemestru.Data;
using System.IO;

namespace ProiectFinalSemestru;

public partial class App : Application
{

    static SponsorDatabase database;
    public static SponsorDatabase Database
    {
        get
        {
            if (database == null)
            {
                database = new
               SponsorDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.
               LocalApplicationData), "Sponsor.db3"));
            }
            return database;
        }
    }
    

    public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
}
