using EETDotNetTraningBatch2.WinFormsApp1.Database.App3DbContextModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EETDotNetTraningBatch2.WinFormsApp1
{
    public partial class FrmLogin : Form
    {
        private readonly App3DbContext _db;
        public FrmLogin()
        {
            InitializeComponent();
            _db = new App3DbContext();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string staffCode = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            var item = _db.TblStaffs.FirstOrDefault(x => x.StaffCode == staffCode && x.Password == password);
            if (item is null)
            {
                MessageBox.Show("Username or password was wrong.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.Hide();

            FrmMenu frm = new FrmMenu();
            frm.ShowDialog();

            this.Show();

        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword.Focus();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                btnLogin_Click(sender, e);
            }
        }
    }
}
