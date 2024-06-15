using System;
using System.Windows.Forms;
using UPMS.WindowsFormsApp.DataAccess.DAO;
using UPMS.WindowsFormsApp.Entity;

namespace UPMS.WindowsFormsApp.UI.PagesForm.RolePage
{
    public partial class RolePageForm : Form
    {
        RoleDao roleDao = new RoleDao();
        RoleEntity roleEntity = new RoleEntity();

        public RolePageForm()
        {
            InitializeComponent();

        }

        private void RoleGetAll()
        {
            roledgv.DataSource = roleDao.GetALL();
        }
        private void RolePageForm_Load(object sender, EventArgs e)
        {
            RoleGetAll();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            roleDao.GetSearch(txtSearch.Text, roledgv);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            RoleDetailsForm roleDetailsForm = new RoleDetailsForm();
            roleDetailsForm.Text = "New Role Details";
            roleDetailsForm.btnEdit.Visible = false;
            roleDetailsForm.ShowDialog();
            RoleGetAll();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            RoleDetailsForm roleDetailsForm = new RoleDetailsForm();
            if (roledgv.SelectedRows.Count > 0)
            {
                roleDetailsForm.Text = "Edit Role Details";
                roleDetailsForm.btnSave.Visible = false;
                roleDetailsForm.txtId.Text = roledgv.SelectedRows[0].Cells[0].Value.ToString();
                roleDetailsForm.txtRoleName.Text = roledgv.SelectedRows[0].Cells[1].Value.ToString();
                roleDetailsForm.Show();
            }
            RoleGetAll();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            roleEntity.RId = Convert.ToInt32(roledgv.SelectedRows[0].Cells[0].Value.ToString());
            roleEntity.RoleName = roledgv.SelectedRows[0].Cells[1].Value.ToString();
            if (roledgv.SelectedRows.Count > 0)
            {
                bool delete = roleDao.Delete(roleEntity);
                if (delete == true)
                {
                    MessageBox.Show("Data Deleted Successful");
                }
                else
                {
                    MessageBox.Show("Data Deleted Successful");
                }
            }
            RoleGetAll();
        }
    }
}
