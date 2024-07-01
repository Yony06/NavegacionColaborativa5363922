namespace NavegacionColaborativa5363922;

/// <summary>
/// Colocamos el codigo que hara funcionar la aplicacion
/// </summary>

public partial class Gasolinera : ContentPage
{
    /// <summary>
    /// Declaramos el evento del botón 
    /// </summary>
    public Gasolinera()
	{
		InitializeComponent();
	}
    /// <summary>
    /// En el evento del boton creamos un if donde vamos a convertir los galones a litros y luego calcular el cobro
    /// </summary>
    /// <return> Retorna el cobro al cliente  </return>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void OnCounterClicked(object sender, EventArgs e)
    {
        if (double.TryParse(GalonesEntry.Text, out double galones))
        {
             double GalonesToLitros = 3.78541;

             double PrecioPorLitro = 4.13;
            double litros = galones * GalonesToLitros;
            double montoTotal = litros * PrecioPorLitro;

            ResultadoLabel.Text = $"Monto a cobrar: ${montoTotal}";
        }
        else
        {
            ResultadoLabel.Text = "Ingresa una cantidad válida de galones.";
        }
    }
}