namespace EcoEnergySolutions
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            const string MenuProgramMsg = "A. Iniciar Simulació: Permet seleccionar";
            int menuNumSelect = 0;
            HelperClass.BucleComprovacio(MenuProgramMsg, menuNumSelect);
            switch (menuNumSelect)
            {
                case 1:
                    // nose
            }
        }
    }
}
