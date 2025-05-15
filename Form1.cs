using Project.Date;

namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            using (var db = new AppDbContext())
            {
                var user = db.Users.FirstOrDefault(x => x.Login == LoginText.Text && x.Password == PasswordText.Text);
                if (user != null)
                {
                    Form2 form2 = new Form2(user);
                    this.Hide();
                    form2.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Проверьте данные");
                }
            }
        }
    }
}
