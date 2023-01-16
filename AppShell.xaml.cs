namespace Hamburguesa_KevinRosero;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute(nameof(ViewsKR.BurgerItemPageKR), typeof(ViewsKR.BurgerItemPageKR));
        Routing.RegisterRoute(nameof(ViewsKR.BurgerListPageKR), typeof(ViewsKR.BurgerListPageKR));
    }
}
