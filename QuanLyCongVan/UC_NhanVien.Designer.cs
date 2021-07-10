namespace QuanLyCongVan
{
    partial class UC_NhanVien
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataTabCVDen = new System.Windows.Forms.DataGridView();
            this.dataTabCVDi = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtSoCV = new System.Windows.Forms.TextBox();
            this.txtDSCV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLoaiVB = new System.Windows.Forms.TextBox();
            this.txtKyHieu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTrichYeu = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lbFileName = new System.Windows.Forms.Label();
            this.btChoose = new System.Windows.Forms.Button();
            this.btCreate = new System.Windows.Forms.Button();
            this.maskDate = new System.Windows.Forms.MaskedTextBox();
            this.comboDVGui = new System.Windows.Forms.ComboBox();
            this.comboDVNhan = new System.Windows.Forms.ComboBox();
            this.btCancel = new System.Windows.Forms.Button();
            this.btOpenFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataTabCVDen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTabCVDi)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTabCVDen
            // 
            this.dataTabCVDen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTabCVDen.Location = new System.Drawing.Point(13, 56);
            this.dataTabCVDen.Name = "dataTabCVDen";
            this.dataTabCVDen.Size = new System.Drawing.Size(369, 408);
            this.dataTabCVDen.TabIndex = 11;
            this.dataTabCVDen.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTabCVDen_CellClick);
            // 
            // dataTabCVDi
            // 
            this.dataTabCVDi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTabCVDi.Location = new System.Drawing.Point(402, 56);
            this.dataTabCVDi.Name = "dataTabCVDi";
            this.dataTabCVDi.Size = new System.Drawing.Size(369, 408);
            this.dataTabCVDi.TabIndex = 12;
            this.dataTabCVDi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTabCVDi_CellClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(112, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 19);
            this.label7.TabIndex = 8;
            this.label7.Text = "Công Văn Đến";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(527, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 19);
            this.label8.TabIndex = 9;
            this.label8.Text = "Công Văn Đi";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(781, 147);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 19);
            this.label12.TabIndex = 12;
            this.label12.Text = "Ngày phát hành:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(781, 101);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 19);
            this.label13.TabIndex = 11;
            this.label13.Text = "Sổ công văn:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(781, 56);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 19);
            this.label14.TabIndex = 10;
            this.label14.Text = "Số công văn:";
            // 
            // txtSoCV
            // 
            this.txtSoCV.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoCV.Location = new System.Drawing.Point(899, 52);
            this.txtSoCV.Name = "txtSoCV";
            this.txtSoCV.Size = new System.Drawing.Size(268, 27);
            this.txtSoCV.TabIndex = 0;
            // 
            // txtDSCV
            // 
            this.txtDSCV.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDSCV.Location = new System.Drawing.Point(899, 97);
            this.txtDSCV.Name = "txtDSCV";
            this.txtDSCV.Size = new System.Drawing.Size(268, 27);
            this.txtDSCV.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(781, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "Công văn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(781, 376);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 19);
            this.label2.TabIndex = 24;
            this.label2.Text = "Đơn vị nhận:";
            // 
            // txtLoaiVB
            // 
            this.txtLoaiVB.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoaiVB.Location = new System.Drawing.Point(899, 280);
            this.txtLoaiVB.Name = "txtLoaiVB";
            this.txtLoaiVB.Size = new System.Drawing.Size(268, 27);
            this.txtLoaiVB.TabIndex = 5;
            // 
            // txtKyHieu
            // 
            this.txtKyHieu.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKyHieu.Location = new System.Drawing.Point(899, 235);
            this.txtKyHieu.Name = "txtKyHieu";
            this.txtKyHieu.Size = new System.Drawing.Size(268, 27);
            this.txtKyHieu.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(781, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 19);
            this.label3.TabIndex = 20;
            this.label3.Text = "Đơn vị gửi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(781, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 19);
            this.label4.TabIndex = 19;
            this.label4.Text = "Loại văn bản:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(781, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 19);
            this.label5.TabIndex = 18;
            this.label5.Text = "Số ký hiệu:";
            // 
            // txtTrichYeu
            // 
            this.txtTrichYeu.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrichYeu.Location = new System.Drawing.Point(899, 417);
            this.txtTrichYeu.Name = "txtTrichYeu";
            this.txtTrichYeu.Size = new System.Drawing.Size(268, 27);
            this.txtTrichYeu.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(781, 421);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 19);
            this.label9.TabIndex = 26;
            this.label9.Text = "Trích yếu:";
            // 
            // lbFileName
            // 
            this.lbFileName.AutoSize = true;
            this.lbFileName.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFileName.Location = new System.Drawing.Point(895, 197);
            this.lbFileName.Name = "lbFileName";
            this.lbFileName.Size = new System.Drawing.Size(73, 19);
            this.lbFileName.TabIndex = 30;
            this.lbFileName.Text = "fileName";
            // 
            // btChoose
            // 
            this.btChoose.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChoose.Location = new System.Drawing.Point(1063, 189);
            this.btChoose.Name = "btChoose";
            this.btChoose.Size = new System.Drawing.Size(104, 27);
            this.btChoose.TabIndex = 3;
            this.btChoose.Text = "Chọn file";
            this.btChoose.UseVisualStyleBackColor = true;
            this.btChoose.Click += new System.EventHandler(this.btChoose_Click);
            // 
            // btCreate
            // 
            this.btCreate.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCreate.Location = new System.Drawing.Point(785, 470);
            this.btCreate.Name = "btCreate";
            this.btCreate.Size = new System.Drawing.Size(133, 35);
            this.btCreate.TabIndex = 9;
            this.btCreate.Text = "Tạo công văn";
            this.btCreate.UseVisualStyleBackColor = true;
            this.btCreate.Click += new System.EventHandler(this.btCreate_Click);
            // 
            // maskDate
            // 
            this.maskDate.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskDate.Location = new System.Drawing.Point(899, 144);
            this.maskDate.Mask = "00/00/0000";
            this.maskDate.Name = "maskDate";
            this.maskDate.Size = new System.Drawing.Size(268, 27);
            this.maskDate.TabIndex = 2;
            this.maskDate.ValidatingType = typeof(System.DateTime);
            // 
            // comboDVGui
            // 
            this.comboDVGui.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDVGui.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboDVGui.FormattingEnabled = true;
            this.comboDVGui.Location = new System.Drawing.Point(899, 327);
            this.comboDVGui.Name = "comboDVGui";
            this.comboDVGui.Size = new System.Drawing.Size(268, 27);
            this.comboDVGui.TabIndex = 6;
            // 
            // comboDVNhan
            // 
            this.comboDVNhan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDVNhan.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboDVNhan.FormattingEnabled = true;
            this.comboDVNhan.Location = new System.Drawing.Point(899, 373);
            this.comboDVNhan.Name = "comboDVNhan";
            this.comboDVNhan.Size = new System.Drawing.Size(268, 27);
            this.comboDVNhan.TabIndex = 7;
            this.comboDVNhan.DropDownClosed += new System.EventHandler(this.comboDVNhan_DropDownClosed);
            // 
            // btCancel
            // 
            this.btCancel.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancel.Location = new System.Drawing.Point(1034, 470);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(133, 35);
            this.btCancel.TabIndex = 10;
            this.btCancel.Text = "Hủy tạo công văn";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btOpenFile
            // 
            this.btOpenFile.Enabled = false;
            this.btOpenFile.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOpenFile.Location = new System.Drawing.Point(344, 470);
            this.btOpenFile.Name = "btOpenFile";
            this.btOpenFile.Size = new System.Drawing.Size(94, 35);
            this.btOpenFile.TabIndex = 13;
            this.btOpenFile.Text = "Mở File";
            this.btOpenFile.UseVisualStyleBackColor = true;
            this.btOpenFile.Click += new System.EventHandler(this.btOpenFile_Click);
            // 
            // UC_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btOpenFile);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.comboDVNhan);
            this.Controls.Add(this.comboDVGui);
            this.Controls.Add(this.maskDate);
            this.Controls.Add(this.btCreate);
            this.Controls.Add(this.btChoose);
            this.Controls.Add(this.lbFileName);
            this.Controls.Add(this.txtTrichYeu);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLoaiVB);
            this.Controls.Add(this.txtKyHieu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDSCV);
            this.Controls.Add(this.txtSoCV);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataTabCVDi);
            this.Controls.Add(this.dataTabCVDen);
            this.Name = "UC_NhanVien";
            this.Size = new System.Drawing.Size(1184, 520);
            this.Load += new System.EventHandler(this.UC_NV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTabCVDen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTabCVDi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataTabCVDen;
        private System.Windows.Forms.DataGridView dataTabCVDi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtSoCV;
        private System.Windows.Forms.TextBox txtDSCV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLoaiVB;
        private System.Windows.Forms.TextBox txtKyHieu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTrichYeu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbFileName;
        private System.Windows.Forms.Button btChoose;
        private System.Windows.Forms.Button btCreate;
        private System.Windows.Forms.MaskedTextBox maskDate;
        private System.Windows.Forms.ComboBox comboDVGui;
        private System.Windows.Forms.ComboBox comboDVNhan;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btOpenFile;
    }
}
