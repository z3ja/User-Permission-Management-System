using System;
using System.Data;
using System.Windows.Forms;
using UPMS.WindowsFormsApp.DataAccess.DAO;
using UPMS.WindowsFormsApp.Entity;




namespace UPMS.WindowsFormsApp.UI
{
    public partial class LoginForm : Form
    {

        UserDao ud = new UserDao();
        UserEntity userEntity = new UserEntity();
        titleDao titleDao = new titleDao();
        public LoginForm()
        {
            InitializeComponent();
            Getlist();
        }
        private void Getlist()
        {
            DataTable dt = ud.GetALL();
            if (dt.Rows.Count > 0)
            {
                cmbUsername.Items.Clear();
                cmbUsername.DisplayMember = "username";
                cmbUsername.ValueMember = "username";
                cmbUsername.DataSource = dt;
                cmbUsername.SelectedIndex = -1;
            }
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            DataTable td = titleDao.GetALL();
            IblTitleName.Text = td.Rows[0][0].ToString();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            userEntity.UserName = cmbUsername.Text;
            userEntity.Password = txtPassword.Text;
            try
            {
                if (cmbUsername.Text != "")
                {
                    if (txtPassword.Text != "")
                    {
                        DataTable validlogin = ud.GetAccessUser(userEntity);
                        if (validlogin.Rows.Count > 0)
                        {
                            MainForm mainForm = new MainForm(validlogin);
                            mainForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("incorrect username or password!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter password!", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                    }

                }
                else
                {
                    MessageBox.Show("Please select the username!", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            { 
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar= true;
            }

        }
    }
}
