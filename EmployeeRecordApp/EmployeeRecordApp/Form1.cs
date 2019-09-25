using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeRecordApp
{
    public partial class Form1 : Form
    {
        SqlConnection cnn;
        public Form1()
        {
            InitializeComponent();
            cnn = new SqlConnection("server=.;database=EmployeeRecord;integrated security=true");

        }



        private void Form1_Load(object sender, EventArgs e)
        {
            DataGridViewLoad();
        }
        public void DataGridViewLoad()
        {
            if (cnn.State != ConnectionState.Open)
            {
                cnn.Open();

            }
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("select*from EmployeeInfo", cnn);
                DataTable table = new DataTable();
                sda.Fill(table);

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = table;
                dataGridView1.Columns["DateofBirth"].Visible = false;
                dataGridView1.Columns["Sex"].Visible = false;
                dataGridView1.Columns["Surname"].Visible = false;
                dataGridView1.Columns["Picture"].Visible = false;
                dataGridView1.Columns["Title"].Visible = false;
                dataGridView1.Columns["ID"].Visible = false;


            }


            catch (Exception ex)
            {
                MessageBox.Show("hata");
            }
            finally
            {
                cnn.Close();
            }


        }

        private void BtnAddPicture_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                DialogResult dr = ofd.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    pictureBoxEmp.ImageLocation = ofd.FileName;

                }
            }
            catch (Exception ex)
            {
            }
        }

        private void BtnClearPicture_Click(object sender, EventArgs e)
        {
            pictureBoxEmp.Image = null;
            pictureBoxEmp.Image = EmployeeRecordApp.Properties.Resources.PictureAddIcon;
        }
        public void DrivingLicenceOption(SqlCommand cmd)
        {
            if (cbA1.Checked == true)
            {
                cmd.Parameters.AddWithValue("@DrivingLicence", cbA1.Text);
            }
            else if (cbA2.Checked == true)
            {
                cmd.Parameters.AddWithValue("@DrivingLicence", cbA2.Text);

            }
            else if (cbB.Checked == true)
            {
                cmd.Parameters.AddWithValue("@DrivingLicence", cbB.Text);

            }
            else if (cbC.Checked == true)
            {
                cmd.Parameters.AddWithValue("@DrivingLicence", cbC.Text);

            }
            else if (cbD1.Checked == true)
            {
                cmd.Parameters.AddWithValue("@DrivingLicence", cbD1.Text);

            }
            else if (cbE.Checked == true)
            {
                cmd.Parameters.AddWithValue("@DrivingLicence", cbE.Text);

            }
            else
            {
                cmd.Parameters.AddWithValue("@DrivingLicence", DBNull.Value);

            }

        }
        public void GenderOption(SqlCommand cmd)
        {
            if (rbFemale.Checked == true)
            {
                cmd.Parameters.AddWithValue("@Sex", rbFemale.Text);
            }
            else if (rbMale.Checked == true)
            {
                cmd.Parameters.AddWithValue("@Sex", rbMale.Text);

            }
            else
            {
                cmd.Parameters.AddWithValue("@Sex", DBNull.Value);

            }
        }
        public void MaritalStatusOption(SqlCommand cmd)
        {
            if (rbMarried.Checked == true)
            {
                rbSingle.Checked = false;
                cmd.Parameters.AddWithValue("@MartialStatus", rbMarried.Text);
            }
            else if (rbSingle.Checked == true)
            {
                rbMarried.Checked = false;
                cmd.Parameters.AddWithValue("@MaritalStatus", rbSingle.Text);

            }
            else
            {
                rbMarried.Checked = false;
                rbSingle.Checked = false;

            }

        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {

            try
            {

                SqlCommand cmd = new SqlCommand("insert into EmployeeInfo(IdNumber,Name,Surname,DateofEmployement,Telephone,EMail,MaritalStatus,DrivingLicence) values (@IdNumber,@Name,@Surname,@DateofEmployement,@Telephone,@EMail,@MaritalStatus,@DrivingLicence)", cnn);
                cmd.Parameters.AddWithValue("@IdNumber", txtIdNumber.Text);
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@Surname", txtSurname.Text);
                cmd.Parameters.AddWithValue("@DateofEmployement", dtpEmployementDate.Value);
                cmd.Parameters.AddWithValue("@Telephone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@EMail", txtEmail.Text);
                MaritalStatusOption(cmd);
                DrivingLicenceOption(cmd);
                cnn.Open();
                cmd.ExecuteNonQuery();
                DataGridViewLoad();

            }
            catch (SqlException ex)
            {

                MessageBox.Show("hata", ex.Message);

            }
            finally
            {
                cnn.Close();
            }

        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                if (cnn.State != ConnectionState.Open)
                {
                    cnn.Open();
                }
                try
                {
                    SqlCommand cmd = new SqlCommand(" delete from EmployeeInfo where IdNumber=@IdNumber", cnn);
                    cmd.Parameters.AddWithValue("@IdNumber", dataGridView1.CurrentRow.Cells["IdNumber"].Value.ToString());
                    cmd.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("hata");

                }
                finally
                {
                    DataGridViewLoad();
                    cnn.Close();
                }

            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update EmployeeInfo set IdNumber=@IdNumber,Name=@Name,Telephone=@Telephone,Email=@Email,Address=@Address,DrivingLicence=@DrivingLicence,DateofEmployement=@DateofEmployement,MaritalStatus=@MaritalStatus where Id=@Id", cnn);
            cmd.Parameters.AddWithValue("@Id", Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value));
            cmd.Parameters.AddWithValue("@IdNumber", txtIdNumber.Text);
            cmd.Parameters.AddWithValue("@Name", txtName.Text);
            cmd.Parameters.AddWithValue("@Telephone", txtPhone.Text);
            cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
            cmd.Parameters.AddWithValue("@DateofEmployement", dtpEmployementDate.Value);
            DrivingLicenceOption(cmd);
            MaritalStatusOption(cmd);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
            DataGridViewLoad();

        }


        private void SelectionChangedAll(object sender, DataGridViewCellEventArgs e)
        {
            txtIdNumber.Text = dataGridView1.CurrentRow.Cells["IdNumber"].Value.ToString();
            txtName.Text = dataGridView1.CurrentRow.Cells["Name"].Value.ToString();
            txtSurname.Text = dataGridView1.CurrentRow.Cells["Surname"].Value.ToString();
            if (dataGridView1.CurrentRow.Cells["DateofEmployement"].Value == null | dataGridView1.CurrentRow.Cells["DateofEmployement"].Value.ToString() == "")
            {
                dtpEmployementDate.Value = DateTime.Now.Date;
            }
            else
            {
                dtpEmployementDate.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["DateofEmployement"].Value);
            }
            txtPhone.Text = dataGridView1.CurrentRow.Cells["Telephone"].Value.ToString();
            txtEmail.Text = dataGridView1.CurrentRow.Cells["Email"].Value.ToString();
            txtAddress.Text = dataGridView1.CurrentRow.Cells["Address"].Value.ToString();
            if (dataGridView1.CurrentRow.Cells["DrivingLicence"].Value.ToString().ToUpper() == cbA1.Text)
            {
                cbA1.Checked = true;
            }
            else if (dataGridView1.CurrentRow.Cells["DrivingLicence"].Value.ToString().ToUpper() == cbA2.Text)
            {
                cbA2.Checked = true;

            }
            else if (dataGridView1.CurrentRow.Cells["DrivingLicence"].Value.ToString().ToUpper() == cbB.Text)
            {
                cbB.Checked = true;

            }
            else if (dataGridView1.CurrentRow.Cells["DrivingLicence"].Value.ToString().ToUpper() == cbC.Text)
            {
                cbC.Checked = true;

            }
            else if (dataGridView1.CurrentRow.Cells["DrivingLicence"].Value.ToString().ToUpper() == cbD1.Text)
            {
                cbD1.Checked = true;

            }
            else if (dataGridView1.CurrentRow.Cells["DrivingLicence"].Value.ToString().ToUpper() == cbE.Text)
            {
                cbE.Checked = true;

            }
            else
            {
                cbA1.Checked = false;
                cbA2.Checked = false;
                cbB.Checked = false;
                cbC.Checked = false;
                cbD1.Checked = false;
                cbE.Checked = false;

            }

            if (dataGridView1.CurrentRow.Cells["MaritalStatus"].Value.ToString().ToUpper() == rbMarried.Text.ToUpper())
            {
                rbMarried.Checked = true;
                rbSingle.Checked = false;
            }
            else if (dataGridView1.CurrentRow.Cells["MaritalStatus"].Value.ToString().ToUpper() == rbSingle.Text.ToUpper())
            {
                rbMarried.Checked = false;
                rbSingle.Checked = true;
            }
            else
            {
                rbMarried.Checked = false;
                rbSingle.Checked = false;
            }



        }

        private void DataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.Rows[0].Selected = false;
        }
    }
}
