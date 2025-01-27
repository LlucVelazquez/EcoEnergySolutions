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
            const string MsgMenuError = "Numero no valid \nTorna a provar-lo";
            bool sortir = true;
            string menuNumSelect = "";
            int simulacionsActuals = 0;
            while (sortir)
            {
                Console.WriteLine(MenuProgramMsg);
                menuNumSelect = Console.ReadLine();
                switch (menuNumSelect)
                {
                    case "1":
                        IniciarSimulacio(ref simulacionsActuals);
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
        public static void IniciarSimulacio(ref int simulacionsActuals)
        {
            const string MsgSimulacions = "Quantes simulacions vols generar?";
            const string MsgSenseSimulacions = "No hi ha espai per mes simulacions";
            const string MsgTipusSistema = "Selecciona el tipus de sistema: " +
                "\n1. Solar" +
                "\n2. Eolic" +
                "\n3. Hidroelectric";
            const string MsgError = "Opcio no valida";
            string tipusSistema = "";
            bool flag = true;
            int numSimulacions = 0;
            bool flagCom = true;
            while (flag)
            {
                Console.WriteLine(MsgSimulacions);
                numSimulacions = ValidarNum(Console.ReadLine());
                if (numSimulacions != 0)
                {
                    flagCom = false;
                }
            }
            simulacions = new SistemaEnergia[numSimulacions];

            if (simulacionsActuals >= simulacions.Length)
            {
                Console.WriteLine(MsgSenseSimulacions);
                return;
            }
            SistemaEnergia? sistema;
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
            /*sistema.ConfigurarParametres();
            sistema.CalcularEnergia();
            sistema.DataSimulacio = DateTime.Now;

            simulacions[simulacionsActuals] = sistema;
            simulacionsActuals++;*/
        }
        public static void InformeSimulacions(ref int simulacionsActuals)
        {
            Console.WriteLine("\n--- Informe de Simulacions ---");
            Console.WriteLine("Data\t\t\tTipus\t\tEnergia (kWh)");
            for (int i = 0; i < simulacionsActuals; i++)
            {
                SistemaEnergia sim = simulacions[i];
                sim.MostrarInforme();
            }
        }
        public static int ValidarNum(string input)
        {
            int num = 0;
            try
            {
                num = int.Parse(input);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return num;
        }
    }
}
