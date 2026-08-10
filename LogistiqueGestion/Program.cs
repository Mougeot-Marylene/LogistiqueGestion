namespace LogistiqueGestion
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new Connexion());
            Application.Run(new FormPrincipale());
            //Application.Run(new Commandes_attentes());
            //Application.Run(new Commande_envoi());
            //Application.Run(new Commandes_finalisees());
            //test
        }
    }
}