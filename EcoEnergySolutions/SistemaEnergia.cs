using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoEnergySolutions
{
    public abstract class SistemaEnergia : ICalculEnergia
    {
        protected DateTime DataSimulacio {  get; set; }
        protected double EnergiaGenerada { get; set; }

        public abstract void ConfigurarParametres(float valor);
        public abstract double CalcularEnergia();

        public virtual void MostrarInforme()
        {
            Console.WriteLine($"Data: {DataSimulacio}, Energia: {EnergiaGenerada} kWh");
        }
    }
}
