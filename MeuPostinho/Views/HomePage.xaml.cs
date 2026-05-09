namespace MeuPostinho.Views
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void Agendar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Agendamento());
        }

        private void Medicamentos_Clicked(object sender, EventArgs e)
        {

        }

        private void Consultas_Clicked(object sender, EventArgs e)
        {

        }
    }
}