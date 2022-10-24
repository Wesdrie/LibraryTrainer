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
    public partial class WindowSort : Form
    {
        /// <summary>
        /// VARIBLES
        /// </summary>
        Tools wrench = new Tools();

        List<String> generatedDecimals = new List<String>();

        public WindowSort()
        {
            InitializeComponent();
        }

        /// <summary>
        /// SORTING FUNCITONS
        /// </summary>
        private void WindowSort_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < 10; i++)
            {
                System.Threading.Thread.Sleep(10);
                generatedDecimals.Add(wrench.GenerateDecimal());
                ListSort.Items.Add(generatedDecimals[i]);
                System.Threading.Thread.Sleep(10);
            }
        }

        /// <summary>
        /// NAVIGATION BUTTONS & ENSURE APPLICAITON CLOSES
        /// </summary>
        private void ButtonComplete_Click(object sender, EventArgs e)
        {

        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {

        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            WindowMain windowMain = new WindowMain();
            windowMain.Show();

            this.Hide();
        }

        private void WindowSort_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
