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
    public partial class ACCOUNTDETAILS : Form
    {
        public ACCOUNTDETAILS()
        {
            InitializeComponent();
        }
        string connStr = @"Data Source=DESKTOP-6D460O9;Initial Catalog=PetCareDB; Persist Security Info=True;User ID=anhthu;Password=at0410";
        SqlConnection sqlConnection; //Kết nối CSDL
        SqlCommand sqlCommand; //Thực hiện câu lệnh T-SQL        
        SqlDataReader sqlDataReader; //Đọc CSDL 
        int i;

        public void ConnectDatabase()
        {
            sqlConnection = new SqlConnection(connStr);
            sqlConnection.Open();
        }
        public void showAllAccount()
        {
            try
            {
                ConnectDatabase();
                string sql = "SELECT * FROM tblAccount";
                sqlCommand = new SqlCommand(sql, sqlConnection);
                sqlDataReader = sqlCommand.ExecuteReader();
                i = 0;
                while (sqlDataReader.Read())
                {
                    listAccount.Items.Add(sqlDataReader[0].ToString());
                    listAccount.Items[i].SubItems.Add(sqlDataReader[1].ToString());
                    listAccount.Items[i].SubItems.Add(sqlDataReader[2].ToString());
                    listAccount.Items[i].SubItems.Add(sqlDataReader[3].ToString());

                    i++;
                }
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                sqlConnection.Close();
            }
        }
        private void ACCOUNTDETAILS_Load(object sender, EventArgs e)
        {
            showAllAccount();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
