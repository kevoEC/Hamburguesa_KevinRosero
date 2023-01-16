using Hamburguesa_KevinRosero.Models;
using System.Xml.Linq;

namespace Hamburguesa_KevinRosero.ViewsKR;

public partial class BurgerListPageKR : ContentPage
{
    BurgerKR selected;
    public BurgerListPageKR()
	{
		InitializeComponent();
        //List<BurgerKR> burger = App.BurgerRepoKR.GetAllBurgers();
        //burgerList.ItemsSource = burger;
        burgerListKR.ItemsSource = UpdateList();
    }

    async void OnItemAdded(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(BurgerItemPageKR));
    }

    private void ActualizarDatos(object sender, EventArgs e)
    {
        //List<BurgerKR> burger = App.BurgerRepoKR.GetAllBurgers();
        burgerListKR.ItemsSource = App.BurgerRepoKR.GetAllBurgers();
        //burgerListEM.ItemTapped += OnBurgerSelected;
    }

    private async void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        selected = e.CurrentSelection[0] as BurgerKR;
        await Navigation.PushAsync(new BurgerItemPageKR
        {
            auxKR = selected,
            BindingContext = selected,
        });
    }

    private static List<BurgerKR> UpdateList()
    {
        List<BurgerKR> burger = App.BurgerRepoKR.GetAllBurgers();
        return burger;
    }
}