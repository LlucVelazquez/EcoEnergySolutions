using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoEnergySolutions
{
    public class SistemaHidroelectric : SistemaEnergia
    {
        public float CabalAigua {  get; set; }

        public override void ConfigurarParametres(float valor)
        {
            while (valor >= 20)
            {

            }
            valor = CabalAigua;
        }

        public override double CalcularEnergia()
        {
            EnergiaGenerada = CabalAigua * 9.8 * 0.8;
            return EnergiaGenerada;
        }
    }
}
