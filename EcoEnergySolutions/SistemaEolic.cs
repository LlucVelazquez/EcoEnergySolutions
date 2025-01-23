using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoEnergySolutions
{
    public class SistemaEolic : SistemaEnergia, ICalculEnergia
    {
        public float VelocitatVent {  get; set; }

        public SistemaEolic(float velocitatVent)
        {
            VelocitatVent = velocitatVent;
        }
        public void ConfigurarParametres(float valor)
        {
            throw new NotImplementedException();
        }

        public double CalcularEnergia()
        {
            double EnergiaGenerada = Math.Pow(VelocitatVent, 3) * 0.2;
            return EnergiaGenerada;
        }


        public void MostrarInforme()
        {
            throw new NotImplementedException();
        }
    }
}
