using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StarWarsAPI.Objects;

namespace StarWarsAPI.Objects
{
    public partial class StarWarsSpeciesForm : Form
    {
        public string HomeWorld;

        public StarWarsSpeciesForm()
        {
            InitializeComponent();
        }

        //Implements confirmed species ID, and displays into labels
        public async void FindSpeciesID(string SpeciesID)
        {
            string ConfirmedSpeciesID = SpeciesID;
            Species s = await JSONHelper.GetSpecies(ConfirmedSpeciesID);
            string HomeWorld = s.homeworld;

            //if-else statement to insure Homeworld method doesn't break with null url
            if (HomeWorld == null)
            {
                label_Home.Text = "Unknown";
            }
            else
            {
                Planet p = await JSONHelper.GetHomeWorld(HomeWorld);
                label_Home.Text = p.name;
            }

            //labels for form
            label_Name.Text = s.name;
            label_Classification.Text = s.classification;
            label_Designation.Text = s.designation;
            label_Height.Text = s.average_height;
            label_Skin.Text = s.skin_colors;
            label_Hair.Text = s.hair_colors;
            label_Eye.Text = s.eye_colors;
            label_Lifespan.Text = s.average_lifespan;
            label_Language.Text = s.language;
            
        }
        private void btn_Submit_Click(object sender, EventArgs e)
        {
            int SpeciesID;

            //try-catch statement to ensure user does not break form by going over intended ID amount.
            try
            {
                SpeciesID = int.Parse(txt_SpeciesID.Text);
                if (SpeciesID > 0 && SpeciesID < 38)
                {
                    FindSpeciesID(SpeciesID.ToString());
                }
                else
                {
                    MessageBox.Show("The Species ID entered is not valid, please try again!");
                }
            }

            catch (FormatException)
            {
                MessageBox.Show("The Species ID entered is not valid, please try again!");
            }
        }

        //Log out to Homescreen
        private void btn_Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            StarWarsHomeScreenForm f1 = new StarWarsHomeScreenForm();
            f1.Show();
        }
    }
}
