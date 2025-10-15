using Imc.Model;

namespace IndiceDeMasaCorporal.Gui
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
            LimpiarInformacion();
        }

        private void OnCalcularButton_Clicked(object sender, EventArgs e)
        {
            decimal peso = Convert.ToDecimal(PesoEntry.Text);
            decimal estatura = Convert.ToDecimal(EstaturaEntry.Text);
            decimal imc = IndiceDeMasaCorporalLib.IndiceDeMasaCorporal(peso, estatura);
            ImcLabel.Text = imc.ToString("G6");
            SituacionNutricionalLabel.Text = IndiceDeMasaCorporalLib.DeterminaEstadoNutricional(imc);
        }

        private void OnLimpiarButton_Clicked(object sender, EventArgs e)
        {
            LimpiarInformacion();
        }

        private void LimpiarInformacion()
        {
            PesoEntry.Text = string.Empty;
            EstaturaEntry.Text = string.Empty;
            ImcLabel.Text = string.Empty;
            SituacionNutricionalLabel.Text = string.Empty;
        }



    }
}

