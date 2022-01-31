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
    public partial class PAYMENT : Form
    {
        public PAYMENT()
        {
            InitializeComponent();
        }

        string connStr = @"Data Source=DESKTOP-6D460O9;Initial Catalog=PetCareDB; Persist Security Info=True;User ID=anhthu;Password=at0410";
        SqlConnection sqlConnection, ketnoi2; //Kết nối CSDL
        SqlCommand sqlCommand, thuchien2, thuchien; //Thực hiện câu lệnh T-SQL        
        SqlDataReader sqlDataReader; //Đọc CSDL 
        int i;

        public void ConnectDatabase()
        {
            sqlConnection = new SqlConnection(connStr);
            sqlConnection.Open();
        }

        public void showUnpaidCustomers()
        {
            ConnectDatabase();
            string sql = "SELECT * FROM tblPets  ORDER BY petID";
            sqlCommand = new SqlCommand(sql, sqlConnection);
            sqlDataReader = sqlCommand.ExecuteReader();
            i = 0;
            while (sqlDataReader.Read())
            {
                listUnpaid.Items.Add(sqlDataReader[0].ToString());
                listUnpaid.Items[i].SubItems.Add(sqlDataReader[1].ToString());
                listUnpaid.Items[i].SubItems.Add(sqlDataReader[2].ToString());
                listUnpaid.Items[i].SubItems.Add(sqlDataReader[3].ToString());
                i++;
            }
            sqlConnection.Close();
        }
        public void DeletePaidCustomer()
        {
            try
            {
                ConnectDatabase();
                string sqlDelete = "DELETE tblPets WHERE petID = " + txtPetID.Text;
                sqlCommand = new SqlCommand(sqlDelete, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            MessageBox.Show("Đã thanh toán thành công cho khách hàng này!");
        }

        int countRowIndex2 = 0;
        string billInfo1 = "";
        string billInfo2 = "";
        string proName = "";
        string serName = "";
        int proQuantity = 0;
        int serQuantity = 0;
        
        int totalBill = 0;
        public void SaveBill()
        {
            try
            {
                foreach (ListViewItem item in listDetail.Items)
                {
                    if(listDetail.Items[countRowIndex2].SubItems[0].Text != "") //Mua sản phẩm + dịch vụ
                    {
                        if (listDetail.Items[countRowIndex2].SubItems[1].Text != "") 
                        {
                            proName = listDetail.Items[countRowIndex2].SubItems[0].Text;
                            proQuantity = Convert.ToInt32(listDetail.Items[countRowIndex2].SubItems[2].Text);
                            billInfo1 += String.Format("{0} ({1}) {2}", proName, proQuantity, "; ");

                            serName = listDetail.Items[countRowIndex2].SubItems[1].Text;
                            serQuantity = Convert.ToInt32(listDetail.Items[countRowIndex2].SubItems[2].Text);
                            billInfo2 += String.Format("{0} ({1}) {2}", serName, serQuantity, "; ");
                        }
                        else //Mua sản phẩm, không mua dịch vụ
                        {
                            proName = listDetail.Items[countRowIndex2].SubItems[0].Text;
                            proQuantity = Convert.ToInt32(listDetail.Items[countRowIndex2].SubItems[2].Text);
                            billInfo1 += String.Format("{0} ({1}) {2}", proName, proQuantity, "; ");
                        }    
                      
                    } 
                    else //Mua dịch vụ, không mua sản phẩm
                    {
                        serName = listDetail.Items[countRowIndex2].SubItems[1].Text;
                        serQuantity = Convert.ToInt32(listDetail.Items[countRowIndex2].SubItems[2].Text);
                        billInfo2 += String.Format("{0} ({1}) {2}", serName, serQuantity, "; ");
                    }    
                    
                    countRowIndex2++;
                }
                ConnectDatabase();
                SqlCommand cmd;
                string sqlSaveBill = "INSERT INTO tblBill(petID, petname, customername, product, service, total, staff, dayandtime) " +
                                       "VALUES (@petID, @petname, @customername, @product, @service, @total, @staff, @dayandtime)";
                cmd = new SqlCommand(sqlSaveBill, sqlConnection);
                cmd.Parameters.Add("@petID", SqlDbType.NChar).Value = txtPetID.Text;
                cmd.Parameters.Add("@petname", SqlDbType.NVarChar).Value = txtPetName.Text;
                cmd.Parameters.Add("@customername", SqlDbType.NVarChar).Value = txtCustomerName.Text;                
                cmd.Parameters.Add("@product", SqlDbType.NVarChar).Value = billInfo1;
                cmd.Parameters.Add("@service", SqlDbType.NVarChar).Value = billInfo2;
                cmd.Parameters.Add("@total", SqlDbType.NChar).Value = lbTotal.Text;
                cmd.Parameters.Add("@staff", SqlDbType.NVarChar).Value = lbStaff.Text; //Tên chủ tài khoản
                cmd.Parameters.Add("@dayandtime", SqlDbType.NChar).Value = lbDateTime.Text;
                cmd.ExecuteNonQuery();

                sqlConnection.Close();
                billInfo1 = billInfo2 = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                sqlConnection.Close();
            }
        }

        int countRowIndex = 0;
        int countRowIndex3 = 0;
        int tonKho = 0;
        private void btAdd_Click(object sender, EventArgs e)
        {
            
            string name = "";
            int newQuantity = 0;

            if (txtCustomerName.Text == "")
                MessageBox.Show("Bạn chưa chọn khách hàng cần thanh toán.");
            else
            {
                if (listUnpaid.SelectedItems.Count > 1)
                    MessageBox.Show("Chỉ được thanh toán lần lượt một khách hàng!");
                else
                {
                    if ((cbbService.SelectedItem != null && numService.Value == 0) ||
                                (cbbService.SelectedItem == null && numService.Value > 0) ||
                                    (cbbProduct.SelectedItem != null && numProduct.Value == 0) ||
                                        (cbbProduct.SelectedItem == null && numProduct.Value > 0))
                        MessageBox.Show("Bạn cần chọn thông tin dịch vụ/sản phẩm.");
                    else
                    {

                        if (cbbService.SelectedItem != null && numService.Value > 0)
                        {
                            int count = 0;
                            bool flag = false;
                            foreach (ListViewItem item in listDetail.Items)
                            {
                                if (listDetail.Items[count].SubItems[1].Text.Trim() == cbbService.Text.Trim()) //Nếu tìm thấy dịch vụ đã có trong DS thì cộng SL lên chứ không thêm dòng mới
                                {
                                    int quantity = Convert.ToInt32(listDetail.Items[count].SubItems[2].Text);
                                    listDetail.Items[count].SubItems[2].Text = (quantity + numService.Value).ToString();
                                    totalBill += Convert.ToInt32(numService.Value) * Convert.ToInt32(listDetail.Items[count].SubItems[3].Text);
                                    lbTotal.Text = totalBill.ToString();
                                    listDetail.Items[count].SubItems[4].Text = (Convert.ToInt32(listDetail.Items[count].SubItems[2].Text) *
                                                                                    Convert.ToInt32(listDetail.Items[count].SubItems[3].Text)).ToString(); //Cập nhật lại cột Total
                                    flag = true;
                                    break;
                                }
                                count++;
                            }

                            if (flag == false)
                            {
                                ConnectDatabase();
                                SqlCommand sql1;
                                string sqlServicePrice = "SELECT price FROM tblServices WHERE servicename = N'" + cbbService.Text + "'";
                                sql1 = new SqlCommand(sqlServicePrice, sqlConnection);
                                int priceService = Convert.ToInt32(sql1.ExecuteScalar()); //Lấy ra giá sản phẩm                        
                                int totalService = priceService * Convert.ToInt32(numService.Value);
                                string[] rowService = { cbbService.Text, numService.Value.ToString(), priceService.ToString(), totalService.ToString() };
                                listDetail.Items.Add("").SubItems.AddRange(rowService);

                                sqlConnection.Close();


                                totalBill += Convert.ToInt32(listDetail.Items[countRowIndex].SubItems[4].Text);
                                lbTotal.Text = totalBill.ToString();
                                countRowIndex++;
                            }


                            cbbService.SelectedItem = null;
                            numService.Value = 0;
                        }

                        if (cbbProduct.SelectedItem != null && numProduct.Value > 0)
                        {
                            int count = 0;
                            bool flag = false;
                            foreach (ListViewItem item in listDetail.Items)
                            {
                                if (listDetail.Items[count].SubItems[0].Text.Trim() == cbbProduct.Text.Trim()) //Nếu tìm thấy sản phẩm đã có trong DS thì cộng SL lên chứ không thêm dòng mới
                                {
                                    int quantity = Convert.ToInt32(listDetail.Items[count].SubItems[2].Text);
                                    listDetail.Items[count].SubItems[2].Text = (quantity + numProduct.Value).ToString();
                                    totalBill += Convert.ToInt32(numProduct.Value) * Convert.ToInt32(listDetail.Items[count].SubItems[3].Text);
                                    lbTotal.Text = totalBill.ToString();
                                    listDetail.Items[count].SubItems[4].Text = (Convert.ToInt32(listDetail.Items[count].SubItems[2].Text) *
                                                                                   Convert.ToInt32(listDetail.Items[count].SubItems[3].Text)).ToString(); //Cập nhật lại cột Total
                                    flag = true;
                                    break;
                                }
                                count++;
                            }
                            if (flag == false)
                            {
                                string sqlQuantity;
                                name = cbbProduct.Text.Trim(); //Bỏ qua các kí tự khoảng trắng                   
                                sqlQuantity = @"SELECT quantity FROM tblProducts WHERE productname =N'" + name + @"'";
                                ketnoi2 = new SqlConnection(connStr);
                                ketnoi2.Open();
                                thuchien2 = new SqlCommand(sqlQuantity, ketnoi2);
                                tonKho += Convert.ToInt32(thuchien2.ExecuteScalar()); //Gán giá trị tồn kho của sản phẩm đã bán                   
                                ketnoi2.Close();
                                newQuantity = tonKho - Convert.ToInt32(numProduct.Value); //Số lượng tồn của sản phẩm - Số lượng vừa bán

                                if (newQuantity < 0) //Nếu sản phẩm bán > số lượng tồn kho hoặc sản phẩm trong kho = 0
                                {
                                    MessageBox.Show("Sản phẩm " + name + " đã hết hàng hoặc không đủ số lượng để bán. Sản phẩm còn lại trong kho là: " + tonKho);
                                    tonKho = 0;
                                }
                                else
                                {

                                    ConnectDatabase();
                                    SqlCommand sql1;
                                    string sqlProductPrice = "SELECT price FROM tblProducts WHERE productname = N'" + cbbProduct.Text + "'";
                                    sql1 = new SqlCommand(sqlProductPrice, sqlConnection);
                                    int priceProduct = Convert.ToInt32(sql1.ExecuteScalar()); //Lấy ra giá sản phẩm                        
                                    int totalProduct = priceProduct * Convert.ToInt32(numProduct.Value);
                                    string[] rowProduct = { "", numProduct.Value.ToString(), priceProduct.ToString(), totalProduct.ToString() };
                                    listDetail.Items.Add(cbbProduct.Text).SubItems.AddRange(rowProduct);
                                    sqlConnection.Close();

                                    if (listDetail.Items.Count > 0)
                                    {
                                        totalBill += Convert.ToInt32(listDetail.Items[countRowIndex].SubItems[4].Text);
                                        countRowIndex++;
                                    }
                                    tonKho = 0;


                                }
                            }
                        }            
                
            
                        cbbProduct.SelectedItem = null;
                        cbbService.SelectedItem = null;
                        numProduct.Value = 0;
                        numService.Value = 0;
                    }

                    lbTotal.Text = totalBill.ToString();
                }
            }
        }


        string name = "";
        int newQuantity = 0;
        private void btConfirm_Click(object sender, EventArgs e)
        {
            if (listDetail.Items.Count == 0 || txtCustomerName.Text == "") //Khi Bill đang rỗng
                MessageBox.Show("Bạn cần chọn các thông tin thanh toán.");
            else
            {                        
                //Giảm số lượng sản phẩm trong kho khi bán thành công
                try
                {
                    
                    DialogResult dr = MessageBox.Show("Sau khi xác nhận sẽ xóa khách hàng khỏi [danh sách khách hàng chưa thanh toán]. Chắc chắn thanh toán cho khách hàng này?",
                                   "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dr == DialogResult.Yes)
                    {
                        foreach (ListViewItem item in listDetail.Items)
                        {
                            if (listDetail.Items[countRowIndex3].SubItems[0].Text != "" && listDetail.Items[countRowIndex3].SubItems[1].Text == "")
                            {
                                tonKho = 0;
                                string sqlQuantity;
                                name = listDetail.Items[countRowIndex3].SubItems[0].Text.Trim(); //Bỏ qua các kí tự khoảng trắng                   
                                sqlQuantity = @"SELECT quantity FROM tblProducts WHERE productname =N'" + name + @"'";
                                ketnoi2 = new SqlConnection(connStr);
                                ketnoi2.Open();
                                thuchien2 = new SqlCommand(sqlQuantity, ketnoi2);
                                tonKho += Convert.ToInt32(thuchien2.ExecuteScalar()); //Gán giá trị tồn kho của sản phẩm đã bán                   
                                ketnoi2.Close();
                                newQuantity = tonKho - Convert.ToInt32(listDetail.Items[countRowIndex3].SubItems[2].Text); //Số lượng tồn của sản phẩm - Số lượng vừa bán


                                string sql = @"UPDATE tblProducts SET quantity=N'" + newQuantity
                                    + @"' WHERE (productname=N'" + name + @"')";
                                sqlConnection = new SqlConnection(connStr);
                                sqlConnection.Open();
                                thuchien = new SqlCommand(sql, sqlConnection);
                                thuchien.ExecuteNonQuery();
                                sqlConnection.Close();

                                name = "";
                                newQuantity = 0;                               
                            }
                            countRowIndex3++;
                        }
                        DeletePaidCustomer();
                        if (listUnpaid.SelectedItems.Count > 1)
                            MessageBox.Show("Chỉ được thanh toán lần lượt một khách hàng!");
                        else
                        if (listUnpaid.SelectedItems.Count == 1)
                        {
                            for (int i = 0; i < listUnpaid.SelectedItems.Count; i++)
                                listUnpaid.Items.Remove(listUnpaid.SelectedItems[i]);
                        }
                        SaveBill();
                        cbbProduct.SelectedItem = null;
                        cbbService.SelectedItem = null;
                        txtCustomerName.Text = txtPetID.Text = txtPetName.Text = "";
                        lbTotal.Text = "";
                        listDetail.Items.Clear();
                        totalBill = 0;
                        numProduct.Value = 0;
                        numService.Value = 0;
                        countRowIndex = 0;
                        countRowIndex2 = 0;
                        countRowIndex3 = 0;

                    }
                   

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message); 
                    sqlConnection.Close();
                }
               
            }            
        }

        private void btX_Click(object sender, EventArgs e)
        {
            if (listDetail.SelectedItems.Count > 0)
            {
                if (listDetail.SelectedItems.Count > 1)
                    MessageBox.Show("Chỉ được xóa lần lượt từng sản phẩm.");
                else
                {
                    int quantity = Convert.ToInt32(listDetail.SelectedItems[0].SubItems[2].Text);
                    if (quantity == 1)
                    {
                        totalBill = (Convert.ToInt32(lbTotal.Text) - Convert.ToInt32(listDetail.SelectedItems[0].SubItems[4].Text)); //Cập nhật lại Total Bill
                        lbTotal.Text = totalBill.ToString();
                        listDetail.Items.RemoveAt(listDetail.SelectedIndices[0]);
                                              
                        countRowIndex = 0;
                    }
                    else
                        if (quantity > 1)
                    {
                        quantity--;
                        listDetail.SelectedItems[0].SubItems[2].Text = quantity.ToString();
                        listDetail.SelectedItems[0].SubItems[4].Text = (Convert.ToInt32(listDetail.SelectedItems[0].SubItems[2].Text) *
                                                                        Convert.ToInt32(listDetail.SelectedItems[0].SubItems[3].Text)).ToString(); //Cập nhật lại cột Total

                        totalBill = (Convert.ToInt32(lbTotal.Text) - Convert.ToInt32(listDetail.SelectedItems[0].SubItems[3].Text));
                        lbTotal.Text = totalBill.ToString();
                    }
                }
            }
        }


        private void btAddPet_Click(object sender, EventArgs e)
        {
            this.Close();
            PETINFORMATION form = new PETINFORMATION();
            form.ShowDialog();
            this.Show();
        }

        private void btCancel1_Click(object sender, EventArgs e)
        {
            if(cbbService.Text != "")
            {
                cbbService.SelectedItem = null;
            }    
        }

        private void btCancel2_Click(object sender, EventArgs e)
        {
            if (cbbProduct.Text != "")
            {
                cbbProduct.SelectedItem = null;
            }
        }

        private void listPaymentDetail_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listUnpaid.SelectedItems.Count > 0)
            {
                txtPetID.Text = listUnpaid.SelectedItems[0].SubItems[0].Text;
                txtPetName.Text = listUnpaid.SelectedItems[0].SubItems[1].Text;
                txtCustomerName.Text = listUnpaid.SelectedItems[0].SubItems[2].Text;
            }
        }

        private void PAYMENT_Load(object sender, EventArgs e)
        {            
            // TODO: This line of code loads data into the 'dataSet.tblServices' table. You can move, or remove it, as needed.
            this.tblServicesTableAdapter.Fill(this.dataSet.tblServices);
            this.tblProductsTableAdapter.Fill(this.dataSet.tblProducts);

            showUnpaidCustomers();
            lbDateTime.Text = DateTime.Now.ToString();
            cbbProduct.SelectedItem = null;
            cbbService.SelectedItem = null;

            try
            {

                ConnectDatabase();
                string sqlGet = "SELECT fullname FROM tblAccount WHERE username = '" + LOGIN.userName + "'";
                sqlCommand = new SqlCommand(sqlGet, sqlConnection);
                lbStaff.Text = sqlCommand.ExecuteScalar().ToString();
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }                
               
    }
}
