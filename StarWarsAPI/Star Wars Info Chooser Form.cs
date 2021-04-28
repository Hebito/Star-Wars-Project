using StarWarsAPI.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarWarsAPI
{
    public partial class StarWarsHomeScreenForm : Form
    {
        
        public StarWarsHomeScreenForm()
        {
            InitializeComponent();
        }

        //Following buttons open other windows forms
        private void btn_SelectPeople_Click(object sender, EventArgs e)
        {
            this.Hide();
            StarWarsPeopleForm f1 = new StarWarsPeopleForm();
            f1.Show();
        }

        private void btn_SelectPlanets_Click(object sender, EventArgs e)
        {
            this.Hide();
            StarWarsPlanetForm f1 = new StarWarsPlanetForm();
            f1.Show();
        }

        private void btn_SelectSpecies_Click(object sender, EventArgs e)
        {
            this.Hide();
            StarWarsSpeciesForm f1 = new StarWarsSpeciesForm();
            f1.Show();
        }
    }
}
