using Project.Date;
using Project.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class AddPicketForm : Form
    {
        private ProjectView _projectView;
        private int _selectedProfileId;
        public AddPicketForm(ProjectView projectView, int selectedProfileId)
        {
            _projectView = projectView;
            _selectedProfileId = selectedProfileId;
            InitializeComponent();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(LatitudeTextBox.Text) ||
                string.IsNullOrWhiteSpace(LongitudeTextBox.Text) ||
                string.IsNullOrWhiteSpace(ValueTextBox.Text) ||
                string.IsNullOrWhiteSpace(UnitTextBox.Text) ||
                MeasurementTypeComboBox.SelectedItem == null ||
                ElectrodeTypeComboBox.SelectedItem == null)
            {
                MessageBox.Show("Пожалуйста, заполните все поля");
                return;
            }

            if (!double.TryParse(LatitudeTextBox.Text, out double latitude) ||
                !double.TryParse(LongitudeTextBox.Text, out double longitude) ||
                !double.TryParse(ValueTextBox.Text, out double value))
            {
                MessageBox.Show("Широта, долгота и значение должны быть числовыми");
                return;
            }

            using (var db = new AppDbContext())
            {
                var newPicket = new Picket
                {
                    Latitude = latitude,
                    Longitude = longitude
                };

                var measurement = new Measurement
                {
                    MeasurementDate = MeasurementDatePicker.Value,
                    MeasurementType = MeasurementTypeComboBox.SelectedItem.ToString(),
                    ElectrodeType = ElectrodeTypeComboBox.SelectedItem.ToString(),
                    Value = value,
                    Unit = UnitTextBox.Text,
                    Picket = newPicket
                };

                db.Pickets.Add(newPicket);
                db.Measurements.Add(measurement);
                db.SaveChanges();

                var profilePicket = new ProfilePicket
                {
                    ProfileID = _selectedProfileId,
                    PicketID = newPicket.PicketID
                };

                db.ProfilePickets.Add(profilePicket);
                db.SaveChanges();

                MessageBox.Show("Пикет успешно добавлен");

                _projectView?.LoadData();

                this.Close();
            }
        }
    }
}
