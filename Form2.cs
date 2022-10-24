using System;
using System.Collections;
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
        List<String> sortedDecimals = new List<String>();
        List<String> userDecimals = new List<String>();

        int timerTicker, userScore;

        public WindowSort()
        {
            InitializeComponent();
        }

        /// <summary>
        /// ON LOAD BEGIN TIMER, GENERATE ITEMS AND FILL LISTS FOR CHECKS
        /// </summary>
        private void WindowSort_Load(object sender, EventArgs e)
        {
            try
            {
                /// <remarks>
                /// CONNECT TO DATABASE TO PULL SCORES
                /// </remarks>

                TimerSort.Start();

                for (int i = 0; i < 10; i++)
                {
                    System.Threading.Thread.Sleep(10);

                    generatedDecimals.Add(wrench.GenerateDecimal());
                    sortedDecimals.Add(generatedDecimals[i]);
                    ListSort.Items.Add(generatedDecimals[i]);

                    System.Threading.Thread.Sleep(10);
                }

                sortedDecimals.Sort();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void TimerSort_Tick(object sender, EventArgs e)
        {
            try
            {
                timerTicker++;
                TimeLabel.Text = timerTicker.ToString() + " Seconds";

                userDecimals.Clear();

                foreach(var item in ListSort.Items)
                {
                    userDecimals.Add(item.ToString());
                }

                userScore = wrench.CustomCheck(sortedDecimals, userDecimals);
                TextScore.Text = userScore.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// DRAG & DROP REORDER
        /// </summary>
        private void ListSort_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                ListSort.DoDragDrop(ListSort.SelectedItem, DragDropEffects.Move);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void ListSort_DragOver(object sender, DragEventArgs e)
        {
            try
            {
                e.Effect = DragDropEffects.Move;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void ListSort_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                Point point = ListSort.PointToClient(new Point(e.X, e.Y));
                int index = ListSort.IndexFromPoint(point);
                if (index < 0)
                {
                    index = ListSort.Items.Count - 1;
                }

                ListSort.Items.Remove(e.Data.GetData(DataFormats.Text));
                ListSort.Items.Insert(index, e.Data.GetData(DataFormats.Text));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// NAVIGATION BUTTONS & ENSURE APPLICAITON CLOSES
        /// </summary>
        private void ButtonComplete_Click(object sender, EventArgs e)
        {
            try
            {
                TimerSort.Stop();
                /// <remarks>
                /// CONNECT TO DATABASE TO SAVE ATTEMPT
                /// </remarks>
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            try
            {
                // MOVE TO TOOLS
                TimerSort.Stop();
                timerTicker = 0;
                TimeLabel.Text = "0 Seconds";

                ListSort.Items.Clear();

                for (int i = 0; i < 10; i++)
                {
                    ListSort.Items.Add(generatedDecimals[i]);
                }

                TimerSort.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
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
