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
            Console.WriteLine($"| {"Data Simulacio",-20} | {"Tipus Sistema",-20} | {"Energia Generada",-20} |");
            Console.WriteLine(new string('-', 70));
            Console.WriteLine($"| {DataSimulacio,-20:F2} | {GetType().Name,-20} | {CalcularEnergia(),-20:F2} |");
        }
    }
}
