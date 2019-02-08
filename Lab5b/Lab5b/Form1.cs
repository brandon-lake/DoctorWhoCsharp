using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

/* I, Brandon Lake, 000766089 certify that this material is my original work. 
 * No other person's work has been used without due acknowledgement. 
 * Submitted for: December 7th 2018*/
namespace Lab5b
{
    /// <summary>
    /// The purpose of this program is to open a text file and parse the data into lists of doctor, companion, 
    /// and episode objects pertaining to Dr. Who.  The user can then view the data relevant to their chosen
    /// doctor
    /// </summary>
    public partial class Form1 : Form
    {
        // list of words for order, added 13th for forwards compatability
        private List<string> count = new List<string>() { "First", "Second", "Third", "Fourth", "Fifth", "Sixth",
                                                "Seventh", "Eighth", "Ninth", "Tenth", "Eleventh", "Twelfth", "Thirteenth" };
        private List<Doctor> doctors = new List<Doctor>();              // list of Doctors in the text file
        private List<Companion> companions = new List<Companion>();     // list of Companions in the text file
        private List<Episode> episodes = new List<Episode>();           // list of Episodes in the text file

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Close the application when user selects exit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitMenuStripItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you wish to exit?", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        /// <summary>
        /// Load file when user selects a valid text file.  If valid file found, build lists of objects,
        /// add appropriate number of options to the doctors combo box, and fill in left group box with
        /// appropriate information
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openMenuStripItem_Click(object sender, EventArgs e)
        {
            string fileName;    // string containing index to user selected file
            try
            {
                OpenFileDialog fileDialog = new OpenFileDialog
                {
                    Filter = "Text files(*.txt)|*.txt",
                    Title = "Find a Doctor Who Data File"
                };

                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    fileName = fileDialog.FileName;
                    BuildLists(fileName);               // build lists of doctors, companions, and episodes
                    // sort doctors so the index variable in UpdateForm will line up with that doctors order
                    doctors.Sort((a, b) => a.Order.CompareTo(b.Order));
                    FillComboBox();                     // add appropriate number of index strings to combo box
                    UpdateForm();                       // fill in appropriate information to left group box
                }
                else
                {
                    MessageBox.Show("You selected no file.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error opening file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Read through chosen text file and create a list of doctor, companion, and episode objects based
        /// on the text files' contents
        /// </summary>
        /// <param name="fileName">string containing the location of the chosen text file</param>
        private void BuildLists(string fileName)
        {
            try
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        string[] split = line.Split('|');       // contains attributes of object to be made

                        switch (split[0].Trim())
                        {
                            case "D":
                                Doctor d = new Doctor(int.Parse(split[1].Trim()), split[2].Trim(), int.Parse(split[3].Trim()),
                                                      int.Parse(split[4].Trim()), split[5].Trim());
                                doctors.Add(d);
                                break;
                            case "C":
                                Companion c = new Companion(split[1].Trim(), split[2].Trim(), int.Parse(split[3].Trim()),
                                                            split[4].Trim());
                                companions.Add(c);
                                break;
                            case "E":
                                Episode e = new Episode(split[1].Trim(), int.Parse(split[2].Trim()),
                                                        int.Parse(split[3].Trim()), split[4].Trim());
                                episodes.Add(e);
                                break;
                            default:
                                // do nothing
                                // this will be first 3 lines of text file
                                break;
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error reading file. Ensure valid data in file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Fill combo box with appropriate number of string indexers for doctors
        /// </summary>
        private void FillComboBox()
        {
            for (int i = 0; i < doctors.Count; i++)
                doctorsComboBox.Items.Add(count[i]);
            doctorsComboBox.Text = "First";
        }

        /// <summary>
        /// Updates information in left group box to match the currently selected doctor
        /// </summary>
        private void UpdateForm()
        {
            int index = count.IndexOf(doctorsComboBox.Text);        // number value of current doctor

            actorLabel.Text = doctors[index].Actor;
            seriesLabel.Text = "" + doctors[index].Series;
            ageLabel.Text = "" + doctors[index].Age;

            // no need to create an IEnumerable here, episode story is primary key
            // there will only ever be one selected
            Episode debut = episodes.First(a => a.Story == doctors[index].Debut);   
            yearLabel.Text = "" + debut.Year;
            episodeLabel.Text = debut.Title;   
        }

        /// <summary>
        /// Create a list of anonymous objects containing relevant information for the list box
        /// </summary>
        /// <param name="index">The doctor to find companion and episode information for</param>
        private void FindCompanions(int index)
        {
            // list of anonymous type objects containing relevant companion/episode information
            var partners = from c in companions
                           join e in episodes on c.Debut equals e.Story
                           where c.Doctor == index
                           orderby e.Year, e.Story
                           select new { c.Name, c.Actor, e.Title, e.Year };

            // add information to the list box
            foreach (var p in partners)
            {
                companionsListBox.Items.Add(p.Name + " (" + p.Actor + ")");
                companionsListBox.Items.Add("\"" + p.Title + "\" (" + p.Year + ")");
                companionsListBox.Items.Add("");
            }
        }

        /// <summary>
        /// When a new doctor is selected, update the information in the left group box and
        /// the list box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void doctorsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateForm();
            companionsListBox.Items.Clear();
            FindCompanions(doctorsComboBox.SelectedIndex + 1);
        }
    }
}
