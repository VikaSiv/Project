using Project.Date;
using Microsoft.EntityFrameworkCore;
using Project.Models;
using System.Data;
using Project.UserContols;
using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot;
using OxyPlot.Legends;

namespace Project
{
    public partial class ProjectView : Form
    {
        private Models.Project _project;
        private Area _selectedArea;
        private Profile _selectedProfile;
        private User _user;
        public ProjectView(Models.Project project, User user)
        {
            _user = user;
            _project = project;
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            if (_user.Role == "User")
            {
                AddAreaBtn.Visible = false;
                AddProfileBtn.Visible = false;
                AddPicketBtn.Visible = false;
            }

            ProjectNameTxt.Text = _project.ProjectName;

            using (var db = new AppDbContext())
            {
                var areas = db.ProjectAreas
                    .Where(pa => pa.ProjectID == _project.ProjectID)
                    .Include(pa => pa.Area)
                    .Select(pa => pa.Area)
                    .ToList();

                ListAreasCmb.DataSource = areas;
                ListAreasCmb.DisplayMember = "AreaID";
                ListAreasCmb.ValueMember = "AreaID";

                ListProfilesCmb.Enabled = false;
                ListPicketsCmb.Enabled = false;

                ListAreasCmb.SelectedIndexChanged += ListAreasCmb_SelectedIndexChanged;
            }
        }

        private void ListAreasCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedProfile = null;

            ListProfilesCmb.DataSource = null;
            ListProfilesCmb.Enabled = false;

            ListPicketsCmb.DataSource = null;
            ListPicketsCmb.Enabled = false;

            PicketPanel.Controls.Clear();

            _selectedArea = ListAreasCmb.SelectedItem as Area;

            if (_selectedArea != null)
            {
                using (var db = new AppDbContext())
                {
                    var areaWithData = db.Areas
                        .Include(a => a.AreaCoordinates)
                        .Include(a => a.AreaProfiles)
                            .ThenInclude(ap => ap.Profile)
                            .ThenInclude(p => p.ProfileCoordinates)
                        .FirstOrDefault(a => a.AreaID == _selectedArea.AreaID);

                    if (areaWithData != null)
                    {
                        PlotAreaWithProfiles(areaWithData);
                    }

                    var profiles = db.AreaProfiles
                        .Where(ap => ap.AreaID == _selectedArea.AreaID)
                        .Include(ap => ap.Profile)
                        .Select(ap => ap.Profile)
                        .ToList();

                    ListProfilesCmb.DataSource = profiles;
                    ListProfilesCmb.DisplayMember = "ProfileID";
                    ListProfilesCmb.ValueMember = "ProfileID";

                    ListProfilesCmb.Enabled = true;

                    ListProfilesCmb.SelectedIndexChanged -= ListProfilesCmb_SelectedIndexChanged;
                    ListProfilesCmb.SelectedIndexChanged += ListProfilesCmb_SelectedIndexChanged;
                }
            }

        }

        private void ListProfilesCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListPicketsCmb.DataSource = null;
            ListPicketsCmb.Enabled = false;

            PicketPanel.Controls.Clear();

