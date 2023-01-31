using System.Media;

namespace _3DaysMario
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
            new Thread(() =>
            {
                Application.Run(new Error());
                Thread.Sleep(1000 * 60 * 10);
                Motherfucker mf = new Motherfucker();
                Screen scr = Screen.PrimaryScreen;
                mf.Size = new Size(scr.Bounds.Height, scr.Bounds.Height);
                Application.Run(mf);
            }).Start();
        }
    }
}