using Project.Date;
using Project.Models;

namespace Project
{
    public partial class AddAreaForm : Form
    {
        private ProjectView _projectView;
        private int _projectId;
        private List<AreaCoordinate> _coordinates = new List<AreaCoordinate>();
        public AddAreaForm(ProjectView projectForm, int projectId)
        {
            _projectView = projectForm;
            _projectId = projectId;
            InitializeComponent();

            CoordinatesDataGridView.AutoGenerateColumns = false;
            CoordinatesDataGridView.Columns.Add("X", "Координата X");
            CoordinatesDataGridView.Columns.Add("Y", "Координата Y");
            UpdateCoordinatesGrid();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(DescTextBox.Text))
            {
                MessageBox.Show("Пожалуйста, введите описание площади");
                return;
            }

            if (_coordinates.Count < 3)
            {
                MessageBox.Show("Для создания площади необходимо минимум 3 точки");
                return;
            }

            using (var db = new AppDbContext())
            {
                var newArea = new Area
                {
                    AreaDescription = DescTextBox.Text,
                    AreaCoordinates = _coordinates.ToList()
                };

                db.Areas.Add(newArea);
                db.SaveChanges();

                var projectArea = new ProjectArea
                {
                    ProjectID = _projectId,
                    AreaID = newArea.AreaID
                };

                db.ProjectAreas.Add(projectArea);
                db.SaveChanges();

                MessageBox.Show("Площадь успешно добавлена");
                _projectView.LoadData();
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

            _coordinates.Add(new AreaCoordinate { X = x, Y = y });
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

            SaveBtn.Enabled = _coordinates.Count >= 3; // Минимум 3 точки для полигона
        }
    }
}
