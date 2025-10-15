using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imc.Model
{
    public static class IndiceDeMasaCorporalLib
    {
        public static decimal IndiceDeMasaCorporal(decimal peso, decimal estatura)
        {
            return peso / (estatura * estatura);
        }
        public static string DeterminaEstadoNutricional(decimal imc)
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
