namespace dcabreraExamen;

public partial class Registro : ContentPage
{
    string usuarioConectado;
    double pagoMensual = 0;

    public Registro(string usuario)
    {
        InitializeComponent();
        usuarioConectado = usuario;

      
        lblUsuario.Text = $"Usuario conectado: {usuario}";
    }

    private void OnCalcularClicked(object sender, EventArgs e)
    {
        
        if (double.TryParse(txtMonto.Text, out double montoInicial))
        {
            double costoCurso = 1500;

            
            double saldoRestante = costoCurso - montoInicial;
            double cuotaBase = saldoRestante / 4;

            
            double recargoPorCuota = costoCurso * 0.04;

            pagoMensual = cuotaBase + recargoPorCuota;

           
            txtPagoMensual.Text = pagoMensual.ToString("0.00");
        }
        else
        {
            DisplayAlert("Error", "Por favor ingrese un monto inicial válido.", "OK");
        }
    }

    private async void OnResumenClicked(object sender, EventArgs e)
    {
        
        await Navigation.PushAsync(new Resumen(
            usuarioConectado,
            txtNombre.Text,
            txtApellido.Text,
            txtEdad.Text,
            dpFecha.Date is DateTime fecha ? fecha.ToString("dd/MM/yyyy") : DateTime.Today.ToString("dd/MM/yyyy"),
            pkCiudad.SelectedItem?.ToString() ?? "N/A",
            pkPais.SelectedItem?.ToString() ?? "N/A",
            txtMonto.Text,
            pagoMensual
        ));
    }
}