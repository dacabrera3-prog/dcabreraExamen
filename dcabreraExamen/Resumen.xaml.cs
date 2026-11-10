namespace dcabreraExamen;

public partial class Resumen : ContentPage
{
    public Resumen(string usuario, string nombre, string apellido, string edad, string fecha, string ciudad, string pais, string montoInicial, double pagoMensual)
    {
        InitializeComponent();

        lblUsuario.Text = $"Usuario conectado: {usuario}";
        lblNombre.Text = nombre;
        lblApellido.Text = apellido;
        lblEdad.Text = edad;
        lblFecha.Text = fecha;
        lblCiudad.Text = ciudad;
        lblPais.Text = pais;

        lblMontoInicial.Text = $"${montoInicial}";
        lblPagoMensual.Text = $"${pagoMensual:0.00}";

        if (double.TryParse(montoInicial, out double monto))
        {
            double pagoTotal = monto + (pagoMensual * 4);
            lblPagoTotal.Text = $"${pagoTotal:0.00}";
        }
    }
}