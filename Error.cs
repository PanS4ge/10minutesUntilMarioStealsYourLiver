using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarioLiver
{
    public partial class Error : Form
    {
        public bool that_is_not_an_option = false;
        public bool not_show_error = false;
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
                SoundPlayer sp = new SoundPlayer(Properties.Resources.thatisnotanoption);
                sp.Play();
                e.Cancel = true;
                that_is_not_an_option = true;
            } else
            {
                if (!not_show_error)
                {
                    MessageBox.Show("Ok, I'll go, but Mario's already called", "Mario Error");
                }
            }
        }

        private void No_Click(object sender, EventArgs e)
        {
            if (!that_is_not_an_option)
            {
                Face.BackgroundImage = Properties.Resources.angry;
                SoundPlayer sp = new SoundPlayer(Properties.Resources.thatisnotanoption);
                sp.Play();
                No.Enabled = false;
                No.Text = "X";
                that_is_not_an_option = true;
            }
        }

        private void Wahoo_Click(object sender, EventArgs e)
        {
            not_show_error = true;
            Face.BackgroundImage = Properties.Resources.normal;
            that_is_not_an_option = true;
            this.Close();
        }
    }
}
