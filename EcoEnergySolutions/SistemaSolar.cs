using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoEnergySolutions
{
    public class SistemaSolar : SistemaEnergia, ICalculEnergia
    {
        public float HoresDeSol {  get; set; }

        public SistemaSolar(float horesDeSol)
        {
            HoresDeSol = horesDeSol;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="valor"></param>
        public void ConfigurarParametres(float valor) 
        {
            valor = HoresDeSol;
        }
        public double CalcularEnergia()
        {
            double energiaGenerada = HoresDeSol * 1.5;
            return energiaGenerada;

        }
        public void MostrarInforme()
        {

        }
    }
}
