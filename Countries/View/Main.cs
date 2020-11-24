using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Countries.Iterfaces;
using Countries.View;

namespace Countries
{
    public partial class Main : Form
    {
        private ILogic LogicManager;

        public Main(ILogic manager)
        {
            InitializeComponent();

            LogicManager = manager;
        }

        private void GetInfoButton_Click(object sender, EventArgs e)
        {
            string errorMessage = "";
            Country country = LogicManager.GetCountryByName(CountryInput.Text, out errorMessage);

            if (errorMessage != "")
            {
                MessageBox.Show(errorMessage, "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (country.IsEmpty)
            {
                MessageBox.Show("Something going wrong!\nCheck youre country request or internet connection", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                InfoTextBox.Text = "";

                WriteTextToInfoTextBox(country);

                DialogResult result = MessageBox.Show("Do you want save this country in database?", "Save?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    LogicManager.SaveCountry(country, out errorMessage);

                    if (errorMessage != "")
                    {
                        MessageBox.Show(errorMessage, "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void WriteTextToInfoTextBox(Country country)
        {
            InfoTextBox.Text += "Country name: " + country.Name + Environment.NewLine +
                                "   Code: " + country.Code + Environment.NewLine +
                                "   Capital: " + country.Capital + Environment.NewLine +
                                "   Area: " + ((int)country.Area).ToString() + Environment.NewLine +
                                "   Population: " + country.Population.ToString() + Environment.NewLine +
                                "   Region: " + country.Region + Environment.NewLine;
        }

        private void GetAllCountryButton_Click(object sender, EventArgs e)
        {
            string errorMessage = "";
            IList<Country> countries = LogicManager.GetAllCountries(out errorMessage);

            if (errorMessage != "")
            {
                MessageBox.Show(errorMessage, "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                InfoTextBox.Text = "";

                if (countries.Count > 0)
                {
                    foreach (Country country in countries)
                    {
                        WriteTextToInfoTextBox(country);
                    }
                }
                else
                {
                    InfoTextBox.Text = "You havn't saves any country in database yet.";
                }
            }
        }
        
        private void EditConfigToolStrip_Click(object sender, EventArgs e)
        {
            UpdateConfig updateConfigForm = new UpdateConfig(LogicManager, LogicManager.GetConfigData());
            updateConfigForm.Show();
        }
    }
}
