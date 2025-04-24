namespace Clase04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ImprimirCadena();
        }

        public void ImprimirCadena()
        {
            string mensajeSalida = "Generando facturas para el cliente \"ABC Group\"...\r\n\r\nFactura: 1021\tCompletado!\r\nFactura: 1022\tCompletado!\r\n\r\nDirectorio de Salida\r\nC:\\Facturas";

            string mensajeSalidaDos = @"Generando facturas para el cliente ""ABC Group""...

Factura: 1021   Completado!
Factura: 1022   Completado!

Directorio de Salida
C:\Facturas";

            string primerNombre = "Brandon";
            string segundoNombre = "Alexander";
            string primerApellido = "Cahuec";
            string segundoApellido = "Corazón";

            string nombreCompleto = primerNombre + " " + segundoNombre + " " + primerApellido + " " + segundoApellido;

            string nombreCompletoDos = string.Concat(primerNombre, " ", segundoNombre, " ", primerApellido, " ", segundoApellido);

            string nombreCompletoTres = $"Mis nombre son: {primerNombre} {segundoNombre} y mis apellidos son: {primerApellido} {segundoApellido}";

            txtSalidaTexto.Text = nombreCompletoTres;
        }

        public void EjercicioTres()
        {
            string texto = "Hola, Bienvenidos al curso de Intro a Progra C#";
            txtSalidaTexto.Text = texto;

            int posicionInicial = texto.IndexOf("enidos");

            int posicionFinal = texto.IndexOf("s");

            string resultado = texto.Substring(posicionInicial, posicionFinal - posicionInicial);

            int primeraPosicionE = texto.IndexOf("e");

            int ultimaPosicionO = texto.LastIndexOf("o");

            posicionInicial = texto.IndexOf("Progra");

            string textoSinProgra = texto.Remove(posicionInicial, 6);

            string textoSinEspacios = texto.Replace(" ", "_");

            txtResultado.Text = textoSinEspacios.ToString() ;
        }
    }
}
