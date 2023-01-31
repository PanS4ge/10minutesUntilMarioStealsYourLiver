using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace _3DaysMario
{
    public partial class Error : Form
    {
        public bool that_is_not_an_option = false;
        public Error()
        {
            InitializeComponent();
            SoundPlayer sp = new SoundPlayer(Properties.Resources._10minutes);
            sp.Play();
        }

        private void Error_Load(object sender, EventArgs e)
        {
            
        }

        private void Error_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!that_is_not_an_option)
            {
                Face.BackgroundImage = Properties.Resources.angry;
                SoundPlayer sp = new SoundPlayer(Properties.Resources.thatisnotanoption1);
                sp.Play();
                e.Cancel = true;
                that_is_not_an_option = true;
            }
        }

        private void No_Click(object sender, EventArgs e)
        {
            if (!that_is_not_an_option)
            {
                Face.BackgroundImage = Properties.Resources.angry;
                SoundPlayer sp = new SoundPlayer(Properties.Resources.thatisnotanoption1);
                sp.Play();
                No.Enabled = false;
                No.Text = "X";
                that_is_not_an_option = true;
            }
        }

        private void Wahoo_Click(object sender, EventArgs e)
        {
            Face.BackgroundImage = Properties.Resources.normal;
            that_is_not_an_option = true;
            this.Close();
        }
    }
}
