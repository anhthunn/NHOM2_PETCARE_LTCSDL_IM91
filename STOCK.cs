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
    public partial class STOCK : Form
    {
        public STOCK()
        {
            InitializeComponent();
        }
        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        string chuoiketnoi = @"Data Source=DESKTOP-6D460O9;Initial Catalog=PetCareDB; Persist Security Info=True;User ID=anhthu;Password=at0410";
        string sql, sqlQuantity;
        SqlConnection ketnoi, ketnoi2;
        SqlCommand thuchien, thuchien2;
        SqlDataReader docdulieu;
        int i = 0;

        private void STOCK_Load(object sender, EventArgs e)
        {
            this.tblSuppliersTableAdapter.Fill(this.dataSet.tblSuppliers);
            cbbSppID.SelectedItem = null;
            if (MANAGEMENT.status == 1) //Nếu ở trạng thái Warehouse
            {
                txtprice.Enabled = txtproductname.Enabled = cbbSppID.Enabled = false;
                btAdd.Enabled = btEdit.Enabled = btDelete.Enabled = false;
                txtquantity.Enabled = true;
                btStatus.Text = "[WAREHOUSE]";
            }
            else
            {
                btUpdateQuantity.Enabled = false;
                txtquantity.Enabled = false;
                btStatus.Text = "[STOCK]";
            }

            ketnoi = new SqlConnection(chuoiketnoi);
            hienthi();
        }
        public void hienthi()
        {
            try
            {
                listStock.Items.Clear();
                ketnoi.Open();
                sql = @"Select productID, productname, quantity, price, supplierID FROM tblProducts ORDER BY productID";
                thuchien = new SqlCommand(sql, ketnoi);
                docdulieu = thuchien.ExecuteReader();
                i = 0;
                while (docdulieu.Read())
                {
                    listStock.Items.Add(docdulieu[0].ToString());
                    listStock.Items[i].SubItems.Add(docdulieu[1].ToString());
                    listStock.Items[i].SubItems.Add(docdulieu[2].ToString());
                    listStock.Items[i].SubItems.Add(docdulieu[3].ToString());
                    listStock.Items[i].SubItems.Add(docdulieu[4].ToString());
                    i++;
                }
                ketnoi.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ketnoi.Close();
            }
        }

        SqlConnection sqlConnection; //Kết nối CSDL
        SqlDataReader sqlDataReader;
        public void ConnectDatabase()
        {
            sqlConnection = new SqlConnection(chuoiketnoi);
            sqlConnection.Open();
        }
        public string randomID()
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
                        return randomID(); //Thì random lại ID mới
                    }
                }
            }
            sqlConnection.Close();
            return ID;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtprice.Text == "" || txtproductname.Text == "" || cbbSppID.Text == "")
                    MessageBox.Show("Bạn cần nhập đầy đủ thông tin sản phẩm.");
                else
                {
                    txtproductid.Text = randomID();
                    listStock.Items.Clear();
                    ketnoi.Open();
                    sql = @"Insert Into tblProducts(productname, productID, quantity, price, supplierID)
                            VALUES (N'" + txtproductname.Text + @"',N'" + txtproductid.Text + @"',N'" + txtquantity.Text + @"',N'" + txtprice.Text + @"',N'" + cbbSppID.Text + @"')";
                    thuchien = new SqlCommand(sql, ketnoi);
                    thuchien.ExecuteNonQuery();
                    ketnoi.Close();
                    hienthi();

                    txtproductid.Enabled = false;
                    txtproductname.Text = txtquantity.Text = cbbSppID.Text = txtprice.Text = txtproductid.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); //Bắt lỗi nếu có nhập trùng ID sản phẩm đã tồn tại
                ketnoi.Close();
                hienthi();
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtprice.Text == "" || txtproductid.Text == "" || txtproductname.Text == "" || cbbSppID.Text == "")
                    MessageBox.Show("Bạn cần chọn sản phẩm cần chỉnh sửa.");
                else
                {
                    listStock.Items.Clear();
                    ketnoi.Open();
                    sql = @"UPDATE tblProducts SET productID=N'" + txtproductid.Text + @"', productname=N'" + txtproductname.Text + @"',
                                    quantity=N'" + txtquantity.Text + @"', price=N'" + txtprice.Text + @"',supplierID=N'" + cbbSppID.Text
                                                        + @"' WHERE (productID=N'" + txtproductid.Text + @"')";
                    thuchien = new SqlCommand(sql, ketnoi);
                    thuchien.ExecuteNonQuery();
                    ketnoi.Close();
                    hienthi();

                    txtproductid.Enabled = false;
                    txtproductname.Text = txtquantity.Text = cbbSppID.Text = txtprice.Text = txtproductid.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); //Bắt lỗi nếu có nhập trùng ID sản phẩm đã tồn tại
                ketnoi.Close();
                hienthi();
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtprice.Text == "" || txtproductid.Text == "" || txtproductname.Text == "" || txtquantity.Text == "" || cbbSppID.Text == "")
                    MessageBox.Show("Bạn cần chọn sản phẩm muốn xóa.");
                else
                {
                    listStock.Items.Clear();
                    ketnoi.Open();
                    sql = @"DELETE FROM tblProducts WHERE  (productID=N'" + txtproductid.Text + @"') ";
                    thuchien = new SqlCommand(sql, ketnoi);
                    thuchien.ExecuteNonQuery();
                    ketnoi.Close();
                    MessageBox.Show("Đã xóa thành công.");
                    hienthi();

                    txtproductid.Enabled = false;
                    txtproductname.Text = txtquantity.Text = cbbSppID.Text = txtprice.Text = txtproductid.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ketnoi.Close();
                hienthi();
            }
        }

        int status = MANAGEMENT.status;
        private void btStatus_Click(object sender, EventArgs e)
        {
            if (status == 1) //Warehouse sang Stock
            {
                btUpdateQuantity.Enabled = false;
                txtquantity.Enabled = false;
                txtprice.Enabled = txtproductname.Enabled = cbbSppID.Enabled = true;
                btAdd.Enabled = btEdit.Enabled = btDelete.Enabled = true;
                btStatus.Text = "[STOCK]";

                status = 0;
            }
            else
            if (status == 0) //Stock sang Warehouse
            {
                txtprice.Enabled = txtproductname.Enabled = cbbSppID.Enabled = false;
                btAdd.Enabled = btEdit.Enabled = btDelete.Enabled = false;
                btUpdateQuantity.Enabled = true;
                txtquantity.Enabled = true;
                btStatus.Text = "[WAREHOUSE]";

                status = 1;
            }
        }

        private void listStock_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (status == 0) //Ở trạng thái STOCK mới được nhấp vào List
            {
                if (listStock.SelectedItems.Count > 0)
                {
                    txtproductid.Enabled = true;
                    txtproductid.Text = listStock.SelectedItems[0].SubItems[0].Text;
                    txtproductname.Text = listStock.SelectedItems[0].SubItems[1].Text;
                    txtquantity.Text = listStock.SelectedItems[0].SubItems[2].Text;
                    txtprice.Text = listStock.SelectedItems[0].SubItems[3].Text;
                    cbbSppID.Text = listStock.SelectedItems[0].SubItems[4].Text;
                }

            }
            else
                if (status == 1) //Mở trạng thái WAREHOUSE
            {
                txtquantity.Text = "";
                if (listStock.SelectedItems.Count > 0)
                {
                    txtproductid.Text = listStock.SelectedItems[0].SubItems[0].Text;
                    txtproductname.Text = listStock.SelectedItems[0].SubItems[1].Text;

                    txtprice.Text = listStock.SelectedItems[0].SubItems[3].Text;
                    cbbSppID.Text = listStock.SelectedItems[0].SubItems[4].Text;
                }
            }
        }

        // NHẬP KHO
        int tonKho = 0;
        private void btUpdateQuantity_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtproductid.Text == "" || txtquantity.Text == "")
                    MessageBox.Show("Bạn cần cung cấp đủ thông tin nhập hàng.");
                else
                {
                    sqlQuantity = @"SELECT quantity FROM tblProducts WHERE productID ='" + txtproductid.Text + @"'";
                    ketnoi2 = new SqlConnection(chuoiketnoi);
                    ketnoi2.Open();
                    thuchien2 = new SqlCommand(sqlQuantity, ketnoi2);
                    tonKho += Convert.ToInt32(thuchien2.ExecuteScalar()); //Lưu giá trị tồn kho của Product có ID đã nhập
                    ketnoi2.Close();
                    ketnoi.Open();
                    int newQuantity = tonKho + Convert.ToInt32(txtquantity.Text);
                    sql = @"UPDATE tblProducts SET quantity=N'" + newQuantity //Số lượng nhập + Số lượng tồn kho
                            + @"' WHERE (productID=N'" + txtproductid.Text + @"')";

                    thuchien = new SqlCommand(sql, ketnoi);
                    thuchien.ExecuteNonQuery();
                    ketnoi.Close();
                    hienthi();
                    txtproductid.Text = txtquantity.Text = "";
                    tonKho = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); //Bắt lỗi nếu có nhập trùng ID sản phẩm đã tồn tại
                ketnoi.Close();
                hienthi();
                tonKho = 0;
            }
        }
    }

}
