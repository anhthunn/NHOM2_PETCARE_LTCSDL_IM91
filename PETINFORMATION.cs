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
    public partial class PETINFORMATION : Form
    {
        public PETINFORMATION()
        {
            InitializeComponent();
        }
        string connStr = @"Data Source=DESKTOP-6D460O9;Initial Catalog=PetCareDB; Persist Security Info=True;User ID=anhthu;Password=at0410";
        SqlConnection sqlConnection; //Kết nối CSDL
        SqlDataReader sqlDataReader;

        public void ConnectDatabase()
        {
            sqlConnection = new SqlConnection(connStr);
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
                    string sqlID = "SELECT petID FROM tblPets WHERE petID = '" + ID + "'";
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

        public void SavePets()
        {

            try
            {
                if (txtContact.Text == "" || txtCustomerName.Text == "" || txtPetID.Text == "" || txtPetName.Text == "")
                    MessageBox.Show("Bạn cần nhập đầy đủ thông tin khách hàng.");
                else
                {
                    ConnectDatabase();
                    SqlCommand cmd;
                    string sqlAddPets = "INSERT INTO tblPets(petID, petname, customername, contact) VALUES (@petID, @petname, @customername, @contact)";
                    cmd = new SqlCommand(sqlAddPets, sqlConnection);
                    cmd.Parameters.Add("@petID", SqlDbType.NChar).Value = txtPetID.Text;
                    cmd.Parameters.Add("@petname", SqlDbType.NVarChar).Value = txtPetName.Text;
                    cmd.Parameters.Add("@customername", SqlDbType.NVarChar).Value = txtCustomerName.Text;
                    cmd.Parameters.Add("@contact", SqlDbType.NChar).Value = txtContact.Text;
                    cmd.ExecuteNonQuery();
                    sqlConnection.Close();
                    MessageBox.Show("Thêm khách hàng thú cưng này thành công! Đã có thể đến mục thanh toán.");
                    txtContact.Text = txtCustomerName.Text = txtPetID.Text = txtPetName.Text = "";

                    txtPetID.Text = randomID();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                sqlConnection.Close();
            }
        }
        private void btSavePetInfor_Click(object sender, EventArgs e)
        {
            SavePets();

        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
            PAYMENT form = new PAYMENT();
            form.ShowDialog();
        }

        private void PETINFORMATION_Load(object sender, EventArgs e)
        {
            txtPetID.Text = randomID();
        }

    }
}
