namespace EETDotNetTraningBatch2.WinFormsApp1
{
    partial class FrmStaff
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtCode = new TextBox();
            txtName = new TextBox();
            label2 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            txtPassword = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtMobileNo = new TextBox();
            label6 = new Label();
            cboPosition = new ComboBox();
            btnSave = new Button();
            dgvData = new DataGridView();
            ColEdit = new DataGridViewButtonColumn();
            ColUpdate = new DataGridViewButtonColumn();
            ColDelete = new DataGridViewButtonColumn();
            ColId = new DataGridViewTextBoxColumn();
            ColStaffCode = new DataGridViewTextBoxColumn();
            ColStaffName = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 9);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 0;
            label1.Text = "Staff Code:";
            label1.Click += label1_Click;
            // 
            // txtCode
            // 
            txtCode.Location = new Point(24, 32);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(284, 27);
            txtCode.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(24, 85);
            txtName.Name = "txtName";
            txtName.Size = new Size(284, 27);
            txtName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 62);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 2;
            label2.Text = "Staff Name:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(24, 138);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(284, 27);
            txtEmail.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 115);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 4;
            label3.Text = "Email:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(24, 191);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(284, 27);
            txtPassword.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 168);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 6;
            label4.Text = "Password:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 221);
            label5.Name = "label5";
            label5.Size = new Size(64, 20);
            label5.TabIndex = 8;
            label5.Text = "Position:";
            // 
            // txtMobileNo
            // 
            txtMobileNo.Location = new Point(24, 297);
            txtMobileNo.Name = "txtMobileNo";
            txtMobileNo.Size = new Size(284, 27);
            txtMobileNo.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 274);
            label6.Name = "label6";
            label6.Size = new Size(83, 20);
            label6.TabIndex = 10;
            label6.Text = "Mobile No:";
            // 
            // cboPosition
            // 
            cboPosition.FormattingEnabled = true;
            cboPosition.Items.AddRange(new object[] { "--Select One--", "Admin", "Staff" });
            cboPosition.Location = new Point(24, 244);
            cboPosition.Name = "cboPosition";
            cboPosition.Size = new Size(284, 28);
            cboPosition.TabIndex = 12;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(217, 330);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(91, 28);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.Click += btnSave_Click;
            // 
            // dgvData
            // 
            dgvData.AllowUserToAddRows = false;
            dgvData.AllowUserToDeleteRows = false;
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Columns.AddRange(new DataGridViewColumn[] { ColEdit, ColUpdate, ColDelete, ColId, ColStaffCode, ColStaffName });
            dgvData.Location = new Point(377, 30);
            dgvData.Name = "dgvData";
            dgvData.ReadOnly = true;
            dgvData.RowHeadersWidth = 51;
            dgvData.Size = new Size(553, 328);
            dgvData.TabIndex = 13;
            dgvData.CellContentClick += dgvData_CellContentClick;
            // 
            // ColEdit
            // 
            ColEdit.HeaderText = "Edit";
            ColEdit.MinimumWidth = 6;
            ColEdit.Name = "ColEdit";
            ColEdit.ReadOnly = true;
            ColEdit.Text = "Edit";
            ColEdit.UseColumnTextForButtonValue = true;
            ColEdit.Width = 125;
            // 
            // ColUpdate
            // 
            ColUpdate.HeaderText = "Update";
            ColUpdate.MinimumWidth = 6;
            ColUpdate.Name = "ColUpdate";
            ColUpdate.ReadOnly = true;
            ColUpdate.Text = "Update";
            ColUpdate.UseColumnTextForButtonValue = true;
            ColUpdate.Width = 125;
            // 
            // ColDelete
            // 
            ColDelete.HeaderText = "Delete";
            ColDelete.MinimumWidth = 6;
            ColDelete.Name = "ColDelete";
            ColDelete.ReadOnly = true;
            ColDelete.Text = "Delete";
            ColDelete.UseColumnTextForButtonValue = true;
            ColDelete.Width = 125;
            // 
            // ColId
            // 
            ColId.DataPropertyName = "StaffId";
            ColId.HeaderText = "Id";
            ColId.MinimumWidth = 6;
            ColId.Name = "ColId";
            ColId.ReadOnly = true;
            ColId.Width = 125;
            // 
            // ColStaffCode
            // 
            ColStaffCode.DataPropertyName = "StaffCode";
            ColStaffCode.HeaderText = "Staff Code";
            ColStaffCode.MinimumWidth = 6;
            ColStaffCode.Name = "ColStaffCode";
            ColStaffCode.ReadOnly = true;
            ColStaffCode.Width = 125;
            // 
            // ColStaffName
            // 
            ColStaffName.DataPropertyName = "StaffName";
            ColStaffName.HeaderText = "Staff Name";
            ColStaffName.MinimumWidth = 6;
            ColStaffName.Name = "ColStaffName";
            ColStaffName.ReadOnly = true;
            ColStaffName.Width = 125;
            // 
            // FrmStaff
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(951, 396);
            Controls.Add(dgvData);
            Controls.Add(btnSave);
            Controls.Add(cboPosition);
            Controls.Add(txtMobileNo);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtPassword);
            Controls.Add(label4);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(txtCode);
            Controls.Add(label1);
            Name = "FrmStaff";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Staff";
            Load += FrmStaff_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCode;
        private TextBox txtName;
        private Label label2;
        private TextBox txtEmail;
        private Label label3;
        private TextBox txtPassword;
        private Label label4;
        private Label label5;
        private TextBox txtMobileNo;
        private Label label6;
        private ComboBox cboPosition;
        private Button btnSave;
        private DataGridView dgvData;
        private DataGridViewButtonColumn ColEdit;
        private DataGridViewButtonColumn ColUpdate;
        private DataGridViewButtonColumn ColDelete;
        private DataGridViewTextBoxColumn ColId;
        private DataGridViewTextBoxColumn ColStaffCode;
        private DataGridViewTextBoxColumn ColStaffName;
    }
}
