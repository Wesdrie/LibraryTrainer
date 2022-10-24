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
            new CallAreas("200 - 299", "Religion", "Christians, Hindus & Mythology"),
            new CallAreas("300 - 399", "Social Sciences", "Laws, Cultures & Folklore"),
            new CallAreas("400 - 499", "Languages", "Dictionaries, Speech & Sign Language"),
            new CallAreas("500 - 599", "Science", "Physics, Chemistry & Biology"),
            new CallAreas("600 - 699", "Technology", "Inventions, Robots & Transportation"),
            new CallAreas("700 - 799", "The Arts", "Comics, Music & Sports"),
            new CallAreas("800 - 899", "Literature & Rhetoric", "Shakespeare, Classic Literature & Riddles"),
            new CallAreas("900 - 999", "History & Geography", "Exploration, Countries & Factual Events"),
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
