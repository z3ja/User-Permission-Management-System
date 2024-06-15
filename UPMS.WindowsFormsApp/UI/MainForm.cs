using System;
using System.Data;
using System.Windows.Forms;
using UPMS.WindowsFormsApp.DataAccess.DAO;
using UPMS.WindowsFormsApp.UI.PagesForm;
using UPMS.WindowsFormsApp.UI.PagesForm.PermissionPage;
using UPMS.WindowsFormsApp.UI.PagesForm.RolePage;
namespace UPMS.WindowsFormsApp.UI
{
    public partial class MainForm : Form
    {
        titleDao td = new titleDao();
        RoleDao roleDao = new RoleDao();

        DataTable dt;

        public MainForm(DataTable dt)
        {
            InitializeComponent();
            this.dt = dt;
            Permission();
        }


        private void Permission()
        {
            if (Convert.ToBoolean(dt.Rows[0]["button1"]) == true)
            {
                button1.Enabled = true;


            }
            else
            {
                button1.Enabled = false;
            }
            if (Convert.ToBoolean(dt.Rows[0]["button2"]) == true)
            {
                button2.Enabled = true;


            }
            else
            {
                button2.Enabled = false;
            }
            if (Convert.ToBoolean(dt.Rows[0]["button3"]) == true)
            {
                button3.Enabled = true;
            }
            else
            {
                button3.Enabled = false;
            }
            if (Convert.ToBoolean(dt.Rows[0]["button4"]) == true)
            {
                button4.Enabled = true;
            }
            else
            {
                button4.Enabled = false;
            }
            if (Convert.ToBoolean(dt.Rows[0]["button5"]) == true)
            {
                button5.Enabled = true;
            }
            else
            {
                button5.Enabled = false;
            }
        }



        private void MainForm_Load(object sender, EventArgs e)
        {
            DataTable dataTable = td.GetALL();
            DataTable rdt = roleDao.GetALL();
            IblTitleName.Text = dataTable.Rows[0][0].ToString();
            IblUsername.Text = dt.Rows[0][2].ToString();
            IblRoleName.Text = rdt.Rows[1][1].ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            IblDateTime.Text = DateTime.Now.ToString();

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                LoginForm lg = new LoginForm();
                lg.Show();
                this.Close();
            }
        }

        private void userManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserPageForm userPageForm = new UserPageForm();
            userPageForm.ShowDialog();
        }

        private void roleManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RolePageForm rolePageForm = new RolePageForm();
            rolePageForm.ShowDialog();
        }

        private void permissionManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PermissionPageForm permissionPageForm = new PermissionPageForm();
            permissionPageForm.ShowDialog();
        }
    }
}
