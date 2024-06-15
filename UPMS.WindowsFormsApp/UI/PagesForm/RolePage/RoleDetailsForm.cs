using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UPMS.WindowsFormsApp.DataAccess.DAO;
using UPMS.WindowsFormsApp.Entity;

namespace UPMS.WindowsFormsApp.UI.PagesForm.RolePage
{
    public partial class RoleDetailsForm : Form
    {
        RoleDao roleDao = new RoleDao();
        RoleEntity roleEntity = new RoleEntity();

        public RoleDetailsForm()
        {
            InitializeComponent();
            RoleGetAll();
        }
        private void RoleDetailsForm_Load(object sender, EventArgs e)
        {
        }
        private void Reset()
        {
            txtId.Clear();
            txtRoleName.Clear();

        }

        private void RoleGetAll()
        {
            RolePageForm rolePageForm = new RolePageForm();
            rolePageForm.roledgv.DataSource = roleDao.GetALL();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            roleEntity.RoleName = txtRoleName.Text;
            bool insert = roleDao.Save(roleEntity);
            if (insert == true)
            {

                MessageBox.Show("Data Saved Successful");

            }
            else
            {
                MessageBox.Show("Data Saved Failed");
            }
            Reset();
            RoleGetAll();

        }
    
        private void btnEdit_Click(object sender, EventArgs e)
        {
            roleEntity.RId = int.Parse(txtId.Text);
            roleEntity.RoleName = txtRoleName.Text;
            bool update = roleDao.Edit(roleEntity);
            if (update == true)
            {

                MessageBox.Show("Data Edited Successful");

            }
            else
            {
                MessageBox.Show("Data Edited Failed");
            }
            Reset();
            RoleGetAll();

        }
    }
}

