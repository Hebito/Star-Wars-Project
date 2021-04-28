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
    public partial class StarWarsPlanetForm : Form
    {
        public StarWarsPlanetForm()
        {
            InitializeComponent();
        }

        //Implements confirmed planet id into planet object and displays information in labels
        public async void FindPlanetID(string PlanetID)
        {
            string ConfirmedPlanetID = PlanetID;
            Planet p = await JSONHelper.GetPlanet(ConfirmedPlanetID);
            label_Planet.Text = p.name;
            label_Rotation.Text = p.rotation_period;
            label_Orbital.Text = p.orbital_period;
            label_Diameter.Text = p.diameter;
            label_Climate.Text = p.climate;
            label_Gravity.Text = p.gravity;
            label_Terrain.Text = p.terrain;
            label_SurfaceWater.Text = p.surface_water;
            label_Population.Text = p.population;
        }

        public async void btn_Planet_Click(object sender, EventArgs e)
        {
            int PlanetID;

            //Try Catch to ensure user doesn't cause break
            try
            {
                PlanetID = int.Parse(txt_IDSubmit.Text);
                if (PlanetID > 0 && PlanetID < 61)
                {
                    FindPlanetID(PlanetID.ToString());
                }
                else
                {
                    MessageBox.Show("The Planet ID entered is not valid, please try again!");
                }
            }

            catch (FormatException)
            {
                MessageBox.Show("The Planet ID entered is not valid, please try again!");
            }
        }

        //Logout to Homescreen
        private void btn_Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            StarWarsHomeScreenForm f1 = new StarWarsHomeScreenForm();
            f1.Show();
        }
    }

}



