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
    public partial class MANAGEMENT : Form
    {
        public static int status = 0; //Mặc định trạng thái Stock
        public MANAGEMENT()
        {
            InitializeComponent();
        }

        string chuoiketnoi = @"Data Source=DESKTOP-6D460O9;Initial Catalog=PetCareDB; Persist Security Info=True;User ID=anhthu;Password=at0410";
        string sql;
        SqlConnection ketnoi;
        SqlCommand thuchien;
        SqlDataReader docdulieu;
        int i = 0;

        private void MANAGEMENT_Load(object sender, EventArgs e)
        {
            grbxService.Hide();
            grbxSuppliers.Hide();
        }

        //-----------------------------DỊCH VỤ------------------------------------
        public void hienthiDichVu()
        {
            ketnoi = new SqlConnection(chuoiketnoi);
            listService.Items.Clear();
            ketnoi.Open();
            sql = @"Select serviceID, servicename, price FROM tblServices";
            thuchien = new SqlCommand(sql, ketnoi);
            docdulieu = thuchien.ExecuteReader();
            i = 0;
            while (docdulieu.Read())
            {
                listService.Items.Add(docdulieu[0].ToString());
                listService.Items[i].SubItems.Add(docdulieu[1].ToString());
                listService.Items[i].SubItems.Add(docdulieu[2].ToString());
                i++;
            }
            ketnoi.Close();
        }
        private void btDeleteService_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPrice.Text == "" || txtServiceID.Text == "" || txtServiceName.Text == "")
                    MessageBox.Show("Bạn cần chọn dịch vụ muốn xóa.");
                else
                {
                    listService.Items.Clear();
                    ketnoi.Open();
                    sql = @"DELETE FROM tblServices WHERE  (serviceID=N'" + txtServiceID.Text + @"') ";
                    thuchien = new SqlCommand(sql, ketnoi);
                    thuchien.ExecuteNonQuery();
                    ketnoi.Close();
                    MessageBox.Show("Đã xóa thành công.");
                    hienthiDichVu();

                    txtServiceID.Enabled = false;
                    txtServiceID.Text = txtServiceName.Text = txtPrice.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ketnoi.Close();
                hienthiDichVu();
            }
        }
        private void listService_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listService.SelectedItems.Count > 0)
            {
                txtServiceID.Enabled = true;
                txtServiceID.Text = listService.SelectedItems[0].SubItems[0].Text;
                txtServiceName.Text = listService.SelectedItems[0].SubItems[1].Text;
                txtPrice.Text = listService.SelectedItems[0].SubItems[2].Text;
            }
            else
                txtServiceID.Enabled = false;
        }

        SqlConnection sqlConnection; //Kết nối CSDL
        SqlDataReader sqlDataReader;
        public void ConnectDatabase()
        {
            sqlConnection = new SqlConnection(chuoiketnoi);
            sqlConnection.Open();
        }
        public string randomID1()
        {

            Random rdpetID = new Random();
            string ID = "";
            int[] IDarray = new int[4];
            for (int i = 0; i < 4; i++)
            {
                IDarray[i] += rdpetID.Next(0, 9);
                ID += IDarray[i].ToString();
                if (i == 3)
                {
                    ConnectDatabase();
                    string sqlID = "SELECT serviceID FROM tblServices WHERE serviceID = '" + ID + "'";
                    SqlCommand cmd = new SqlCommand(sqlID, sqlConnection);
                    sqlDataReader = cmd.ExecuteReader();
                    if (sqlDataReader.Read()) //Nếu tìm thấy ID vừa random đã bị trùng với ID đã có trong CSDL
                    {
                        return randomID1(); //Thì random lại ID mới
                    }
                }
            }
            sqlConnection.Close();
            return ID;
        }

        public string randomID2()
        {

            Random rdpetID = new Random();
            string ID = "";
            int[] IDarray = new int[4];
            for (int i = 0; i < 4; i++)
            {
                IDarray[i] += rdpetID.Next(0, 9);
                ID += IDarray[i].ToString();
                if (i == 3)
                {
                    ConnectDatabase();
                    string sqlID = "SELECT supplierID FROM tblSuppliers WHERE supplierID = '" + ID + "'";
                    SqlCommand cmd = new SqlCommand(sqlID, sqlConnection);
                    sqlDataReader = cmd.ExecuteReader();
                    if (sqlDataReader.Read()) //Nếu tìm thấy ID vừa random đã bị trùng với ID đã có trong CSDL
                    {
                        return randomID2(); //Thì random lại ID mới
                    }
                }
            }
            sqlConnection.Close();
            return ID;
        }

        private void btAddService_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtPrice.Text == "" || txtServiceName.Text == "")
                    MessageBox.Show("Bạn cần nhập đầy đủ thông tin dịch vụ.");
                else
                {
                    txtServiceID.Text = randomID1();
                    listService.Items.Clear();
                    ketnoi.Open();
                    sql = @"Insert Into tblServices(serviceID, servicename, price)
                            VALUES (N'" + txtServiceID.Text + @"',N'" + txtServiceName.Text + @"',N'" + txtPrice.Text + @"')";
                    thuchien = new SqlCommand(sql, ketnoi);
                    thuchien.ExecuteNonQuery();
                    ketnoi.Close();
                    hienthiDichVu();

                    txtServiceID.Enabled = false;
                    txtServiceID.Text = txtServiceName.Text = txtPrice.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); //Bắt lỗi nếu có nhập trùng ID dịch vụ đã tồn tại
                ketnoi.Close();
                hienthiDichVu();
            }
        }

        private void btEditService_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPrice.Text == "" || txtServiceID.Text == "" || txtServiceName.Text == "")
                    MessageBox.Show("Bạn cần nhập đầy đủ thông tin dịch vụ.");
                else
                {
                    listService.Items.Clear();
                    ketnoi.Open();
                    sql = @"UPDATE tblServices SET serviceID=N'" + txtServiceID.Text + @"', servicename=N'" + txtServiceName.Text + @"',
                                    price=N'" + txtPrice.Text + @"' WHERE (serviceID=N'" + txtServiceID.Text + @"')";
                    thuchien = new SqlCommand(sql, ketnoi);
                    thuchien.ExecuteNonQuery();
                    ketnoi.Close();
                    hienthiDichVu();

                    txtServiceID.Enabled = false;
                    txtServiceID.Text = txtServiceName.Text = txtPrice.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); //Bắt lỗi nếu có nhập trùng ID dịch vụ đã tồn tại
                ketnoi.Close();
                hienthiDichVu();
            }
        }

        //----------------------------NHÀ CUNG CẤP------------------------------------------
        public void hienthiNhaCungCap()
        {
            ketnoi = new SqlConnection(chuoiketnoi);
            listSupplier.Items.Clear();
            ketnoi.Open();
            sql = @"Select supplierID, suppliername, address, contact FROM tblSuppliers";
            thuchien = new SqlCommand(sql, ketnoi);
            docdulieu = thuchien.ExecuteReader();
            i = 0;
            while (docdulieu.Read())
            {
                listSupplier.Items.Add(docdulieu[0].ToString());
                listSupplier.Items[i].SubItems.Add(docdulieu[1].ToString());
                listSupplier.Items[i].SubItems.Add(docdulieu[2].ToString());
                listSupplier.Items[i].SubItems.Add(docdulieu[3].ToString());
                i++;
            }
            ketnoi.Close();
        }

        private void listSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listSupplier.SelectedItems.Count > 0)
                {
                    txtSuppID.Enabled = true;
                    txtSuppID.Text = listSupplier.SelectedItems[0].SubItems[0].Text;
                    txtSuppName.Text = listSupplier.SelectedItems[0].SubItems[1].Text;
                    txtAddress.Text = listSupplier.SelectedItems[0].SubItems[2].Text;
                    txtContact.Text = listSupplier.SelectedItems[0].SubItems[3].Text;
                }
                else
                    txtSuppID.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btDeleteSupp_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtContact.Text == "" || txtSuppID.Text == "" ||
                    txtSuppName.Text == "" || txtAddress.Text == "")
                    MessageBox.Show("Bạn cần chọn nhà cung cấp muốn xóa.");
                else
                {
                    listService.Items.Clear();
                    ketnoi.Open();
                    sql = @"DELETE FROM tblSuppliers WHERE (supplierID=N'" + txtSuppID.Text + @"') ";
                    thuchien = new SqlCommand(sql, ketnoi);
                    thuchien.ExecuteNonQuery();
                    ketnoi.Close();
                    MessageBox.Show("Đã xóa thành công.");
                    hienthiNhaCungCap();

                    txtSuppID.Enabled = false;
                    txtSuppID.Text = txtSuppName.Text = txtAddress.Text = txtContact.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ketnoi.Close();
                hienthiNhaCungCap();
            }
        }
        private void btAddSupp_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtContact.Text == "" || txtSuppName.Text == "" || txtAddress.Text == "")
                    MessageBox.Show("Bạn cần nhập đủ thông tin nhà cung cấp.");
                else
                {
                    txtSuppID.Text = randomID2();

                    listSupplier.Items.Clear();
                    ketnoi.Open();
                    sql = @"Insert Into tblSuppliers(supplierID, suppliername, address, contact)
                            VALUES (N'" + txtSuppID.Text + @"',N'" + txtSuppName.Text + @"',N'" + txtAddress.Text + @"',N'" + txtContact.Text + @"')";
                    thuchien = new SqlCommand(sql, ketnoi);
                    thuchien.ExecuteNonQuery();
                    ketnoi.Close();
                    hienthiNhaCungCap();

                    txtSuppID.Enabled = false;
                    txtSuppID.Text = txtSuppName.Text = txtAddress.Text = txtContact.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); //Bắt lỗi nếu có nhập trùng ID nhà cung cấp đã tồn tại
                ketnoi.Close();
                hienthiNhaCungCap();
            }
        }
        private void btEditSupp_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtContact.Text == "" || txtSuppID.Text == "" ||
                    txtSuppName.Text == "" || txtAddress.Text == "")
                    MessageBox.Show("Bạn cần nhập đủ thông tin nhà cung cấp.");
                else
                {
                    listSupplier.Items.Clear();
                    ketnoi.Open();
                    sql = @"UPDATE tblSuppliers SET supplierID=N'" + txtSuppID.Text + @"', suppliername=N'" + txtSuppName.Text + @"',
                                        address=N'" + txtAddress.Text + @"', contact=N'" + txtContact.Text +
                                             @"' WHERE (supplierID=N'" + txtSuppID.Text + @"')";
                    thuchien = new SqlCommand(sql, ketnoi);
                    thuchien.ExecuteNonQuery();
                    ketnoi.Close();
                    hienthiNhaCungCap();

                    txtSuppID.Enabled = false;
                    txtSuppID.Text = txtSuppName.Text = txtAddress.Text = txtContact.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); //Bắt lỗi nếu có nhập trùng ID dịch vụ đã tồn tại
                ketnoi.Close();
                hienthiNhaCungCap();
            }
        }

        //---------------------Hiển thị giao diện----------------------------------------
        private void btServiceManage_Click(object sender, EventArgs e)
        {
            grbxService.Show();
            hienthiDichVu();
        }
        private void btSuppliers_Click(object sender, EventArgs e)
        {
            grbxSuppliers.Show();
            hienthiNhaCungCap();
        }

        private void btServiceManage_MouseHover(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            bt.BackColor = Color.PaleVioletRed;
        }

        private void btServiceManage_MouseLeave(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            bt.BackColor = Color.LavenderBlush;
        }
        private void btExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btStock_Click(object sender, EventArgs e)
        {
            status = 0;
            this.Hide();
            STOCK form = new STOCK();
            form.ShowDialog();
            this.Show();
        }
        private void btWarehouse_Click(object sender, EventArgs e)
        {
            status = 1; //Trạng thái warehouse
            this.Hide();
            STOCK form = new STOCK();
            form.ShowDialog();
            this.Show();
        }

        private void btAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            ACCOUNT form = new ACCOUNT();
            form.ShowDialog();
            this.Show();
        }
    }
}