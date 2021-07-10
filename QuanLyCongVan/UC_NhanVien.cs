using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace QuanLyCongVan
{
    public partial class UC_NhanVien : UserControl
    {
        String maNV;
        String maPB;
        String maPBNhan = "";
        String path = "";
        public UC_NhanVien(String MaNV, String MaPB)
        {
            InitializeComponent();
            maNV = MaNV;
            maPB = MaPB;
        }

        private void loadData()
        {
            SQLConnection SQL = new SQLConnection();
            SQL.connect();
            DataTable data = SQL.queryData("Select ROW_NUMBER() Over(Order by MaCongVan) AS STT, MaCongVan, SoKyHieu, TrichYeu, TrangThai From CongVan Where DonViGui = '" + maPB + "'");
            dataTabCVDi.DataSource = data;
            data = SQL.queryData("Select ROW_NUMBER() Over(Order by MaCongVan) AS STT, MaCongVan, SoKyHieu, TrichYeu, TrangThai From CongVan Where DonViNhan = '" + maPB + "'");
            dataTabCVDen.DataSource = data;
            SQL.disconect();
        }

        private void UC_NV_Load(object sender, EventArgs e)
        {
            loadData();

            dataTabCVDi.Columns[0].HeaderText = "STT";
            dataTabCVDi.Columns[1].HeaderText = "Mã Công Văn";
            dataTabCVDi.Columns[2].HeaderText = "Số Hiệu";
            dataTabCVDi.Columns[3].HeaderText = "Trích Yếu";
            dataTabCVDi.Columns[4].HeaderText = "Trạng Thái";

            dataTabCVDen.Columns[0].HeaderText = "STT";
            dataTabCVDen.Columns[1].HeaderText = "Mã Công Văn";
            dataTabCVDen.Columns[2].HeaderText = "Số Hiệu";
            dataTabCVDen.Columns[3].HeaderText = "Trích Yếu";
            dataTabCVDen.Columns[4].HeaderText = "Trạng Thái";

            SQLConnection SQL = new SQLConnection();
            SQL.connect();
            DataTable data = SQL.queryData("Select TenPB From PhongBan");
            for(int i = 0; i < data.Rows.Count; i ++)
            {
                comboDVNhan.Items.Add(data.Rows[i][0].ToString());
            }
            //comboDVNhan.SelectedIndex = 0;
            data = SQL.queryData("Select TenPB From PhongBan Where MaPB = '" + maPB + "'");
            comboDVGui.Items.Add(data.Rows[0][0].ToString());
            comboDVGui.SelectedIndex = 0;
            SQL.disconect();

        }

        private void btChoose_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog
            {
                InitialDirectory = @"D:\",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "docx",
                Filter = "docx files (*.docx)|*.docx",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if(fileDialog.ShowDialog() == DialogResult.OK)
            {
                path = fileDialog.FileName;
                String []ch = path.Split('\\');
                lbFileName.Text = ch[ch.Length - 1];
            }
        }

        private void btCreate_Click(object sender, EventArgs e)
        {
            if(lbFileName.Text == "fileName" || maPBNhan == "")
            {
                MessageBox.Show("Chưa chọn file tải lên hoặc chưa chọn đơn vị nhận!");
            }
            else
            {
                SQLConnection SQL = new SQLConnection();
                try
                {
                    SQL.connect();
                    SQL.queryNonReturn("Insert Into CongVan Values ('" + txtSoCV.Text + "', '" + txtDSCV.Text + "', '" + maskDate.Text + "', N'" + lbFileName.Text + "', '" + txtKyHieu.Text + "', N'" + txtLoaiVB.Text + "', '" + maPB + "', '" + maPBNhan + "', N'" + txtTrichYeu.Text + "', N'Chưa Duyệt', '"+path+"')");
                    MessageBox.Show("Thao tác thực hiện thành công!!");
                }
                catch
                {
                    MessageBox.Show("Thao tác thực hiện thất bại!!");
                }
                finally
                {
                    SQL.disconect();
                    loadData();
                }
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            txtSoCV.Text = "";
            txtDSCV.Text = "";
            txtLoaiVB.Text = "";
            maskDate.Text = "";
            lbFileName.Text = "fileName";
            txtKyHieu.Text = "";
            comboDVGui.SelectedIndex = 0;
            comboDVNhan.SelectedIndex = 0;
            txtTrichYeu.Text = "";
        }

        private void comboDVNhan_DropDownClosed(object sender, EventArgs e)
        {
            SQLConnection SQL = new SQLConnection();
            SQL.connect();
            DataTable data = SQL.queryData("Select MaPB From PhongBan Where TenPB = N'" + comboDVNhan.Text + "'");
            maPBNhan = data.Rows[0][0].ToString();
            SQL.disconect();
        }

        private void dataTabCVDen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if(row != -1)
            {
                String ID = dataTabCVDen.Rows[row].Cells[1].Value.ToString();
                if(ID != "")
                {
                    SQLConnection SQL = new SQLConnection();
                    SQL.connect();
                    DataTable data = SQL.queryData("Select FilePath From CongVan Where MaCongVan = '" + ID + "'");
                    path = data.Rows[0][0].ToString();
                    SQL.disconect();
                    this.btOpenFile.Enabled = true;
                }    
            }
        }

        private void dataTabCVDi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row != -1)
            {
                String ID = dataTabCVDi.Rows[row].Cells[1].Value.ToString();
                if(ID != "")
                {
                    SQLConnection SQL = new SQLConnection();
                    SQL.connect();
                    DataTable data = SQL.queryData("Select FilePath From CongVan Where MaCongVan = '" + ID + "'");
                    path = data.Rows[0][0].ToString();
                    SQL.disconect();
                    this.btOpenFile.Enabled = true;
                }    
            }
        }

        private void btOpenFile_Click(object sender, EventArgs e)
        {
            Process.Start(path);
        }
    }
}
