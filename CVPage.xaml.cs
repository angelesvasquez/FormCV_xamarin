using Xamarin.Forms;

namespace FormCV_xam
{
    public partial class CVPage : ContentPage
    {
        public string Nombre { get; set; }
        public string Edad { get; set; }
        public string Ciudad { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }

        public string Puesto { get; set; }
        public string Empresa { get; set; }
        public string FechaInicio { get; set; }
        public string FechaFin { get; set; }
        public string Responsabilidades { get; set; }

        public string Titulo { get; set; }
        public string Universidad { get; set; }
        public string AñoGraduacion { get; set; }

        public CVPage(string nombre, string edad, string ciudad, string correo, string telefono,
                      string puesto, string empresa, string fechaInicio, string fechaFin, string responsabilidades,
                      string titulo, string universidad, string añoGraduacion)
        {
            InitializeComponent();

            // Asignar valores a las propiedades
            Nombre = nombre;
            Edad = edad;
            Ciudad = ciudad;
            Correo = correo;
            Telefono = telefono;

            Puesto = puesto;
            Empresa = empresa;
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;
            Responsabilidades = responsabilidades;

            Titulo = titulo;
            Universidad = universidad;
            AñoGraduacion = añoGraduacion;

            // Establecer el BindingContext para que los datos se muestren en la interfaz
            BindingContext = this;
        }
    }
}
