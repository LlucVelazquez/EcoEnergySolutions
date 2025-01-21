using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoEnergySolutions
{
    public interface ICalculEnergia
    {
        void ConfigurarParametres(double valor);
        double CalcularEnergia();
        void MostrarInforme();

    }
}
