using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryTrainer
{
    public partial class WindowAreas : Form
    {
        public WindowAreas()
        {
            InitializeComponent();
        }

        /// <summary>
        /// NAVIGATION BUTTONS
        /// </summary>
        private void ButtonReset_Click(object sender, EventArgs e)
        {

        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            WindowMain windowMain = new WindowMain();
            windowMain.Show();

            this.Close();
        }
    }
}
