using ADOPMAUI_Exercise.Globals;
using ADOPMAUI_Exercise.Models;

namespace ADOPMAUI_Exercise;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
    protected override void OnStart()
    {
        //Demonstrate State management
        //using Global variables

        //Some Friends with Favorite color Blue
        Global.Data.Friends = Friend.Factory.CreateRandom(100)
            .Where(f => (f.FavoriteColor.FriendlyName.Contains("Blue"))).ToList();
        
        //Some Cities in Africa
        Global.Data.Cities = City.List.Where(c => c.Continent == "Africa").ToList();

        //All Named Colors with a strong Red component
        Global.Data.NamedColors = NamedColor.All.Where(nc => (nc.FriendlyName.Contains("Red"))).ToList();
    }
}
