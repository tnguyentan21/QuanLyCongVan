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
    public partial class UC_LanhDao : UserControl
    {
        String maNV;
        String maPB;
        String path;
        String maPBNhan = "";
        public UC_LanhDao(String MaNV, String MaPB)
        {
            InitializeComponent();
            maNV = MaNV;
            maPB = MaPB;
        }

        private void loadData()
        {
            SQLConnection SQL = new SQLConnection();
            SQL.connect();
            DataTable data = SQL.queryData("Select * From CongVan Where TrangThai = N'Đã Duyệt'");
            if(data.Rows.Count > 0)
            {
                dataTabDaDuyet.DataSource = data;
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    String ID = dataTabDaDuyet.Rows[i].Cells[6].Value.ToString();
                    DataTable dt = SQL.queryData("Select TenPB From PhongBan Where MaPB = '" + ID + "'");
                    dataTabDaDuyet.Rows[i].Cells[6].Value = dt.Rows[0][0].ToString();
                    ID = dataTabDaDuyet.Rows[i].Cells[7].Value.ToString();
                    dt = SQL.queryData("Select TenPB From PhongBan Where MaPB = '" + ID + "'");
                    dataTabDaDuyet.Rows[i].Cells[7].Value = dt.Rows[0][0].ToString();
                }
                data = SQL.queryData("Select * From CongVan Where TrangThai = N'Chưa Duyệt'");
                dataTabChuaDuyet.DataSource = data;
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    String ID = dataTabChuaDuyet.Rows[i].Cells[6].Value.ToString();
                    DataTable dt = SQL.queryData("Select TenPB From PhongBan Where MaPB = '" + ID + "'");
                    dataTabChuaDuyet.Rows[i].Cells[6].Value = dt.Rows[0][0].ToString();
                    ID = dataTabChuaDuyet.Rows[i].Cells[7].Value.ToString();
                    dt = SQL.queryData("Select TenPB From PhongBan Where MaPB = '" + ID + "'");
                    dataTabChuaDuyet.Rows[i].Cells[7].Value = dt.Rows[0][0].ToString();

                }
            }
            SQL.disconect();
        }

        private void UC_LanhDao_Load(object sender, EventArgs e)
        {
            loadData();

            SQLConnection SQL = new SQLConnection();
            SQL.connect();
            DataTable data = SQL.queryData("Select TenPB From PhongBan");
            for (int i = 0; i < data.Rows.Count; i++)
            {
                comboDVNhan.Items.Add(data.Rows[i][0].ToString());
            }
            //comboDVNhan.SelectedIndex = 0;
            data = SQL.queryData("Select TenPB From PhongBan");
            for(int i = 0; i < data.Rows.Count; i ++)
            {
                comboDVGui.Items.Add(data.Rows[i][0].ToString());
            }
            comboDVGui.SelectedIndex = 0;
            SQL.disconect();
        }

        private void btApproval_Click(object sender, EventArgs e)
        {
            SQLConnection SQL = new SQLConnection();
            SQL.connect();
            SQL.queryNonReturn("Update CongVan Set TrangThai = N'Đã Duyệt' Where MaCongVan = '" + txtSoCV.Text + "'");
            SQL.disconect();
            MessageBox.Show("Xét duyệt thành công!!");
            loadData();
        }

        private void btCancelProcess_Click(object sender, EventArgs e)
        {
            SQLConnection SQL = new SQLConnection();
            SQL.connect();
            SQL.queryNonReturn("Update CongVan Set TrangThai = N'Chưa Duyệt' Where MaCongVan = '" + txtSoCV.Text + "'");
            SQL.disconect();
            MessageBox.Show("Hủy Xét Duyệt Thành Công!!");
            loadData();
        }

        private void dataTabChuaDuyet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if(row != -1)
            {
                String ID = dataTabChuaDuyet.Rows[row].Cells[0].Value.ToString();
                txtSoCV.Text = dataTabChuaDuyet.Rows[row].Cells[0].Value.ToString();
                txtDSCV.Text = dataTabChuaDuyet.Rows[row].Cells[1].Value.ToString();
                maskDate.Text = dataTabChuaDuyet.Rows[row].Cells[2].Value.ToString();
                lbFileName.Text = dataTabChuaDuyet.Rows[row].Cells[3].Value.ToString();
                txtKyHieu.Text = dataTabChuaDuyet.Rows[row].Cells[4].Value.ToString();
                txtLoaiVB.Text = dataTabChuaDuyet.Rows[row].Cells[5].Value.ToString();
                comboDVGui.SelectedIndex = comboDVGui.FindStringExact(dataTabChuaDuyet.Rows[row].Cells[6].Value.ToString());
                comboDVNhan.SelectedIndex = comboDVNhan.FindStringExact(dataTabChuaDuyet.Rows[row].Cells[7].Value.ToString());
                txtTrichYeu.Text = dataTabChuaDuyet.Rows[row].Cells[8].Value.ToString();

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

        private void dataTabDaDuyet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row != -1)
            {
                String ID = dataTabDaDuyet.Rows[row].Cells[0].Value.ToString();
                txtSoCV.Text = dataTabDaDuyet.Rows[row].Cells[0].Value.ToString();
                txtDSCV.Text = dataTabDaDuyet.Rows[row].Cells[1].Value.ToString();
                maskDate.Text = dataTabDaDuyet.Rows[row].Cells[2].Value.ToString();
                lbFileName.Text = dataTabDaDuyet.Rows[row].Cells[3].Value.ToString();
                txtKyHieu.Text = dataTabDaDuyet.Rows[row].Cells[4].Value.ToString();
                txtLoaiVB.Text = dataTabDaDuyet.Rows[row].Cells[5].Value.ToString();
                comboDVGui.SelectedIndex = comboDVGui.FindStringExact(dataTabDaDuyet.Rows[row].Cells[6].Value.ToString());
                comboDVNhan.SelectedIndex = comboDVNhan.FindStringExact(dataTabDaDuyet.Rows[row].Cells[7].Value.ToString());
                txtTrichYeu.Text = dataTabDaDuyet.Rows[row].Cells[8].Value.ToString();

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

        private void btCreate_Click(object sender, EventArgs e)
        {
            if (lbFileName.Text == "fileName" || maPBNhan == "")
            {
                MessageBox.Show("Chưa chọn file tải lên hoặc chưa chọn đơn vị nhận!");
            }
            else
            {
                SQLConnection SQL = new SQLConnection();
                try
                {
                    SQL.connect();
                    SQL.queryNonReturn("Insert Into CongVan Values ('" + txtSoCV.Text + "', '" + txtDSCV.Text + "', '" + maskDate.Text + "', N'" + lbFileName.Text + "', '" + txtKyHieu.Text + "', N'" + txtLoaiVB.Text + "', '" + maPB + "', '" + maPBNhan + "', N'" + txtTrichYeu.Text + "', N'Đã Duyệt', '" + path + "')");
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

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                path = fileDialog.FileName;
                String[] ch = path.Split('\\');
                lbFileName.Text = ch[ch.Length - 1];
            }
        }

        private void comboDVNhan_DropDownClosed(object sender, EventArgs e)
        {
            SQLConnection SQL = new SQLConnection();
            SQL.connect();
            DataTable data = SQL.queryData("Select MaPB From PhongBan Where TenPB = N'" + comboDVNhan.Text + "'");
            maPBNhan = data.Rows[0][0].ToString();
            SQL.disconect();
        }

        private void btOpenFile_Click(object sender, EventArgs e)
        {
            Process.Start(path);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
