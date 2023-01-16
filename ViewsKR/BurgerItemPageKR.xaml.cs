using Hamburguesa_KevinRosero.Models;
using Microsoft.Maui.ApplicationModel.Communication;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;

namespace Hamburguesa_KevinRosero.ViewsKR;
[QueryProperty(nameof(auxKR), "Aux")]
public partial class BurgerItemPageKR : ContentPage
{
    BurgerKR Item = new BurgerKR();
    BurgerKR Aux = new BurgerKR();
    bool _flag;
    public BurgerItemPageKR()
	{
		InitializeComponent();
	}
    public BurgerKR auxKR
    {
        get => Aux;
        set
        {
            Aux = value;
        }
    }
    private async void OnSaveClicked(object sender, EventArgs e)
    {
        Item = Aux;
        Item.Name_KevinR = nameB.Text;
        Item.Description_KevinR = descB.Text;
        Item.WithExtraCheese_KevinR = _flag;

        if (string.IsNullOrEmpty(Item.Name_KevinR) || string.IsNullOrEmpty(Item.Description_KevinR))
        {
            return;
        }
        App.BurgerRepoKR.AddNewBurger(Item);
        await Shell.Current.GoToAsync("..");
    }

    private void OnCancelClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("..");
    }

    private void OnCheckBoxCheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        _flag = e.Value;
    }

    async void DeletedClicked(object sender, EventArgs e)
    {
        Item = Aux;
        App.BurgerRepoKR.RemoveBurger(Item);
        await Shell.Current.GoToAsync("..");
    }
}