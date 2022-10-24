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
        /// VARIBLES & AREAS OBJECT WITH VALUES (EVENTUALLY MOVE TO DB)
        /// </summary>
        Tools wrench = new Tools();

        /// <summary>
        /// STORING OBJECT IN DICTIONARY RETURNS NULL VALUES ?
        /// </summary>
        //Dictionary<int, CallAreas> areaDictionary = new Dictionary<int, CallAreas>();
        //List<CallAreas> areaList = new List<CallAreas>() {
        //    new CallAreas(0, "000 - 099", "General Works", "Basic Information, Encyclopedias & Record Books"),
        //    new CallAreas(1, "100 - 199", "Philosophy & Psychology", "Paranormal Phenomena, Ethics & “Who Am I”"),
        //    new CallAreas(2, "200 - 299", "Religion", "Christians, Hindus & Mythology"),
        //    new CallAreas(3, "300 - 399", "Social Sciences", "Laws, Cultures & Folklore"),
        //    new CallAreas(4, "400 - 499", "Languages", "Dictionaries, Speech & Sign Language"),
        //    new CallAreas(5, "500 - 599", "Science", "Physics, Chemistry & Biology"),
        //    new CallAreas(6, "600 - 699", "Technology", "Inventions, Robots & Transportation"),
        //    new CallAreas(7, "700 - 799", "The Arts", "Comics, Music & Sports"),
        //    new CallAreas(8, "800 - 899", "Literature & Rhetoric", "Shakespeare, Classic Literature & Riddles"),
        //    new CallAreas(9, "900 - 999", "History & Geography", "Exploration, Countries & Factual Events"),
        //};

        Dictionary<string, string> dictionaryAreas = new Dictionary<string, string>();
        Dictionary<string, string> dictionaryText = new Dictionary<string, string>();

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
                dictionaryAreas.Add("000 - 099", "General Works");
                dictionaryAreas.Add("100 - 199", "Philosophy & Psychology");
                dictionaryAreas.Add("200 - 299", "Religion");
                dictionaryAreas.Add("300 - 399", "Social Sciences");
                dictionaryAreas.Add("400 - 499", "Languages");
                dictionaryAreas.Add("500 - 599", "Science");
                dictionaryAreas.Add("600 - 699", "Technology");
                dictionaryAreas.Add("700 - 799", "The Arts");
                dictionaryAreas.Add("800 - 899", "Literature & Rhetoric");
                dictionaryAreas.Add("900 - 999", "History & Geography");

                dictionaryText.Add("000 - 099", "General Works");
                dictionaryText.Add("100 - 199", "Philosophy & Psychology");
                dictionaryText.Add("200 - 299", "Religion");
                dictionaryText.Add("300 - 399", "Social Sciences");
                dictionaryText.Add("400 - 499", "Languages");
                dictionaryText.Add("500 - 599", "Science");
                dictionaryText.Add("600 - 699", "Technology");
                dictionaryText.Add("700 - 799", "The Arts");
                dictionaryText.Add("800 - 899", "Literature & Rhetoric");
                dictionaryText.Add("900 - 999", "History & Geography");

                foreach (string key in dictionaryAreas.Keys)
                {
                    Console.WriteLine(key);
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
