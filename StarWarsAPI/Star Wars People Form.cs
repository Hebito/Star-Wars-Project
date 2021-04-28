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

namespace StarWarsAPI
{
    public partial class StarWarsPeopleForm : Form
    {
        public string HomeWorld;
        public StarWarsPeopleForm()
        {
            InitializeComponent();
        }

        //Method for grabbing Confirmed ID, and then display information.
        public async void FindPeopleID(string PeopleID)
        {
            string ConfirmedPeopleID = PeopleID;
            People e = await JSONHelper.GetPeople(ConfirmedPeopleID);
            HomeWorld = e.homeworld;
            Planet p = await JSONHelper.GetHomeWorld(HomeWorld);
            List<string> StarshipList = new List<string>();
            foreach (string element in e.starships)
            {
                Starship s = await JSONHelper.GetStarShip(element);
                StarshipList.Add(s.name);
            }
            lb_Starships.DataSource = StarshipList;
            label_Name.Text = e.name;
            label_Height.Text = e.height;
            label_Mass.Text = e.mass;
            label_Hair.Text = e.hair_color;
            label_Skin.Text = e.skin_color;
            label_Birth.Text = e.birth_year;
            label_Eye.Text = e.eye_color;
            label_Gender.Text = e.gender;
            HomeWorld = e.homeworld;
            label_Home.Text = p.name;
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            int PersonID;

            //Try Catch to ensure the user doesn't break the program
            try
            {
                PersonID = int.Parse(txt_PersonID.Text);
                if (PersonID > 0 && PersonID < 84)
                {
                    FindPeopleID(PersonID.ToString());
                }
                else
                {
                    MessageBox.Show("The Person's ID entered is not valid, please try again!");
                }
            }

            catch (FormatException)
            {
                MessageBox.Show("The Person's ID entered is not valid, please try again!");
            }
        }

        //Logout back to Homescreen
        private void btn_Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            StarWarsHomeScreenForm f1 = new StarWarsHomeScreenForm();
            f1.Show();
        }
    }
}

