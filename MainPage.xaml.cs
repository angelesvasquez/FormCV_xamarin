using Xamarin.Forms;
using System;

namespace FormCV_xam
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnGenerarCvClicked(object sender, EventArgs e)
        {
            // Capturar los datos ingresados
            string nombre = entradaNombre.Text;
            string edad = entradaEdad.Text;
            string ciudad = entradaCiudad.Text;
            string correo = entradaCorreo.Text;
            string telefono = entradaTelefono.Text;

            string puesto = entradaPuesto.Text;
            string empresa = entradaEmpresa.Text;
            string fechaInicio = entradaFechaInicio.Text;
            string fechaFin = entradaFechaFin.Text;
            string responsabilidades = entradaResponsabilidades.Text;

            string titulo = entradaTitulo.Text;
            string universidad = entradaUniversidad.Text;
            string añoGraduacion = entradaAñoGraduacion.Text;

            // Validar si todos los campos están llenos
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(edad) || string.IsNullOrWhiteSpace(ciudad) ||
                string.IsNullOrWhiteSpace(correo) || string.IsNullOrWhiteSpace(telefono))
            {
                await DisplayAlert("Error", "Por favor, rellene todos los campos", "OK");
                return;
            }

            // Navegar a la página de CV con los datos
            await Navigation.PushAsync(new CVPage(nombre, edad, ciudad, correo, telefono, puesto, empresa, fechaInicio, fechaFin, responsabilidades, titulo, universidad, añoGraduacion));
        }
    }
}
