using CadastroEventos.Models;
using CadastroEventos.Views;

namespace CadastroEventos;

public partial class MainPage : ContentPage
{
    public Evento Evento { get; set; }

    public MainPage()
    {
        InitializeComponent();
        Evento = new Evento();
        BindingContext = Evento;
    }

    private async void OnSalvarClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ResumoPage(Evento));
    }
}
