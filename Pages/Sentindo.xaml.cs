namespace App_Projeto_Integrador.Pages;

public partial class Sentindo : ContentPage
{
	public Sentindo()
	{
		InitializeComponent();
	}

    private async void ImgButtonMedio_Clicked(object sender, EventArgs e) {
		Application.Current.MainPage = new NavigationPage(new Pages.TelaInicial());
    }

	private async void ImgBtnFeliz(object sender, EventArgs e) {
        Application.Current.MainPage = new NavigationPage(new Pages.TelaInicial());
    }

    private async void ImgBtnTriste(object sender, EventArgs e) {
        Application.Current.MainPage = new NavigationPage(new Pages.TelaInicial());
    }

    
}