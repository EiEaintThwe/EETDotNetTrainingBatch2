using EETDotNetTraningBatch2.WinFormsApp1.Database.App3DbContextModels;

namespace EETDotNetTraningBatch2.WinFormsApp1
{
    public partial class FrmStaff : Form
    {
        private readonly App3DbContext _db;
        private int _editId;
        public FrmStaff()
        {
            InitializeComponent();
            _db = new App3DbContext();
            dgvData.AutoGenerateColumns = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmStaff_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                _db.TblStaffs.Add(new TblStaff
                {
                    EmailAddress = txtEmail.Text.Trim(),
                    IsDelete = false,
                    Password = txtPassword.Text.Trim(),
                    MobileNo = txtMobileNo.Text.Trim(),
                    StaffCode = txtCode.Text.Trim(),
                    StaffName = txtName.Text.Trim(),
                    Position = cboPosition.Text.Trim()
                });

                int result = _db.SaveChanges();
                string message = result > 0 ? "Saving successful" : "Saving failed";
                MessageBox.Show(message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtCode.Clear();
                txtEmail.Clear();
                txtPassword.Clear();
                txtMobileNo.Clear();
                txtName.Clear();
                cboPosition.Text = "";

                txtCode.Focus();
                BindData();


            }
            catch (Exception ex)
            {


            }
        }

        private void FrmStaff_Load_1(object sender, EventArgs e)
        {
            BindData();

        }

        private void BindData()
        {
            try
            {
                dgvData.DataSource = _db.TblStaffs.ToList();
            }
            catch (Exception ex)
            {


            }
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1) return;

            // if(e.ColumnIndex == 0)
            if (e.ColumnIndex == dgvData.Columns["ColEdit"].Index)
            {
                int id = Convert.ToInt32(dgvData.Rows[e.RowIndex].Cells["ColId"].Value.ToString()!);
                var item = _db.TblStaffs.FirstOrDefault(x => x.StaffId == id);
                if (item is null)
                {
                    return;
                }

                txtCode.Text = item.StaffCode;
                txtEmail.Text = item.EmailAddress;
                txtMobileNo.Text = item.MobileNo;
                txtName.Text = item.StaffName;
                txtPassword.Text = item.Password;
                cboPosition.Text = item.Position;
                _editId = id;
            }
            else if (e.ColumnIndex == dgvData.Columns["ColDelete"].Index)
            {
                var confirm = MessageBox.Show("Are you sure want to delete?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.No) return;

                //delete process
                int id = Convert.ToInt32(dgvData.Rows[e.RowIndex].Cells["ColId"].Value.ToString()!);
                var item = _db.TblStaffs.FirstOrDefault(x => x.StaffId == id);
                if (item is null)
                {
                    return;
                }

                _db.TblStaffs.Remove(item);

                int result = _db.SaveChanges();
                string message = result > 0 ? "Deleting successful" : "Deleting failed";
                MessageBox.Show(message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            }

           

        }
        
    }
}
