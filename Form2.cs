﻿using System;
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
        public WindowSort()
        {
            InitializeComponent();
        }

        /// <summary>
        /// SORTING FUNCITONS
        /// </summary>
        private void WindowSort_Load(object sender, EventArgs e)
        {
            Console.WriteLine("MARK");
        }

        /// <summary>
        /// NAVIGATION BUTTONS & ENSURE APPLICAITON CLOSES
        /// </summary>
        private void ButtonReset_Click(object sender, EventArgs e)
        {

        }

        private void ButtonComplete_Click(object sender, EventArgs e)
        {

        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            WindowMain windowMain = new WindowMain();
            windowMain.Show();

            this.Close();
        }

        private void WindowSort_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
