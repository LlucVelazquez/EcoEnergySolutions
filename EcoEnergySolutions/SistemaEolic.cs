using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoEnergySolutions
{
    public class SistemaEolic : SistemaEnergia
    {
        public float VelocitatVent {  get; set; }

        public override float ConfigurarParametres()
        {
            const string MsgConfPara = "Introdueix el valor de velocitat del vent (minim 5): ";
            bool flag = true;
            while (flag)
            {
                Console.WriteLine(MsgConfPara);
                VelocitatVent = HelperClass.ValidarNumFloat(Console.ReadLine());
                if (VelocitatVent != 0 && VelocitatVent >= 5)
                {
                    flag = false;
                }
            }
            return VelocitatVent;
        }

        public override double CalcularEnergia()
        {
            EnergiaGenerada = Math.Pow(VelocitatVent, 3) * 0.2;
            return EnergiaGenerada;
        }

    }
}
