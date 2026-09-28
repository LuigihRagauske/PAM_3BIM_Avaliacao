using AppLibertadoresHAS.ViewModels;

namespace AppLibertadoresHAS.Views.JogadoresV;

public partial class ListagemJogadorView : ContentPage
{
	public ListagemJogadorView()
	{
		InitializeComponent();
		BindingContext = new ListagemJogadorViewModel();
	}
}