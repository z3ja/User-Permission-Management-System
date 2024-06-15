using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UPMS.WindowsFormsApp.DataAccess.DAO;
using UPMS.WindowsFormsApp.Entity;

namespace UPMS.WindowsFormsApp.UI.PagesForm.PermissionPage
{
    public partial class PermissionPageForm : Form
    {
        PermissionDao permissionDao = new PermissionDao();
        PermissionEntity permissionEntity = new PermissionEntity();
        RoleDao roleDao = new RoleDao();

        public PermissionPageForm()
        {
            InitializeComponent();
        }
        private void PermissionPageForm_Load(object sender, EventArgs e)
        {
            GetAllActiveUser();
            reset();
        }


        private void reset()
        {
            cbButton1.Checked = false;
            cbButton2.Checked = false;
            cbButton3.Checked = false;
            cbButton4.Checked = false;
            cbButton5.Checked = false;
        }
        private void GetAllActiveUser()
        {
            DataTable dataTable = roleDao.GetAllActiveUserData();
            if (dataTable.Rows.Count > 0)
            {
                cmbRolename.DisplayMember = "role_name";
                cmbRolename.ValueMember = "rid";
                cmbRolename.DataSource = dataTable;
                cmbRolename.SelectedIndex = -1;
            }

        }
        private void cmbRolename_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string username;
                if (cmbRolename.SelectedIndex != -1)
                {
                    username = cmbRolename.SelectedValue.ToString();
                    DataTable permission = permissionDao.SelectPermissionBasedOnUsername(username);
                    if (permission.Rows.Count >= 0)
                    {
                        if (Convert.ToBoolean(permission.Rows[0]["button1"]) == true)
                        {
                            cbButton1.Checked = true;
                        }
                        else
                        {
                            cbButton1.Checked = false;
                        }
                        if (Convert.ToBoolean(permission.Rows[0]["button2"]) == true)
                        {
                            cbButton2.Checked = true;
                        }
                        else
                        {
                            cbButton2.Checked = false;
                        }
                        if (Convert.ToBoolean(permission.Rows[0]["button3"]) == true)
                        {
                            cbButton3.Checked = true;
                        }
                        else
                        {
                            cbButton3.Checked = false;
                        }
                        if (Convert.ToBoolean(permission.Rows[0]["button4"]) == true)
                        {
                            cbButton4.Checked = true;
                        }
                        else
                        {
                            cbButton4.Checked = false;
                        }
                        if (Convert.ToBoolean(permission.Rows[0]["button5"]) == true)
                        {
                            cbButton5.Checked = true;
                        }
                        else
                        {
                            cbButton5.Checked = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);


            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            bool b1, b2, b3, b4, b5;
            permissionEntity.Role_Id = Convert.ToInt32(cmbRolename.SelectedValue.ToString());
            if (cbButton1.Checked == true)
            {
                b1 = permissionEntity.button1 = true;
            }
            else
            {
                b1 = permissionEntity.button1 = false;
            }
            if (cbButton2.Checked == true)
            {
                b2 = permissionEntity.button2 = true;
            }
            else
            {
                b2 = permissionEntity.button2 = false;
            }
            if (cbButton3.Checked == true)
            {
                b3 = permissionEntity.button3 = true;
            }
            else
            {
                b3 = permissionEntity.button3 = false;
            }
            if (cbButton4.Checked == true)
            {
                b4 = permissionEntity.button4 = true;
            }
            else
            {
                b4 = permissionEntity.button4 = false;
            }
            if (cbButton5.Checked == true)
            {
                b5 = permissionEntity.button5 = true;
            }
            else
            {
                b5 = permissionEntity.button5 = false;
            }

            bool update = permissionDao.Edit(permissionEntity);
            if (update == true)
            {
                MessageBox.Show("Data Saved Successful");
            }
            else
            {
                MessageBox.Show("Data Saved Failed");
            }

            cmbRolename.SelectedIndex = -1;
            reset();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
