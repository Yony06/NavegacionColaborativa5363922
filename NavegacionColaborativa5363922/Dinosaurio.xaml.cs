namespace NavegacionColaborativa5363922;

/// <summary>
/// La clase MainPage representa la p�gina principal de la aplicaci�n.
/// </summary>
public partial class Dinosaurio : ContentPage
{
    /// <summary>
    /// Constructor de la clase MainPage.
    /// Inicializa los componentes de la p�gina.
    /// </summary>
    public Dinosaurio()
	{

		InitializeComponent();
	}

    /// <summary>
    /// Maneja el evento Clicked del bot�n.
    /// Realiza la conversi�n del peso y la altura del dinosaurio y muestra los resultados.
    /// </summary>
    /// <param name="sender">El objeto que desencadena el evento.</param>
    /// <param name="e">Los datos que contiene el evento.</param>
    private void Button_Clicked(object sender, EventArgs e)
    {
        string name = DinosaurioNombre.Text;
        if (double.TryParse(Peso.Text, out double weightKg) && double.TryParse(Altura.Text, out double heightM))
        {
            double weightLbs = weightKg * 2.20462;
            double heightCm = heightM * 100;

            ResultLabel.Text = $"{name}: pesa {weightLbs:F2} libras y mide {heightCm:F2} cent�metros.";
        }

    }
}