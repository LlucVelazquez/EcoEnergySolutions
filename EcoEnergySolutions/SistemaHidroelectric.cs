using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoEnergySolutions
{
    public class SistemaHidroelectric : SistemaEnergia, ICalculEnergia
    {
        public float CabalAigua {  get; set; }

        public SistemaHidroelectric(float cabalAigua)
        {
            CabalAigua = cabalAigua;
        }

        public void ConfigurarParametres(float valor)
        {
            throw new NotImplementedException();
        }

        public double CalcularEnergia()
        {
            double energiaGenerada = CabalAigua * 9.8 * 0.8;
            return energiaGenerada;
        }

        public void MostrarInforme()
        {
            throw new NotImplementedException();
        }
    }
}
