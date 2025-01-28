using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoEnergySolutions
{
    public abstract class SistemaEnergia : ICalculEnergia
    {
        public DateTime DataSimulacio {  get; } = DateTime.Now;
        protected double EnergiaGenerada { get; set; }

        public abstract float ConfigurarParametres();
        public abstract double CalcularEnergia();

        public virtual void MostrarInforme()
        {
            
            Console.WriteLine(new string('-', 70));
            Console.WriteLine($"| {DataSimulacio,-20} | {GetType().Name,-20} | {CalcularEnergia(),-20:F2} |");
        }
    }
}
