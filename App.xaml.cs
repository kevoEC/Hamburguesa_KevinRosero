using Hamburguesa_KevinRosero.Data;
namespace Hamburguesa_KevinRosero;

public partial class App : Application
{
    public static BurgerDatabaseKR BurgerRepoKR { get; private set; }
    public App(BurgerDatabaseKR repo)
	{
		InitializeComponent();

		MainPage = new AppShell();
        BurgerRepoKR = repo;
    }
}
