

namespace App_Projeto_Integrador.Pages;

public partial class TelaInicial : ContentPage {
    public TelaInicial() {
        InitializeComponent();
    }

    private async void BtnSentindo(object sender, EventArgs e) {
        Application.Current.MainPage = new NavigationPage(new Sentindo());
    }

    private async void BtnSair_Clicked(object sender, EventArgs e) {
        Application.Current.MainPage = new NavigationPage(new EditaUsuario());
    }

    private async void BtnEscrever(object sender, EventArgs e) {
        Application.Current.MainPage = new NavigationPage(new Escrever());
    }

    private async void BtnRegistros(object sender, EventArgs e) {
        await Navigation.PushAsync(new Registros());
    }
}