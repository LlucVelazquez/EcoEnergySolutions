using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoEnergySolutions
{
    public class SistemaSolar : SistemaEnergia
    {
        public float HoresDeSol {  get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="valor"></param>
        public override void ConfigurarParametres(float valor) 
        {
            while (valor < 1)
            {

            }
            valor = HoresDeSol;
        }
        public override double CalcularEnergia()
        {
            EnergiaGenerada = HoresDeSol * 1.5;
            return EnergiaGenerada;

        }
    }
}
