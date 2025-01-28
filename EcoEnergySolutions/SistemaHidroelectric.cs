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

        public override float ConfigurarParametres()
        {
            const string MsgConfPara = "Introdueix el valor del cabal d'aigua (minim 20): ";
            bool flag = true;
            bool validNum = true;
            while (flag)
            {
                while (validNum)
                {
                    Console.WriteLine(MsgConfPara);
                    CabalAigua = HelperClass.ValidarNumFloat(Console.ReadLine());
                    if (CabalAigua != 0)
                    {
                        validNum = false;
                    }
                }
                if (CabalAigua >= 20)
                {
                    flag = false;
                }
            }
            return CabalAigua;
        }

        public override double CalcularEnergia()
        {
            EnergiaGenerada = CabalAigua * 9.8 * 0.8;
            return EnergiaGenerada;
        }
    }
}
