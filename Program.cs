using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace MarioLiver
{
    internal static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            new Thread(() =>
            {
                Application.Run(new Error());
            }).Start();
            new Thread(() =>
            {
                String hour10minuteLater = DateTime.Now.AddMinutes(10).ToString("HH:mm:ss");
                while (true)
                {
                    String hour = DateTime.Now.ToString("HH:mm:ss");
                    if (hour == hour10minuteLater)
                    {
                        Motherfucker mf = new Motherfucker();
                        Screen scr = Screen.PrimaryScreen;
                        mf.Size = new Size(scr.Bounds.Height, scr.Bounds.Height);
                        Application.Run(mf);
                    }
                    Thread.Sleep(1000);
                }
            }).Start();
        }
    }
}
