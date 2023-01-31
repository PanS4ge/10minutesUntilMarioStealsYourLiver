using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using Microsoft.VisualBasic;
using System.Media;
using System.Runtime.InteropServices;

namespace _3DaysMario
{
    public partial class Motherfucker : Form
    {
        [DllImport("winmm.dll", EntryPoint = "mciSendString")]
        public static extern int mciSendStringA(string lpstrCommand, string? lpstrReturnString,
                            int uReturnLength, int hwndCallback);

        public Motherfucker()
        {
            InitializeComponent();
            
        }

        private void Motherfucker_Load(object sender, EventArgs e)
        {
            
        }

        private void Motherfucker_Shown(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                SoundPlayer sp = new SoundPlayer(Properties.Resources.jeb1);
                sp.Play();
                Thread.Sleep(1200);
                this.BackgroundImage = Properties.Resources.mario_liver;
                SoundPlayer sp2 = new SoundPlayer(Properties.Resources.liver1);
                sp2.Play();
                Thread.Sleep(3400);
                mciSendStringA("set cdaudio door open", null, 0, 0);
            }).Start();
        }
    }
}
