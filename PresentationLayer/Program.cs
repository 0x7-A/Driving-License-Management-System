using Project19_businessLayer;
using System.Diagnostics;

namespace Project_19_DVDL__2nd_
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            try
            {
                
                if (!EventLog.SourceExists(clsSystem.SourceName))
                {
                    EventLog.CreateEventSource(clsSystem.SourceName, "Application");
                }
            }
            catch (Exception ex)
            {
                // If it fails (usually due to lack of Admin rights on the first run),
                // you can show a message or handle it, but don't let it crash the startup.
                MessageBox.Show($"Failed to initialize event log: {ex.Message}. Please run as Administrator once.", "Initialization Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


           
            ApplicationConfiguration.Initialize();
            Application.Run(new frmLogin());
        }
    }
}