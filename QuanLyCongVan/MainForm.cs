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
    public partial class MainForm : Form
    {
        String IDPQp;
        String maNV;
        String maPB;
        public MainForm(String IDPQ, String fullName, String MaNV, String MaPB)
        {
            InitializeComponent();
            lbName.Text = fullName;
            IDPQp = IDPQ;
            maNV = MaNV;
            maPB = MaPB;
            
        }

        private void lãnhĐạoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(IDPQp == "1")
            {
                UC_LanhDao uiLanhDao = new UC_LanhDao(this.maNV, this.maPB);
                mainPanel.Show();
                mainPanel.Controls.Clear();
                uiLanhDao.Dock = DockStyle.Fill;
                mainPanel.Controls.Add(uiLanhDao);
                uiLanhDao.Show();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền sử dụng chức năng này!!");
            }
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(IDPQp == "2")
            {
                UC_NhanVien uiNhanVien = new UC_NhanVien(this.maNV, this.maPB);
                mainPanel.Show();
                mainPanel.Controls.Clear();
                uiNhanVien.Dock = DockStyle.Fill;
                mainPanel.Controls.Add(uiNhanVien);
                uiNhanVien.Show();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập chức năng này!!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            Application.Restart();
        }
    }
}
