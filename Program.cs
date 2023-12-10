using SarasaviLibMS.Forms;

namespace SarasaviLibMS
{
    internal static class Program
    {
        public static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\budd\source\repos\SarasaviLibMS\Database\library.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True";        /// <summary>
                                                                                                                                                                                                                                     ///  The main entry point for the application.
                                                                                                                                                                                                                                     /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
        }
    }
}