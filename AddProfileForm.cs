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
    public partial class AddProfileForm : Form
    {
        private ProjectView _projectView;
        private int _selectedArea;
        public AddProfileForm(ProjectView projectView, int selectedArea)
        {
            _projectView = projectView;
            _selectedArea = selectedArea;
            InitializeComponent();
        }

        private void SabeBtn_Click(object sender, EventArgs e)
        {
            if (TypeProfileComboBox.SelectedItem == null)
            {
                MessageBox.Show("Пожалуйста, выберите тип профиля");
                return;
            }

            if (string.IsNullOrWhiteSpace(YCordTextBox.Text) ||
                string.IsNullOrWhiteSpace(XCordTextBox.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все координаты");
                return;
            }

            if (!double.TryParse(YCordTextBox.Text, out double y) ||
                !double.TryParse(XCordTextBox.Text, out double x))
            {
                MessageBox.Show("Координаты должны быть числовыми значениями");
                return;
            }
            using (var db = new AppDbContext())
            {
                var newProfile = new Profile
                {
                    ProfileType = TypeProfileComboBox.SelectedItem.ToString(),
                    ProfileCoordinates = new List<ProfileCoordinate>
                {
                    new ProfileCoordinate { X = x, Y = y }
                }
                };

                db.Profiles.Add(newProfile);
                db.SaveChanges();

                var areaProfile = new AreaProfile
                {
                    AreaID = _selectedArea,
                    ProfileID = newProfile.ProfileID
                };

                db.AreaProfiles.Add(areaProfile);
                db.SaveChanges();

                MessageBox.Show("Профиль успешно добавлен");

                _projectView?.LoadData();

                this.Close();
            }
        }
    }
}
