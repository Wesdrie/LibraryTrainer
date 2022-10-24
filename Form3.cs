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
        /// <summary>
        /// VARIBLES
        /// </summary>
        Tools wrench = new Tools();

        Dictionary<string, string> dictionaryAreas = new Dictionary<string, string>()
        {
            {"000 - 099", "Basic Information, Encyclopedias & Record Books"},
            {"100 - 199", "Paranormal Phenomena, Ethics & “Who Am I”"},
            {"200 - 299", "Christians, Hindus & Mythology"},
            {"300 - 399", "Laws, Cultures & Folklore"},
            {"400 - 499", "Dictionaries, Speech & Sign Language"},
            {"500 - 599", "Physics, Chemistry & Biology"},
            {"600 - 699", "Inventions, Robots & Transportation"},
            {"700 - 799", "Comics, Music & Sports"},
            {"800 - 899", "Shakespeare, Classic Literature & Riddles"},
            {"900 - 999", "Exploration, Countries & Factual Events"}
        };
        Dictionary<string, string> dictionaryNumbers = new Dictionary<string, string>()
        {
            {"000 - 099", "General Works"},
            {"100 - 199", "Philosophy & Psychology"},
            {"200 - 299", "Religion"},
            {"300 - 399", "Social Sciences"},
            {"400 - 499", "Languages"},
            {"500 - 599", "Science"},
            {"600 - 699", "Technology"},
            {"700 - 799", "The Arts"},
            {"800 - 899", "Literature & Rhetoric"},
            {"900 - 999", "History & Geography"}
        };

        int timerTicker, userScore;
        public WindowAreas()
        {
            InitializeComponent();
        }
        /// <summary>
        /// ON LOAD BEGIN TIMER, GENERATE ITEMS AND FILL LISTS FOR CHECKS
        /// </summary>
        private void WindowAreas_Load(object sender, EventArgs e)
        {
            try
            {
                /// <remarks>
                /// CONNECT TO DATABASE TO PULL SCORES
                /// </remarks>
                
                /// <remarks>
                /// IMPLEMENTS DICITONARY
                /// </remarks>
                


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

        /// <summary>
        /// NAVIGATION BUTTONS & ENSURE APPLICAITON CLOSES
        /// </summary>
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
