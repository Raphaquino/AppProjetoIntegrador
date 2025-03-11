using App_Projeto_Integrador;
using System.Threading.Tasks;

namespace App_Projeto_Integrador;

public partial class MainPage : ContentPage
{
    

    public MainPage()
    {
        Background = Colors.White;
        InitializeComponent();

        StartSplash();
    }

    private async void StartSplash() {
        await Task.Delay(4897);
        Application.Current.MainPage = new NavigationPage(new Pages.EditaUsuario());
    }
}
