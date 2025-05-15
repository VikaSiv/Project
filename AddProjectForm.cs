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
    public partial class AddProjectForm : Form
    {
        private Form2 _form;
        public AddProjectForm(Form2 form)
        {
            _form = form;
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            using (var db = new AppDbContext())
            {
                var users = db.Users.ToList();
                CustomerComboBox.DataSource = users;
                CustomerComboBox.ValueMember = "CustomerID";
                CustomerComboBox.DisplayMember = "Name";
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            using (var db = new AppDbContext())
            {
                Models.Project newProject = new Models.Project
                {
                    CustomerID = (int)CustomerComboBox.SelectedValue,
                    ProjectName = ProjectNameTextBox.Text,
                    Status = StatusComboBox.SelectedItem.ToString()
                };
                db.Projects.Add(newProject);
                db.SaveChanges();
                MessageBox.Show("Проект успешо добоавлен!");
                _form.Show();
                _form.LoadData();
                this.Close();
            }
        }
    }
}
