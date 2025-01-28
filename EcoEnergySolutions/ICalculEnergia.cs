using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoEnergySolutions
{
    public interface ICalculEnergia
    {
        float ConfigurarParametres();
        double CalcularEnergia();
        void MostrarInforme();
    }
}
