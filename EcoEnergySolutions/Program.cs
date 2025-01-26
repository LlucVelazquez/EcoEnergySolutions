namespace EcoEnergySolutions
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            const string MenuProgramMsg = "1. Iniciar Simulació: " +
                "\n2. Veure informe de simulacions: " +
                "\n3. Sortir: ";
            bool sortir = true;
            string menuNumSelect = "";
            while (sortir)
            {
                Console.WriteLine(MenuProgramMsg);
                menuNumSelect = Console.ReadLine();
                switch (menuNumSelect)
                {
                    case "1":
                        // Iniciar simulacio
                        Console.WriteLine("1 cas");
                        break;
                    case "2":
                        // informe
                        Console.WriteLine("2 cas");
                        break;
                    case "3":
                        sortir = false;
                        Console.WriteLine("3 cas");
                        break;
                    default:
                        Console.WriteLine("4 cas");
                        // errror
                        break;
                }
            }
        }
        public static void IniciarSimulacio()
        {
            const string MsgSimulacions = "Quantes simulacions vols generar?";
        }
    }
}
