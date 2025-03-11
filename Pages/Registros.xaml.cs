namespace App_Projeto_Integrador.Pages;

public partial class Registros : ContentPage
{
    private const string CHAVE_REGISTROS = "diario_registros";
    public Registros()
	{
		InitializeComponent();
		CarregarRegistros();
	}

	private void CarregarRegistros() {
        string registros = Preferences.Get(CHAVE_REGISTROS, "Nenhum registro encontrado.");
        lblRegistros.Text = registros;
    }

    private async void BtnVoltar(object sender, EventArgs e) {
        Application.Current.MainPage = new NavigationPage(new TelaInicial());
    }
}