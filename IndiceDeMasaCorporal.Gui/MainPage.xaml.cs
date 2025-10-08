namespace IndiceDeMasaCorporal.Gui
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
            PesoEntry.Text = string.Empty;
            EstaturaEntry.Text = string.Empty;
            ImcLabel.Text = string.Empty;
            SituacionNutricionalLabel.Text = string.Empty;
        }

        private void OnCalcularButton_Clicked(object sender, EventArgs e)
        {
            decimal peso = Convert.ToDecimal(PesoEntry.Text);
            decimal estatura=Convert.ToDecimal(EstaturaEntry.Text);
            decimal imc=IndiceDeMasaCorporal(peso, estatura);
            ImcLabel.Text = imc.ToString("G6");
            SituacionNutricionalLabel.Text = DeterminaEstadoNutricional(imc);
        }

        private void OnLimpiarButton_Clicked(object sender, EventArgs e)
        {
            PesoEntry.Text = string.Empty;
            EstaturaEntry.Text = string.Empty;
            ImcLabel.Text = string.Empty;
            SituacionNutricionalLabel.Text = string.Empty;
        }
        private decimal IndiceDeMasaCorporal(decimal peso,decimal estatura)
        {
            return peso / (estatura * estatura);
        }
        private string DeterminaEstadoNutricional(decimal imc)
        {
            if (imc < 18.5m)
            {
                return "Peso Bajo";
            }
            if (imc < 25m)
            {
                return "Peso Normal";
            }
            if (imc < 30m)
            {
                return "Sobrepeso";
            }
            if (imc < 40m)
            {
                return "Obesidad";
            }
           
                return "Obesidad Extrema";
            
        }
    }
}
