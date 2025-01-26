using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoEnergySolutions
{
    public class SistemaEolic : SistemaEnergia
    {
        public float VelocitatVent {  get; set; }

        public override void ConfigurarParametres(float valor)
        {
            while (valor <= 5)
            {

            }
            valor = VelocitatVent;
        }

        public override double CalcularEnergia()
        {
            EnergiaGenerada = Math.Pow(VelocitatVent, 3) * 0.2;
            return EnergiaGenerada;
        }

    }
}
