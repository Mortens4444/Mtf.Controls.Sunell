using Mtf.Controls.Sunell.SunellSdk;

namespace Mtf.Controls.Sunell.Test
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

            _ = Sdk.sdk_dev_init(null);
            Application.Run(new MainForm());
            Sdk.sdk_dev_quit();
        }
    }
}