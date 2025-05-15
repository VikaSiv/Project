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

namespace Project.UserContols
{
    public partial class ProjectUserControl : UserControl
    {
        private Models.Project _project;
        private Form2 _form;
        private User _user;
        public ProjectUserControl(Models.Project project, Form2 form, User user)
        {
            _user = user;
            _project = project;
            _form = form;
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            ProjectNameTxt.Text = _project.ProjectName;
            StatusTxt.Text = _project.Status;
        }

        private void MoreInfoBtn_Click(object sender, EventArgs e)
        {
            ProjectView projectView = new ProjectView(_project, _user);
            _form.Hide();
            projectView.Show();
        }
    }
}
