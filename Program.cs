<<<<<<< Updated upstream
using System;
using System.Windows.Forms;
=======
using VehicleRentalSystem;
>>>>>>> Stashed changes

namespace Vehicle_Rental_System
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
<<<<<<< Updated upstream
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
=======
            ApplicationConfiguration.Initialize();
>>>>>>> Stashed changes
            Application.Run(new VehicleForm());
        }
    }
}