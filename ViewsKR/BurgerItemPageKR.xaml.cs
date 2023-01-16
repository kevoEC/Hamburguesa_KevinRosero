using Hamburguesa_KevinRosero.Models;
namespace Hamburguesa_KevinRosero.ViewsKR;

public partial class BurgerItemPageKR : ContentPage
{
    BurgerKR Item = new BurgerKR();
    bool _flag;
    public BurgerItemPageKR()
	{
		InitializeComponent();
	}
    private void OnSaveClicked(object sender, EventArgs e)
    {
        Item.Name_KevinR = nameB.Text;
        Item.Description_KevinR = descB.Text;
        Item.WithExtraCheese_KevinR = _flag;
        App.BurgerRepoKR.AddNewBurger(Item);
        Shell.Current.GoToAsync("..");
    }

    private void OnCancelClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("..");
    }

    private void OnCheckBoxCheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        _flag = e.Value;
    }

    private void DeletedClicked(object sender, EventArgs e)
    {
        App.BurgerRepoKR.RemoveBurger(Item);
    }
}