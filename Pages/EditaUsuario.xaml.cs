using System.Threading.Tasks;

namespace App_Projeto_Integrador.Pages;

public partial class EditaUsuario : ContentPage
{
	public EditaUsuario()
	{
		InitializeComponent();
	}

		private void entrar_Clicked(object sender, EventArgs e) {
			if (!string.IsNullOrWhiteSpace(txtEmail.Text) && !string.IsNullOrWhiteSpace(txtSenha.Text)) {
				Application.Current.MainPage = new NavigationPage(new TelaInicial());
			}
			else {
				Application.Current.MainPage = new NavigationPage(new EditaUsuario());
			}
		}
}