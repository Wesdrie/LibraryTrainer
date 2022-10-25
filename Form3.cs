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
        Random random = new Random();

        /// <summary>
        /// PREDETERMINED DICTIONARY VALUES.
        /// CREATED AS OBJECT TO REFERNCE MORE INFROMATION.
        /// NEEDS TO BE STORED ON DB.
        /// </summary>
        CallAreas[] callAreas =
        {
            new CallAreas(0, "000 - 099", "General Works", "Basic Information, Encyclopedias & Record Books"),
            new CallAreas(1, "100 - 199", "Philosophy & Psychology", "Paranormal Phenomena, Ethics & “Who Am I”"),
            new CallAreas(2, "200 - 299", "Religion", "Christians, Hindus & Mythology"),
            new CallAreas(3, "300 - 399", "Social Sciences", "Laws, Cultures & Folklore"),
            new CallAreas(4, "400 - 499", "Languages", "Dictionaries, Speech & Sign Language"),
            new CallAreas(5, "500 - 599", "Science", "Physics, Chemistry & Biology"),
            new CallAreas(6, "600 - 699", "Technology", "Inventions, Robots & Transportation"),
            new CallAreas(7, "700 - 799", "The Arts", "Comics, Music & Sports"),
            new CallAreas(8, "800 - 899", "Literature & Rhetoric", "Shakespeare, Classic Literature & Riddles"),
            new CallAreas(9, "900 - 999", "History & Geography", "Exploration, Countries & Factual Events"),
        };

        Dictionary<int, CallAreas> areasDictionary = new Dictionary<int, CallAreas>();
        Dictionary<int, int> randomDictionary = new Dictionary<int, int>();

        List<int> randomAreas = new List<int>();
        List<String> userAreas = new List<String>();
        List<String> numberAreas = new List<String>();
        List<String> textAreas = new List<String>();

        int timerTicker, userScore, randomPicker;
        public WindowAreas()
        {
            InitializeComponent();
        }

        /// <summary>
        /// ON WINDOW LOAD PREFORM THESE FUNCTIONS:
        /// CREATE AND DISPLAY ASSOICATED DATA IN TWO COLUMNS.
        /// </summary>
        private void WindowAreas_Load(object sender, EventArgs e)
        {
            try
            {
                randomAreas.AddRange(wrench.RandomAreas());

                foreach(CallAreas area in callAreas)
                {
                    areasDictionary.Add(area.AreaIndex, area);
                }

                foreach(int i in randomAreas)
                {
                    ListText.Items.Add(areasDictionary[i].AreaDescription);
                }

                for(int i = 0; i < 4; i++)
                {
                    ListNumbers.Items.Add(areasDictionary[randomAreas[i+1]].AreaNumber);
                }

                TimerAreas.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// BEGINS TIMER FOR USERS COMPETION & BEGINS CHECKING OPERATIONS FOR USERS POINTS.
        /// </summary>
        private void TimerAreas_Tick(object sender, EventArgs e)
        {
            try
            {
                timerTicker++;
                TextTime.Text = timerTicker.ToString() + " Seconds";

                userAreas.Clear();

                foreach (var item in ListNumbers.Items)
                {
                    numberAreas.Add(item.ToString());
                }
                numberAreas.Sort();

                foreach (var item in ListText.Items)
                {
                    textAreas.Add(item.ToString());
                }

                for(int i = 0; i < numberAreas.Count; i++)
                {
                    if (areasDictionary[numberAreas[i].ToString()];
                    {
                        Console.WriteLine("1");
                    }
                    else
                    {
                        Console.WriteLine("2");
                    }
                }

                //userScore = wrench.CheckDecimal(sortedDecimals, userDecimals);
                //TextScore.Text = userScore.ToString();
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