            _selectedProfile = ListProfilesCmb.SelectedItem as Profile;
            if (_selectedProfile != null)
            {
                using (var db = new AppDbContext())
                {
                    var pickets = db.ProfilePickets
                        .Where(pp => pp.ProfileID == _selectedProfile.ProfileID)
                        .Include(pp => pp.Picket)
                        .ThenInclude(p => p.Measurements)
                        .Select(pp => pp.Picket)
                        .ToList();

                    ListPicketsCmb.DataSource = pickets;
                    ListPicketsCmb.DisplayMember = "PicketID";
                    ListPicketsCmb.ValueMember = "PicketID";

                    var allMeasurements = pickets
                        .SelectMany(p => p.Measurements)
                        .OrderBy(m => m.MeasurementDate)
                        .ToList();

                    PlotMeasurements(allMeasurements);

                    ListPicketsCmb.Enabled = true;

                    ListPicketsCmb.SelectedIndexChanged -= ListPicketsCmb_SelectedIndexChanged;
                    ListPicketsCmb.SelectedIndexChanged += ListPicketsCmb_SelectedIndexChanged;
                }
            }
        }

        private void ListPicketsCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            PicketPanel.Controls.Clear();
            if (ListPicketsCmb.SelectedItem is Picket selectedPicket)
            {
                PicketInfo picketInfo = new PicketInfo(selectedPicket);
                PicketPanel.Controls.Add(picketInfo);
            }

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(_user);
            form2.Show();
            this.Close();
        }

        private void AddAreaBtn_Click(object sender, EventArgs e)
        {
            AddAreaForm addAreaForm = new AddAreaForm(this, _project.ProjectID);
            addAreaForm.Show();
        }

        private void AddProfileBtn_Click(object sender, EventArgs e)
        {
            if (_selectedArea != null)
            {
                AddProfileForm addProfileForm = new AddProfileForm(this, _selectedArea.AreaID);
                addProfileForm.Show();
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите площадь");
            }
        }

        private void AddPicketBtn_Click(object sender, EventArgs e)
        {
            if (_selectedProfile != null)
            {
                AddPicketForm addPicketForm = new AddPicketForm(this, _selectedProfile.ProfileID);
                addPicketForm.Show();
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите профиль");
            }
        }

        private void PlotMeasurements(List<Measurement> measurements)
        {
            // Создаем модель графика
            var plotModel = new PlotModel { Title = "Измерения по профилю" };

            // Создаем серию данных
            var series = new LineSeries
            {
                Title = "Значения измерений",
                MarkerType = MarkerType.Circle,
                MarkerSize = 4,
                MarkerStroke = OxyColors.White
            };

            // Добавляем точки данных
            foreach (var measurement in measurements)
            {
                series.Points.Add(new DataPoint(
                    DateTimeAxis.ToDouble(measurement.MeasurementDate),
                    measurement.Value));
            }

            // Добавляем серию в модель
            plotModel.Series.Add(series);

            // Настраиваем оси
            plotModel.Axes.Add(new DateTimeAxis
            {
                Position = AxisPosition.Bottom,
                Title = "Время",
                StringFormat = "dd.MM.yyyy",
                Angle = -90,
            });

            plotModel.Axes.Add(new LinearAxis
            {
                Position = AxisPosition.Left,
                Title = "Значение (" + measurements.FirstOrDefault()?.Unit + ")",
            });

            // Обновляем график
            GraphicView.Model = plotModel;
        }

        private void PlotAreaWithProfiles(Area area)
        {
            var plotModel = new PlotModel { Title = area.AreaDescription };

            // Заливка площади
            var areaFillSeries = new AreaSeries
            {
                Title = "Площадь",
                Color = OxyColors.Blue,
                Fill = OxyColor.FromAColor(30, OxyColors.Blue)
            };

            // Контур площади
            var areaBorderSeries = new LineSeries
            {
                Title = "Границы площади",
                Color = OxyColors.Blue,
                StrokeThickness = 2
            };

            // Добавляем точки площади
            var orderedCoords = area.AreaCoordinates.OrderBy(c => c.AreaCoordinatesID).ToList();
            foreach (var coord in orderedCoords)
            {
                areaBorderSeries.Points.Add(new DataPoint(coord.X, coord.Y));
                areaFillSeries.Points.Add(new DataPoint(coord.X, coord.Y));
            }

            // Замыкаем полигон
            if (orderedCoords.Any())
            {
                var first = orderedCoords.First();
                areaBorderSeries.Points.Add(new DataPoint(first.X, first.Y));
                areaFillSeries.Points.Add(new DataPoint(first.X, first.Y));
            }

            plotModel.Series.Add(areaFillSeries);
            plotModel.Series.Add(areaBorderSeries);

            // Добавляем профили
            var colors = new[] { OxyColors.Red, OxyColors.Green, OxyColors.Orange, OxyColors.Purple };
            int colorIndex = 0;

            foreach (var areaProfile in area.AreaProfiles)
            {
                var profile = areaProfile.Profile;
                var profileSeries = new LineSeries
                {
                    Title = $"Профиль {profile.ProfileID}",
                    Color = colors[colorIndex % colors.Length],
                    StrokeThickness = 1.5,
                    MarkerType = MarkerType.Circle,
                    MarkerSize = 3,
                    MarkerFill = colors[colorIndex % colors.Length]
                };

                foreach (var coord in profile.ProfileCoordinates.OrderBy(c => c.ProfileCoordinatesID))
                {
                    profileSeries.Points.Add(new DataPoint(coord.X, coord.Y));
                }

                plotModel.Series.Add(profileSeries);
                colorIndex++;
            }

            // Оси
            plotModel.Axes.Add(new LinearAxis { Position = AxisPosition.Bottom, Title = "X" });
            plotModel.Axes.Add(new LinearAxis { Position = AxisPosition.Left, Title = "Y" });

            // Автомасштабирование
            plotModel.InvalidatePlot(true);

            AreaGraphic.Model = plotModel;
        }

    }
}
