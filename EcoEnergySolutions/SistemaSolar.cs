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
        public override float ConfigurarParametres() 
        {
            const string MsgConfPara = "Introdueix el valor de les hores de sol disponibles (valor superior a 1): ";
            bool flag = true;
            while (flag)
            {
                Console.WriteLine(MsgConfPara);
                HoresDeSol = HelperClass.ValidarNumFloat(Console.ReadLine());
                if (HoresDeSol != 0 && HoresDeSol > 1)
                {
                    flag = false;
                }
            }
            return HoresDeSol;
        }
        public override double CalcularEnergia()
        {
            EnergiaGenerada = HoresDeSol * 1.5;
            return EnergiaGenerada;

        }
    }
}
