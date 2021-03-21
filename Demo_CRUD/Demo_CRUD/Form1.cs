using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Demo_CRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GetStudentsRecord();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-A278NMV;Initial Catalog=Demo_CRUD;User ID=san;Password=123456");

        private void Form1_Load(object sender, EventArgs e)
        {
            GetStudentsRecord();
        }
        private void GetStudentsRecord()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-A278NMV;Initial Catalog=Demo_CRUD;User ID=san;Password=123456");
            SqlCommand cmd = new SqlCommand("SELECT * FROM StudentTb", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            StudentData.DataSource = dt;
        }

        private bool IsvalidData()
        {
            if (txtDiaChi.Text==string.Empty
                || txtTen.Text==string.Empty
                || txtSBD.Text==string.Empty
                || string.IsNullOrEmpty(txtSDT.Text)
                ||string.IsNullOrEmpty(txtHo.Text))
            {
                MessageBox.Show("Dữ liệu phải nhập đầy đủ!!!", "Lỗi Dữ Liệu", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            return true;
                
            
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (IsvalidData())
            {

                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-A278NMV;Initial Catalog=Demo_CRUD;User ID=san;Password=123456");
                SqlCommand cmd = new SqlCommand("INSERT INTO StudentTb VALUES " + 
                    "(@Name,@FirstName,@RollNumber,@Adress,@Mobile)",con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Name", txtTen.Text);
                cmd.Parameters.AddWithValue("@FirstName", txtHo.Text);
                cmd.Parameters.AddWithValue("@RollNumber", txtSBD.Text);
                cmd.Parameters.AddWithValue("@Adress", txtDiaChi.Text);
                cmd.Parameters.AddWithValue("@Mobile",txtSDT.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                GetStudentsRecord();
            }
        }

        public int StudentID;

        private void btCapNhat_Click(object sender, EventArgs e)


        {
            if (StudentID > 0)
            {
                SqlCommand cmd = new SqlCommand("UPDATE StudentTb SET " +
                    "Name=@Name ,FirstName=@FirstName,RollNumber=@RollNumber,Address=@Adress," +
                    "Mobile=@Mobile WHERE StudentID=@ID", con);

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Name", txtTen.Text);
                cmd.Parameters.AddWithValue("@FirstName", txtHo.Text);
                cmd.Parameters.AddWithValue("@RollNumber", txtSBD.Text);
                cmd.Parameters.AddWithValue("@Adress", txtDiaChi.Text);
                cmd.Parameters.AddWithValue("@Mobile", txtSDT.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                GetStudentsRecord();
                ResetData();

                
            }
            else
            {
                MessageBox.Show("Cập Nhật bị lỗi!!!",
                                "Lỗi !",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
        }

        private void ResetData()
        {
            throw new NotImplementedException();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if(StudentID > 0)
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM StudentTb WHERE StudentID=@ID", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@ID", this.StudentID);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                GetStudentsRecord();
                ResetData();

            }
            else
            {
                MessageBox.Show("Cập Nhật Bị lỗi", "Lỗi !",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }






        private void StudentRecordData(object sender, DataGridViewCellEventArgs e)
        {
            StudentID = Convert.ToInt32(StudentData.Rows[0].Cells[0].Value);
            txtTen.Text = StudentData.SelectedRows[0].Cells[0].Value.ToString();
            txtHo.Text = StudentData.SelectedRows[0].Cells[1].Value.ToString();
            txtSBD.Text = StudentData.SelectedRows[0].Cells[2].Value.ToString();
            txtDiaChi.Text = StudentData.SelectedRows[0].Cells[3].Value.ToString();
            txtSDT.Text = StudentData.SelectedRows[0].Cells[4].Value.ToString();
        }



    }
}
