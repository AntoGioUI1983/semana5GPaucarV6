namespace semana5GPaucar.Views;
using semana5GPaucar.Models;


    public partial class vEditar : ContentPage
{
    public vEditar(string nombre, int id)
    {
        InitializeComponent();

        txtNombre.Text = nombre;
        lblId.Text = id.ToString();
    }

    private void btnGuardar_Clicked(object sender, EventArgs e)
    {
        string nuevoNombre = txtNombre.Text;
        int id = int.Parse(lblId.Text);

      
        Persona persona = new Persona { Id = id, Name = nuevoNombre };
        App.PersonRepo.UpdatePerson(persona);

        MostrarAlerta("Éxito", "Información actualizada");
    }


    private async void MostrarAlerta(string titulo, string mensaje)
        {
            await DisplayAlert(titulo, mensaje, "Aceptar");
        }

    private void btnInicio_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Views.vPersona());
    }
}