namespace EcoEnergySolutions
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            const string MenuProgramMsg = "1. Iniciar Simulació: " +
                "2. Veure informe de simulacions: " +
                "3. Sortir: ";
            bool sortir = false;
            int menuNumSelect = 0;
            while (!sortir)
            {
                HelperClass.BucleComprovacio(MenuProgramMsg, menuNumSelect);
                switch (menuNumSelect)
                {
                    case 1:
                        // Iniciar simulacio
                    case 2:
                        // informe
                    case 3:
                        sortir = true;
                        break;
                    default:
                        // errror
                        break;
                }
            }
        }
    }
}
