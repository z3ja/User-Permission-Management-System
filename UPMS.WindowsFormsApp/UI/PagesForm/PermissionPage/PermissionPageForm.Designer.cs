namespace UPMS.WindowsFormsApp.UI.PagesForm.PermissionPage
{
    partial class PermissionPageForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbRolename = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbButton5 = new System.Windows.Forms.CheckBox();
            this.cbButton4 = new System.Windows.Forms.CheckBox();
            this.cbButton3 = new System.Windows.Forms.CheckBox();
            this.cbButton2 = new System.Windows.Forms.CheckBox();
            this.cbButton1 = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbRolename);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(559, 89);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "Role Name:";
            // 
            // cmbRolename
            // 
            this.cmbRolename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbRolename.BackColor = System.Drawing.Color.White;
            this.cmbRolename.FormattingEnabled = true;
            this.cmbRolename.Location = new System.Drawing.Point(177, 35);
            this.cmbRolename.Name = "cmbRolename";
            this.cmbRolename.Size = new System.Drawing.Size(204, 29);
            this.cmbRolename.TabIndex = 10;
            this.cmbRolename.SelectedIndexChanged += new System.EventHandler(this.cmbRolename_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 303);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(559, 63);
            this.panel2.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(277, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 39);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(182, 12);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(89, 39);
            this.btnEdit.TabIndex = 15;
            this.btnEdit.Text = "Save";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 89);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(41, 214);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(518, 89);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(41, 214);
            this.panel4.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbButton5);
            this.groupBox1.Controls.Add(this.cbButton4);
            this.groupBox1.Controls.Add(this.cbButton3);
            this.groupBox1.Controls.Add(this.cbButton2);
            this.groupBox1.Controls.Add(this.cbButton1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(41, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(477, 214);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Permission";
            // 
            // cbButton5
            // 
            this.cbButton5.AutoSize = true;
            this.cbButton5.Location = new System.Drawing.Point(376, 39);
            this.cbButton5.Name = "cbButton5";
            this.cbButton5.Size = new System.Drawing.Size(84, 25);
            this.cbButton5.TabIndex = 4;
            this.cbButton5.Text = "Button5";
            this.cbButton5.UseVisualStyleBackColor = true;
            // 
            // cbButton4
            // 
            this.cbButton4.AutoSize = true;
            this.cbButton4.Location = new System.Drawing.Point(286, 39);
            this.cbButton4.Name = "cbButton4";
            this.cbButton4.Size = new System.Drawing.Size(84, 25);
            this.cbButton4.TabIndex = 3;
            this.cbButton4.Text = "Button4";
            this.cbButton4.UseVisualStyleBackColor = true;
            // 
            // cbButton3
            // 
            this.cbButton3.AutoSize = true;
            this.cbButton3.Location = new System.Drawing.Point(196, 39);
            this.cbButton3.Name = "cbButton3";
            this.cbButton3.Size = new System.Drawing.Size(84, 25);
            this.cbButton3.TabIndex = 2;
            this.cbButton3.Text = "Button3";
            this.cbButton3.UseVisualStyleBackColor = true;
            // 
            // cbButton2
            // 
            this.cbButton2.AutoSize = true;
            this.cbButton2.Location = new System.Drawing.Point(106, 39);
            this.cbButton2.Name = "cbButton2";
            this.cbButton2.Size = new System.Drawing.Size(84, 25);
            this.cbButton2.TabIndex = 1;
            this.cbButton2.Text = "Button2";
            this.cbButton2.UseVisualStyleBackColor = true;
            // 
            // cbButton1
            // 
            this.cbButton1.AutoSize = true;
            this.cbButton1.Location = new System.Drawing.Point(16, 39);
            this.cbButton1.Name = "cbButton1";
            this.cbButton1.Size = new System.Drawing.Size(84, 25);
            this.cbButton1.TabIndex = 0;
            this.cbButton1.Text = "Button1";
            this.cbButton1.UseVisualStyleBackColor = true;
            // 
            // PermissionPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(559, 366);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PermissionPageForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Permission Account";
            this.Load += new System.EventHandler(this.PermissionPageForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cmbRolename;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbButton5;
        private System.Windows.Forms.CheckBox cbButton4;
        private System.Windows.Forms.CheckBox cbButton3;
        private System.Windows.Forms.CheckBox cbButton2;
        private System.Windows.Forms.CheckBox cbButton1;
    }
}