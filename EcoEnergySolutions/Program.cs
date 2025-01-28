using System;

namespace EcoEnergySolutions
{
    internal class Program
    {
        static SistemaEnergia[] simulacions;
        public static void Main(string[] args)
        {
            const string MenuProgramMsg = "1. Iniciar Simulació: " +
                "\n2. Veure informe de simulacions: " +
                "\n3. Sortir: ";
            const string MsgMenuError = "Numero no vàlid \nTorna a provar-lo";
            string menuNumSelect = "";
            bool sortir = true;
            bool flagCom = true;
            int simulacionsActuals = 0;
            while (sortir)
            {
                Console.WriteLine(MenuProgramMsg);
                menuNumSelect = Console.ReadLine();
                switch (menuNumSelect)
                {
                    case "1":
                        IniciarSimulacio(ref simulacionsActuals, ref flagCom);
                        break;
                    case "2":
                        InformeSimulacions(ref simulacionsActuals);
                        break;
                    case "3":
                        sortir = false;
                        break;
                    default:
                        Console.WriteLine(MsgMenuError);
                        break;
                }
            }
        }
        public static void IniciarSimulacio(ref int simulacionsActuals, ref bool flagCom)
        {
            const string MsgSimulacions = "Quantes simulacions vols generar?";
            const string MsgSenseSimulacions = "No hi ha espai per mes simulacions";
            const string MsgTipusSistema = "Selecciona el tipus de sistema: " +
                "\n1. Solar" +
                "\n2. Eòlic" +
                "\n3. Hidroeléctric";
            const string MsgError = "Opció no valida";
            string tipusSistema = "";
            bool flag = true;
            int numSimulacions = 0;
            
            while (flagCom)
            {
                Console.WriteLine(MsgSimulacions);
                numSimulacions = HelperClass.ValidarNum(Console.ReadLine());
                if (numSimulacions != 0 && numSimulacions >= 0)
                {
                    flagCom = false;
                    simulacions = new SistemaEnergia[numSimulacions];
                }else
                {
                    Console.WriteLine(MsgError);
                }
            }
            

            if (simulacionsActuals >= simulacions.Length)
            {
                Console.WriteLine(MsgSenseSimulacions);
                return;
            }
            SistemaEnergia? sistema = null;
            while (flag)
            {
                Console.WriteLine(MsgTipusSistema);
                tipusSistema = Console.ReadLine();
                switch (tipusSistema)
                {
                    case "1":
                        sistema = new SistemaSolar();
                        flag = false;
                        break;
                    case "2":
                        sistema = new SistemaEolic();
                        flag = false;
                        break;
                    case "3":
                        sistema = new SistemaHidroelectric();
                        flag = false;
                        break;
                    default:
                        Console.WriteLine(MsgError);
                        flag = true;
                        break;
                }
            }
            
            sistema.ConfigurarParametres();
            sistema.CalcularEnergia();
            Console.WriteLine($"| {"Data Simulacio",-20} | {"Tipus Sistema",-20} | {"Energia Generada",-20} |");
            sistema.MostrarInforme();
            Console.WriteLine("");

            simulacions[simulacionsActuals] = sistema;
            simulacionsActuals++;
        }
        public static void InformeSimulacions(ref int simulacionsActuals)
        {
            Console.WriteLine("\n--- Informe de Simulacions ---");
            Console.WriteLine($"| {"Data Simulacio",-20} | {"Tipus Sistema",-20} | {"Energia Generada",-20} |");
            for (int i = 0; i < simulacionsActuals; i++)
            {
                SistemaEnergia sim = simulacions[i];
                sim.MostrarInforme();
                Console.WriteLine("");
            }
        }
    }
}
