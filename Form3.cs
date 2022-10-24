using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace LibraryTrainer
{
    public partial class WindowAreas : Form
    {
        Tools wrench = new Tools();

        CallAreas[] callAreas =
        {
            new CallAreas("000 - 099", "General Works", "Basic Information, Encyclopedias & Record Books"),
            new CallAreas("100 - 199", "Philosophy & Psychology", "Paranormal Phenomena, Ethics & “Who Am I”"),
        };

        Dictionary<string, CallAreas> allAreas = new Dictionary<string, CallAreas>();

        int timerTicker, userScore;
        public WindowAreas()
        {
            InitializeComponent();
        }
        private void WindowAreas_Load(object sender, EventArgs e)
        {
            try
            {
                foreach(CallAreas area in callAreas)
                {
                    allAreas.Add(area.AreaNumber, area);
                    Console.WriteLine(area.AreaName);
                }

                TimerAreas.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void TimerAreas_Tick(object sender, EventArgs e)
        {
            try
            {
                timerTicker++;
                TextTime.Text = timerTicker.ToString() + " Seconds";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void ButtonComplete_Click(object sender, EventArgs e)
        {
            try
            {
                TimerAreas.Stop();
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
                TimerAreas.Stop();
                timerTicker = 0;
                TextTime.Text = "0 Seconds";

                TimerAreas.Start();
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

        private void WindowAreas_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
