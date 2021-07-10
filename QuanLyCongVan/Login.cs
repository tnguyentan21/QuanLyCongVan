using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongVan
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            SQLConnection SQL = new SQLConnection();
            try
            {
                SQL.connect();
                DataTable data = SQL.queryData("Select IDCV, TenNV, MaNV, IDPB From NguoiDung Where Username = '" + txtUser.Text + "' And Password = '" + txtPass.Text + "'");
                if (data.Rows.Count > 0)
                {
                    MainForm mainForm = new MainForm(data.Rows[0][0].ToString(), data.Rows[0][1].ToString(), data.Rows[0][2].ToString(), data.Rows[0][3].ToString());
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại!!");
                }
            }
            catch
            {
                MessageBox.Show("Kết nối CSDL thấtt bại!!");
            }
            finally
            {
                SQL.disconect();
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btLogin_Click(sender, e);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += btLogin_KeyDown;
        }
    }
}
