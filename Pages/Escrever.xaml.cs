namespace App_Projeto_Integrador.Pages;

public partial class Escrever : ContentPage
{
    private const string CHAVE_REGISTROS = "diario_registros";
    public Escrever()
	{
		InitializeComponent();
	}

    private async void BtnEnvio_Clicked(object sender, EventArgs e) {
        if (!string.IsNullOrWhiteSpace(txtEntrada.Text)) {
            // Obtém os registros antigos
            string registrosAntigos = Preferences.Get(CHAVE_REGISTROS, "");

            string novoRegistro = $"{DateTime.Now:dd/MM/yyyy HH:mm} - {txtEntrada.Text}\n";
            string registrosAtualizados = novoRegistro + registrosAntigos;

            Preferences.Set(CHAVE_REGISTROS, registrosAtualizados);

            // Limpa o campo
            txtEntrada.Text = "";

            Application.Current.MainPage = new NavigationPage(new TelaInicial());
        }
        else {
            await DisplayAlert("Error","Digite algo antes de salvar", "OK");
        }
    }
}