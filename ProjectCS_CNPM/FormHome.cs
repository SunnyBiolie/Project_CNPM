using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectCS_CNPM
{
    public partial class FormHome : Form
    {
        string TenNhanVien = "", TenDangNhap = "", MatKhau = "", PhanQuyen = "";

        public FormHome()
        {
            InitializeComponent();
        }

        public FormHome(string staffname, string username, string password, string position)
        {
            InitializeComponent();
            TenNhanVien = staffname;
            TenDangNhap = username;
            MatKhau = password;
            PhanQuyen = position;
        }
        private void FormHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
