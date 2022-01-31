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

namespace PetCareProject
{
    public partial class ACCOUNT : Form
    {
        public ACCOUNT()
        {
            InitializeComponent();
        }

        string chuoiketnoi = @"Data Source=DESKTOP-6D460O9;Initial Catalog=PetCareDB; Persist Security Info=True;User ID=anhthu;Password=at0410";
        string sql, sql2;
        SqlConnection ketnoi, ketnoi2;
        SqlCommand thuchien, thuchien2;

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbShowAll_Click(object sender, EventArgs e)
        {
            ACCOUNTDETAILS form = new ACCOUNTDETAILS();
            form.ShowDialog();
            this.Show();
        }

        private void cbbAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbAccount.Text != "")
            {
                if (cbbAccount.Text.Trim() == LOGIN.userName.Trim())
                {
                    MessageBox.Show("Không thể thực hiện thay đổi cho tài khoản đang đăng nhập trên hệ thống.");
                    cbbAccount.SelectedItem = null;
                }
                else
                {
                    txtOwner.Enabled = txtPassword.Enabled = txtUserName.Enabled = true;
                    GetUserName_Type();
                    GetPassword();
                    GetOwner();
                }
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbbAccount.Text == "")
                    MessageBox.Show("Bạn cần chọn tài khoản muốn xóa.");
                else
                {
                    ketnoi = new SqlConnection(chuoiketnoi);
                    ketnoi.Open();
                    sql = @"DELETE FROM tblAccount WHERE username= '" + cbbAccount.Text + "'";
                    thuchien = new SqlCommand(sql, ketnoi);
                    thuchien.ExecuteNonQuery();
                    ketnoi.Close();
                    MessageBox.Show("Xóa tài khoản thành công.");
                    this.tblAccountTableAdapter.Fill(this.dataSet.tblAccount);
                   // this.tblAccountTableAdapter.Fill(this.dataSet.tblAccount);
                    txtPassword.Text = txtUserName.Text = txtOwner.Text =  "";
                    cbbAccount.SelectedItem = null;
                    rdbStaff.Checked = false;
                    rdbAdmin.Checked = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ketnoi.Close();
            }
        }

        private void btAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNewUserName.Text == "" || txtNewPassword.Text == "")                    
                    MessageBox.Show("Bạn cần nhập đầy đủ thông tin tài khoản.");
                else
                {
                    int newType = 0;
                    if (rdbNewAdmin.Checked == true)
                        newType = 1;
                    else
                        if (rdbNewStaff.Checked == true)
                        newType = 0;
                    ketnoi = new SqlConnection(chuoiketnoi);
                    ketnoi.Open();
                    sql = @"Insert Into tblAccount(username, password, fullname, type)
                            VALUES (N'" + txtNewUserName.Text + @"','" + txtNewPassword.Text + @"','N"+ txtNewOwner.Text + @"'," + newType + @")";
                    thuchien = new SqlCommand(sql, ketnoi);
                    thuchien.ExecuteNonQuery();
                    ketnoi.Close();
                    MessageBox.Show("Tạo mới tài khoản thành công!");

                    this.tblAccountTableAdapter.Fill(this.dataSet.tblAccount);                    
            
                    txtNewPassword.Text = txtNewUserName.Text = txtNewOwner.Text = "";
                    cbbAccount.SelectedItem = null;
                    rdbNewStaff.Checked = false;
                    rdbNewAdmin.Checked = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); //Bắt lỗi nếu có nhập trùng ID sản phẩm đã tồn tại
                ketnoi.Close();                
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPassword.Text == "" || (rdbAdmin.Checked == false && rdbStaff.Checked == false))
                    MessageBox.Show("Bạn cần nhập đầy đủ thông tin tài khoản.");
                else
                {
                    int newType = 0;
                    if (rdbAdmin.Checked == true)
                        newType = 1;
                    else
                        if (rdbStaff.Checked == true)
                        newType = 0;
                    ketnoi = new SqlConnection(chuoiketnoi);
                    ketnoi.Open();                    
                    sql = @"UPDATE tblAccount SET password='" + txtPassword.Text + @"', type=" + newType + @", username='" + txtUserName.Text +
                                @"', fullname=N'" + txtOwner.Text + @"' WHERE (username=N'" + cbbAccount.Text + @"')";
                    thuchien = new SqlCommand(sql, ketnoi);
                    thuchien.ExecuteNonQuery();
                    ketnoi.Close();
                    MessageBox.Show("Đã lưu những thay đổi.");
                    this.tblAccountTableAdapter.Fill(this.dataSet.tblAccount);
                   // this.tblAccountTableAdapter.Fill(this.dataSet.tblAccount);
                    txtPassword.Text = txtUserName.Text = txtOwner.Text = "";
                    cbbAccount.SelectedItem = null;
                    rdbStaff.Checked = false;
                    rdbAdmin.Checked = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); //Bắt lỗi nếu có nhập trùng ID sản phẩm đã tồn tại
                ketnoi.Close();               
            }
        }

        private void ACCOUNT_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.tblAccount' table. You can move, or remove it, as needed.
            this.tblAccountTableAdapter.Fill(this.dataSet.tblAccount);          
                       
            cbbAccount.SelectedItem = null;
            txtOwner.Enabled = txtPassword.Enabled = txtUserName.Enabled = false;

        }

        public void GetUserName_Type()
        {
            try
            {
                ketnoi = new SqlConnection(chuoiketnoi);
                ketnoi.Open();
                sql = @"Select username FROM tblAccount where username= '" + cbbAccount.Text + "'";
                thuchien = new SqlCommand(sql, ketnoi);
                txtUserName.Text = thuchien.ExecuteScalar().ToString();

                ketnoi2 = new SqlConnection(chuoiketnoi);
                ketnoi2.Open();
                sql2 = @"Select type FROM tblAccount where username= '" + cbbAccount.Text + "'";
                thuchien2 = new SqlCommand(sql2, ketnoi);
                int type = Convert.ToInt32(thuchien2.ExecuteScalar());
                if (type == 1)
                    rdbAdmin.Checked = true;
                else
                    if (type == 0)
                    rdbStaff.Checked = true;
                ketnoi.Close();
                ketnoi2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ketnoi.Close();
                ketnoi2.Close();
            }

        }
        public void GetPassword()
        {
            try
            {
                ketnoi = new SqlConnection(chuoiketnoi);
                ketnoi.Open();
                sql = @"Select password FROM tblAccount where username= '" + cbbAccount.Text + "'";
                thuchien = new SqlCommand(sql, ketnoi);
                txtPassword.Text = thuchien.ExecuteScalar().ToString();
                ketnoi.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ketnoi.Close();
            }

        }
        public void GetOwner()
        {
            try
            {
                ketnoi = new SqlConnection(chuoiketnoi);
                ketnoi.Open();
                sql = @"SELECT fullname FROM tblAccount WHERE username= '" + cbbAccount.Text + "'";
                thuchien = new SqlCommand(sql, ketnoi);
                txtOwner.Text = thuchien.ExecuteScalar().ToString();
                ketnoi.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
                        
        }    
    }
}
