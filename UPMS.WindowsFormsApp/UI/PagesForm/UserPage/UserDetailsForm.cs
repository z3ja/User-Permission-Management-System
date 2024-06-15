using System;
using UPMS.WindowsFormsApp.UI.PagesForm.RolePage;
using System.Windows.Forms;
using UPMS.WindowsFormsApp.DataAccess.DAO;
using System.Data;
using UPMS.WindowsFormsApp.Entity;

namespace UPMS.WindowsFormsApp.UI.PagesForm.UserPage
{
    public partial class UserDetailsForm : Form
    {
        UserDao userDao = new UserDao();
        UserEntity userEntity = new UserEntity();
        RoleDao roleDao = new RoleDao();
        RolePageForm rolePageForm = new RolePageForm();
        UserPageForm userPageForm = new UserPageForm();
        PermissionDao permissionDao = new PermissionDao();
        PermissionEntity permissionEntity = new PermissionEntity();

        public UserDetailsForm()
        {
            InitializeComponent();
            GetRoleList();
            GetAllUser();
        }
        private void UserDetailsForm_Load(object sender, EventArgs e)
        {

        }

        private void Reset()
        {

            txtId.Clear();
            cmbRolename.SelectedIndex = -1;
            txtUsername.Clear();
            txtPassword.Clear();
        }
        private void GetAllUser()
        {

            userPageForm.userdgv.DataSource = userDao.GetALL();
        }


        private void GetRoleList()
        {
            DataTable rDT = new DataTable();
            rDT = roleDao.GetALL();
            if (rDT.Rows.Count > 0)
            {
                cmbRolename.DisplayMember = "role_name";
                cmbRolename.ValueMember = "rid";
                cmbRolename.DataSource = rDT;
                cmbRolename.SelectedIndex = -1;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNewRole_Click(object sender, EventArgs e)
        {
            RoleDetailsForm roleDetailsForm = new RoleDetailsForm();
            roleDetailsForm.Text = "New Role Details";
            roleDetailsForm.btnEdit.Visible = false;
            roleDetailsForm.ShowDialog();
            Reset();
            GetRoleList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            userEntity.RId = Convert.ToInt32(cmbRolename.SelectedValue);
            permissionEntity.Role_Id = Convert.ToInt32(cmbRolename.SelectedValue);
            userEntity.UserName = txtUsername.Text;
            userEntity.Password = txtPassword.Text;
            userEntity.IsAdmin =Convert.ToBoolean(cbActive.Checked);
            bool insert = userDao.Save(userEntity);
            if (insert)
            {
                MessageBox.Show("Data Saved Successful");
                permissionDao.Save(permissionEntity);

            }
            else
            {
                MessageBox.Show("Data Saved Successful");
            }
            Reset();
            GetAllUser();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            userEntity.UId = int.Parse(txtId.Text);
            userEntity.RId = Convert.ToInt32(cmbRolename.SelectedValue);
            userEntity.UserName = txtUsername.Text;
            userEntity.Password = txtPassword.Text;
            userEntity.IsAdmin = cbActive.Checked;
            bool update = userDao.Edit(userEntity);
            if (update)
            {
                MessageBox.Show("Data Edited Successful");

            }
            else
            {
                MessageBox.Show("Data Edited Successful");
            }
            Reset();
            GetAllUser();
        }
    }
}
