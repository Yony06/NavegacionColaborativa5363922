namespace NavegacionColaborativa5363922
{
    /// <summary>
    /// En la pagina MainPage configuramos cada uno de los eventos de los botones
    /// </summary>
    public partial class MainPage : ContentPage
    {
        int count = 0;
        /// <summary>
        /// En cada evento colocamos la navegacion y al dar click en el botón
        /// </summary>
        /// <return> Nos retorna la content page a la cual se va a dirigir</return>
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        { 
        }

        private void Cambio_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CambioCliente());
        }

        private void Triangulo_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Triangulo());
        }

        private void Dinosaurio_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Dinosaurio());
        }

        private void Gas_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Gasolinera());
        }

        private void Survey_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AppSurvey());
        }

        private void Sobre_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new About());
        }
    }

}
