using System;
using System.Windows.Forms;
using UPMS.WindowsFormsApp.DataAccess.DAO;
using UPMS.WindowsFormsApp.Entity;
using UPMS.WindowsFormsApp.UI.PagesForm.UserPage;

namespace UPMS.WindowsFormsApp.UI.PagesForm
{
    public partial class UserPageForm : Form
    {
        UserDao userDao = new UserDao();
        UserEntity userEntity = new UserEntity();
        RoleDao roleDao = new RoleDao();
        public UserPageForm()
        {
            InitializeComponent();
        }

        private void GetAllUser()
        {
            userdgv.DataSource = userDao.GetALL();

        }
        private void UserPageForm_Load(object sender, EventArgs e)
        {
            GetAllUser();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            userDao.GetSearch(txtSearch.Text, userdgv);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            UserDetailsForm userDetailsForm = new UserDetailsForm();
            userDetailsForm.Text = "New User Details";
            userDetailsForm.btnEdit.Visible = false;
            userDetailsForm.ShowDialog();
            GetAllUser();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            UserDetailsForm userDetailsForm = new UserDetailsForm();
            if (userdgv.SelectedRows.Count > 0)
            {
                userDetailsForm.Text = "Edit User Details";
                userDetailsForm.btnSave.Visible = false;
                userDetailsForm.txtId.Text = userdgv.SelectedRows[0].Cells[0].Value.ToString();
                userDetailsForm.cmbRolename.Text = userdgv.SelectedRows[0].Cells[1].Value.ToString();
                userDetailsForm.txtUsername.Text = userdgv.SelectedRows[0].Cells[2].Value.ToString();
                userDetailsForm.txtPassword.Text = userdgv.SelectedRows[0].Cells[3].Value.ToString();
                userDetailsForm.cbActive.Checked = Boolean.Parse(userdgv.SelectedRows[0].Cells[4].Value.ToString());
                userDetailsForm.ShowDialog();

            }
            GetAllUser();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            userEntity.UId = Convert.ToInt32(userdgv.SelectedRows[0].Cells[0].Value.ToString());
            if (userdgv.SelectedRows.Count > 0)
            {
                bool delete = userDao.Delete(userEntity);
                if (delete == true)
                {
                    MessageBox.Show("Data Deleted Successful");
                }
                else
                {
                    MessageBox.Show("Data Deleted Successful");
                }
            }
            GetAllUser();
        }
    }
}
