using Microsoft.Win32;

namespace dcabreraExamen;

public partial class Login : ContentPage
{
    
    string[,] credenciales = new string[2, 2] {
        { "estudiante", "moviles" },
        { "suda", "2025" }
    };

    public Login()
    {
        InitializeComponent();
    }

    private async void OnLoginClicked(object sender, EventArgs e)
    {
        string user = txtUsuario.Text;
        string pass = txtPassword.Text;
        bool valid = false;

        
        for (int i = 0; i < 2; i++)
        {
            if (credenciales[i, 0] == user && credenciales[i, 1] == pass)
            {
                valid = true;
                break;
            }
        }

        if (valid)
        {
            
            await Navigation.PushAsync(new Registro(user));
        }
        else
        {
           
            await DisplayAlert("Error", "Dato incorrecto", "OK");
        }
    }
}