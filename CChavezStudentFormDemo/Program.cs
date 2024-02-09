//  Program Name: CChavezStudentFormDemo
//  Programed by: Colby Chavez
//  Email: cchavez572@cnm.edu
//  Program goal: Demo 

namespace CChavezStudentFormDemo
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
            Application.Run(new fCchavezStudentFormDemo());
        }
    }
}