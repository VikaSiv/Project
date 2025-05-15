using Project.Date;
using Project.Models;
using Project.UserContols;

namespace Project
{
    public partial class Form2 : Form
    {
        private User _user;
        public Form2(User user)
        {
            _user = user;
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            if(_user.Role == "User")
            {
                AddProjectBtn.Visible = false;
                SeedDbBtn.Visible = false;
                ClearDbBtn.Visible = false;
            }

            ProjectListPanel.Controls.Clear();
            using (var db = new AppDbContext())
            {
                var projects = db.Projects.ToList();
                foreach (var project in projects)
                {
                    ProjectUserControl projectUserControl = new ProjectUserControl(project, this, _user);
                    ProjectListPanel.Controls.Add(projectUserControl);
                }
            }
        }

        private void AddProjectBtn_Click(object sender, EventArgs e)
        {
            AddProjectForm addProjectForm = new AddProjectForm(this);
            addProjectForm.Show();
            this.Hide();
        }

        private void SeedDbBtn_Click(object sender, EventArgs e)
        {
            using (var db = new AppDbContext())
            {
                DbSeeder dbSeeder = new DbSeeder(db);
                dbSeeder.Seed();
                LoadData();
            }
        }

        private void ClearDbBtn_Click(object sender, EventArgs e)
        {
            using (var db = new AppDbContext())
            {
                DbSeeder dbSeeder = new DbSeeder(db);
                dbSeeder.ClearDatabase();
                LoadData();
            }
        }
    }
}
