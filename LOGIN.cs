using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetCareProject
{
    public partial class LOGIN : Form
    {
        public static int account = 0; //Là nhân viên bình thường
        public LOGIN()
        {
            InitializeComponent();
        }

        string connStr = @"Data Source=DESKTOP-6D460O9;Initial Catalog=PetCareDB; Persist Security Info=True;User ID=anhthu;Password=at0410";
        SqlConnection sqlConnection, sqlConnection2; //Kết nối CSDL             
        SqlDataReader sqlDataReader; //Đọc CSDL 

        public void ConnectDatabase()
        {
            sqlConnection = new SqlConnection(connStr);
            sqlConnection.Open();
        }
             

        private void LOGIN_Load(object sender, EventArgs e)
        {

        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public static string userName;
        string passWord;
        private void btGo_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "" || txtUserName.Text == "")
                MessageBox.Show("Bạn chưa nhập tài khoản hoặc mật khẩu!");
            sqlConnection = new SqlConnection(connStr);
            try
            {
                sqlConnection2 = new SqlConnection(connStr);
                sqlConnection.Open();

                userName = txtUserName.Text;
                passWord = txtPassword.Text;
                string sqllogin = "SELECT * FROM tblAccount WHERE username = '" + userName + "' AND password = '" + passWord + "'";
                SqlCommand cmd = new SqlCommand(sqllogin, sqlConnection);
                sqlDataReader = cmd.ExecuteReader();
                if (sqlDataReader.Read()) //Nếu chạy thành công 
                {
                    string sqlgettype = "SELECT type FROM tblAccount WHERE username = '" + userName + "'"; //Lấy ra loại Account
                    sqlConnection2.Open();
                    SqlCommand cmd2 = new SqlCommand(sqlgettype, sqlConnection2);
                    int type = Convert.ToInt32(cmd2.ExecuteScalar());                   
                    if (type == 1) //Admin 1
                        account = 1;
                    else
                        if (type == 0) //Staff 0
                        account = 0;
                    sqlConnection2.Close();
                   
                    MessageBox.Show("Đăng nhập thành công!");
                    this.Hide();
                    HOME form = new HOME();
                    form.Show();
                }
                else
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu.");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            sqlConnection.Close();           
        }
    }
}
