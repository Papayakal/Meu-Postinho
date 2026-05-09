namespace MeuPostinho.Views
{
    public partial class CadastroPage : ContentPage
    {
        public CadastroPage()
        {
            InitializeComponent();
        }

        private bool senhaVisivel = false;

        private void Button_Clicked(object sender, EventArgs e)
        {
            senhaVisivel = !senhaVisivel;

            senhaEntry.IsPassword = !senhaVisivel;

            // opcional: mudar o ícone/texto
            ((Button)sender).Text = senhaVisivel ? "🙈" : "👁";
        }
    }
}