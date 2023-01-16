using Hamburguesa_KevinRosero.Models;
using System.Xml.Linq;

namespace Hamburguesa_KevinRosero.ViewsKR;

public partial class BurgerListPageKR : ContentPage
{
	public BurgerListPageKR()
	{
		InitializeComponent();
        List<BurgerKR> burger = App.BurgerRepoKR.GetAllBurgers();
        burgerList.ItemsSource = burger;
    }

    async void OnItemAdded(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(BurgerItemPageKR));
    }

    private void ActualizarDatos(object sender, EventArgs e)
    {
        List<BurgerKR> burger = App.BurgerRepoKR.GetAllBurgers();
        burgerList.ItemsSource = burger;
    }

    async void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(BurgerItemPageKR));
    }
}