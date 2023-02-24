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

namespace ProjectCS_CNPM
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, MouseEventArgs e)
        {
            string localCN = "Data Source=KHOAPHAM;Initial Catalog=TheCoffeeHouseCNPM;Integrated Security=True";
            string someeCN = "workstation id=TheCoffeeHouse.mssql.somee.com;packet size=4096;user id=SunnyBiolie_SQLLogin_1;pwd=wu6kexltjr;data source=TheCoffeeHouse.mssql.somee.com;persist security info=False;initial catalog=TheCoffeeHouse";
            SqlConnection sqlCN = new SqlConnection(@localCN);
            SqlDataAdapter sqlDA = new SqlDataAdapter("select * from TaiKhoan where TenDangNhap = N'" + csTBoxName.Texts + "' and MatKhau = N'" + csTBoxPass.Texts + "'", sqlCN);
            DataTable dataTable = new DataTable();
            sqlDA.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                MessageBox.Show(
                    $"Đăng nhập thành công, xin chào {dataTable.Rows[0][0].ToString()}",
                    "Thông báo!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
                this.Hide();
                FormHome formHome = new FormHome(
                    dataTable.Rows[0][0].ToString(),
                    dataTable.Rows[0][1].ToString(),
                    dataTable.Rows[0][2].ToString(),
                    dataTable.Rows[0][3].ToString()
                    );
                formHome.Show();
            }
            else
            {
                MessageBox.Show(
                    "Đăng nhập không thành công, vui lòng kiểm tra lại thông tin đăng nhập",
                    "Thông báo!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
        }
    }
}
