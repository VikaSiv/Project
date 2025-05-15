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
        private List<ProfileCoordinate> _coordinates = new List<ProfileCoordinate>();
        public AddProfileForm(ProjectView projectView, int selectedArea)
        {
            _projectView = projectView;
            _selectedArea = selectedArea;
            InitializeComponent();

            CoordinatesDataGridView.AutoGenerateColumns = false;
            CoordinatesDataGridView.Columns.Add("X", "Координата X");
            CoordinatesDataGridView.Columns.Add("Y", "Координата Y");
            UpdateCoordinatesGrid();
        }

        private void SabeBtn_Click(object sender, EventArgs e)
        {
            if (TypeProfileComboBox.SelectedItem == null)
            {
                MessageBox.Show("Пожалуйста, выберите тип профиля");
                return;
            }

            if (_coordinates.Count < 2)
            {
                MessageBox.Show("Для создания профиля необходимо минимум 2 точки");
                return;
            }

            using (var db = new AppDbContext())
            {
                var newProfile = new Profile
                {
                    ProfileType = TypeProfileComboBox.SelectedItem.ToString(),
                    ProfileCoordinates = _coordinates.ToList()
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

        private void AddPointBtn_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(YCordTextBox.Text, out double y) ||
                !double.TryParse(XCordTextBox.Text, out double x))
            {
                MessageBox.Show("Координаты должны быть числовыми значениями");
                return;
            }

            _coordinates.Add(new ProfileCoordinate { X = x, Y = y });
            UpdateCoordinatesGrid();

            // Очищаем поля для ввода
            XCordTextBox.Clear();
            YCordTextBox.Clear();
            XCordTextBox.Focus();
        }

        private void RemovePointBtn_Click(object sender, EventArgs e)
        {
            if (CoordinatesDataGridView.SelectedRows.Count > 0)
            {
                int index = CoordinatesDataGridView.SelectedRows[0].Index;
                if (index >= 0 && index < _coordinates.Count)
                {
                    _coordinates.RemoveAt(index);
                    UpdateCoordinatesGrid();
                }
            }
        }
        private void UpdateCoordinatesGrid()
        {
            CoordinatesDataGridView.Rows.Clear();
            foreach (var coord in _coordinates)
            {
                CoordinatesDataGridView.Rows.Add(coord.X, coord.Y);
            }

            SaveBtn.Enabled = _coordinates.Count >= 2 && TypeProfileComboBox.SelectedItem != null;
        }

        private void TypeProfileComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCoordinatesGrid();
        }
    }
}
