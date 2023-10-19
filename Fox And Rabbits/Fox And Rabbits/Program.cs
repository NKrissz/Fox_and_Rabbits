namespace Fox_And_Rabbits
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new FoxAndRabbits());
        }
    }
}