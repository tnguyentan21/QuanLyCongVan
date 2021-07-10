namespace QuanLyCongVan
{
    partial class UC_LanhDao
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
            this.btCancelProcess = new System.Windows.Forms.Button();
            this.maskDate = new System.Windows.Forms.MaskedTextBox();
            this.btApproval = new System.Windows.Forms.Button();
            this.lbFileName = new System.Windows.Forms.Label();
            this.txtTrichYeu = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLoaiVB = new System.Windows.Forms.TextBox();
            this.txtKyHieu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDSCV = new System.Windows.Forms.TextBox();
            this.txtSoCV = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataTabDaDuyet = new System.Windows.Forms.DataGridView();
            this.dataTabChuaDuyet = new System.Windows.Forms.DataGridView();
            this.btCreate = new System.Windows.Forms.Button();
            this.comboDVNhan = new System.Windows.Forms.ComboBox();
            this.comboDVGui = new System.Windows.Forms.ComboBox();
            this.btCancel = new System.Windows.Forms.Button();
            this.btChoose = new System.Windows.Forms.Button();
            this.btOpenFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataTabDaDuyet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTabChuaDuyet)).BeginInit();
            this.SuspendLayout();
            // 
            // btCancelProcess
            // 
            this.btCancelProcess.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelProcess.Location = new System.Drawing.Point(1188, 571);
            this.btCancelProcess.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btCancelProcess.Name = "btCancelProcess";
            this.btCancelProcess.Size = new System.Drawing.Size(125, 43);
            this.btCancelProcess.TabIndex = 10;
            this.btCancelProcess.Text = "Hủy xử lý";
            this.btCancelProcess.UseVisualStyleBackColor = true;
            this.btCancelProcess.Click += new System.EventHandler(this.btCancelProcess_Click);
            // 
            // maskDate
            // 
            this.maskDate.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskDate.Location = new System.Drawing.Point(1197, 170);
            this.maskDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.maskDate.Mask = "00/00/0000";
            this.maskDate.Name = "maskDate";
            this.maskDate.Size = new System.Drawing.Size(356, 32);
            this.maskDate.TabIndex = 2;
            this.maskDate.ValidatingType = typeof(System.DateTime);
            // 
            // btApproval
            // 
            this.btApproval.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btApproval.Location = new System.Drawing.Point(1055, 571);
            this.btApproval.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btApproval.Name = "btApproval";
            this.btApproval.Size = new System.Drawing.Size(125, 43);
            this.btApproval.TabIndex = 9;
            this.btApproval.Text = "Xét duyệt";
            this.btApproval.UseVisualStyleBackColor = true;
            this.btApproval.Click += new System.EventHandler(this.btApproval_Click);
            // 
            // lbFileName
            // 
            this.lbFileName.AutoSize = true;
            this.lbFileName.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFileName.Location = new System.Drawing.Point(1192, 235);
            this.lbFileName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFileName.Name = "lbFileName";
            this.lbFileName.Size = new System.Drawing.Size(93, 25);
            this.lbFileName.TabIndex = 55;
            this.lbFileName.Text = "fileName";
            // 
            // txtTrichYeu
            // 
            this.txtTrichYeu.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrichYeu.Location = new System.Drawing.Point(1197, 506);
            this.txtTrichYeu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTrichYeu.Name = "txtTrichYeu";
            this.txtTrichYeu.Size = new System.Drawing.Size(356, 32);
            this.txtTrichYeu.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1049, 511);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 25);
            this.label9.TabIndex = 53;
            this.label9.Text = "Trích yếu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1049, 455);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 25);
            this.label2.TabIndex = 52;
            this.label2.Text = "Đơn vị nhận:";
            // 
            // txtLoaiVB
            // 
            this.txtLoaiVB.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoaiVB.Location = new System.Drawing.Point(1197, 337);
            this.txtLoaiVB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLoaiVB.Name = "txtLoaiVB";
            this.txtLoaiVB.Size = new System.Drawing.Size(356, 32);
            this.txtLoaiVB.TabIndex = 5;
            // 
            // txtKyHieu
            // 
            this.txtKyHieu.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKyHieu.Location = new System.Drawing.Point(1197, 282);
            this.txtKyHieu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKyHieu.Name = "txtKyHieu";
            this.txtKyHieu.Size = new System.Drawing.Size(356, 32);
            this.txtKyHieu.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1049, 399);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 25);
            this.label3.TabIndex = 49;
            this.label3.Text = "Đơn vị gửi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1049, 342);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 25);
            this.label4.TabIndex = 48;
            this.label4.Text = "Loại văn bản:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1049, 287);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 25);
            this.label5.TabIndex = 47;
            this.label5.Text = "Số ký hiệu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1049, 230);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 46;
            this.label1.Text = "Công văn:";
            // 
            // txtDSCV
            // 
            this.txtDSCV.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDSCV.Location = new System.Drawing.Point(1197, 112);
            this.txtDSCV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDSCV.Name = "txtDSCV";
            this.txtDSCV.Size = new System.Drawing.Size(356, 32);
            this.txtDSCV.TabIndex = 1;
            // 
            // txtSoCV
            // 
            this.txtSoCV.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoCV.Location = new System.Drawing.Point(1197, 57);
            this.txtSoCV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSoCV.Name = "txtSoCV";
            this.txtSoCV.Size = new System.Drawing.Size(356, 32);
            this.txtSoCV.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1049, 174);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 25);
            this.label12.TabIndex = 43;
            this.label12.Text = "Ngày đến:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1049, 117);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(125, 25);
            this.label13.TabIndex = 42;
            this.label13.Text = "Sổ công văn:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1049, 62);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(125, 25);
            this.label14.TabIndex = 41;
            this.label14.Text = "Số công văn:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(711, 26);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(191, 25);
            this.label8.TabIndex = 40;
            this.label8.Text = "Công Văn Đã Duyệt";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(157, 26);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(212, 25);
            this.label7.TabIndex = 39;
            this.label7.Text = "Công Văn Chưa Duyệt";
            // 
            // dataTabDaDuyet
            // 
            this.dataTabDaDuyet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTabDaDuyet.Location = new System.Drawing.Point(544, 62);
            this.dataTabDaDuyet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataTabDaDuyet.Name = "dataTabDaDuyet";
            this.dataTabDaDuyet.RowHeadersWidth = 51;
            this.dataTabDaDuyet.Size = new System.Drawing.Size(492, 508);
            this.dataTabDaDuyet.TabIndex = 14;
            this.dataTabDaDuyet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTabDaDuyet_CellClick);
            // 
            // dataTabChuaDuyet
            // 
            this.dataTabChuaDuyet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTabChuaDuyet.Location = new System.Drawing.Point(25, 62);
            this.dataTabChuaDuyet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataTabChuaDuyet.Name = "dataTabChuaDuyet";
            this.dataTabChuaDuyet.RowHeadersWidth = 51;
            this.dataTabChuaDuyet.Size = new System.Drawing.Size(492, 508);
            this.dataTabChuaDuyet.TabIndex = 13;
            this.dataTabChuaDuyet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTabChuaDuyet_CellClick);
            // 
            // btCreate
            // 
            this.btCreate.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCreate.Location = new System.Drawing.Point(1331, 571);
            this.btCreate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btCreate.Name = "btCreate";
            this.btCreate.Size = new System.Drawing.Size(103, 43);
            this.btCreate.TabIndex = 11;
            this.btCreate.Text = "Tạo CV";
            this.btCreate.UseVisualStyleBackColor = true;
            this.btCreate.Click += new System.EventHandler(this.btCreate_Click);
            // 
            // comboDVNhan
            // 
            this.comboDVNhan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDVNhan.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboDVNhan.FormattingEnabled = true;
            this.comboDVNhan.Location = new System.Drawing.Point(1197, 452);
            this.comboDVNhan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboDVNhan.Name = "comboDVNhan";
            this.comboDVNhan.Size = new System.Drawing.Size(356, 31);
            this.comboDVNhan.TabIndex = 7;
            this.comboDVNhan.DropDownClosed += new System.EventHandler(this.comboDVNhan_DropDownClosed);
            // 
            // comboDVGui
            // 
            this.comboDVGui.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDVGui.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboDVGui.FormattingEnabled = true;
            this.comboDVGui.Location = new System.Drawing.Point(1197, 395);
            this.comboDVGui.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboDVGui.Name = "comboDVGui";
            this.comboDVGui.Size = new System.Drawing.Size(356, 31);
            this.comboDVGui.TabIndex = 6;
            // 
            // btCancel
            // 
            this.btCancel.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancel.Location = new System.Drawing.Point(1452, 571);
            this.btCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(103, 43);
            this.btCancel.TabIndex = 12;
            this.btCancel.Text = "Hủy";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btChoose
            // 
            this.btChoose.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChoose.Location = new System.Drawing.Point(1416, 230);
            this.btChoose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btChoose.Name = "btChoose";
            this.btChoose.Size = new System.Drawing.Size(139, 33);
            this.btChoose.TabIndex = 3;
            this.btChoose.Text = "Chọn file";
            this.btChoose.UseVisualStyleBackColor = true;
            this.btChoose.Click += new System.EventHandler(this.btChoose_Click);
            // 
            // btOpenFile
            // 
            this.btOpenFile.Enabled = false;
            this.btOpenFile.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOpenFile.Location = new System.Drawing.Point(459, 577);
            this.btOpenFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btOpenFile.Name = "btOpenFile";
            this.btOpenFile.Size = new System.Drawing.Size(125, 43);
            this.btOpenFile.TabIndex = 15;
            this.btOpenFile.Text = "Mở File";
            this.btOpenFile.UseVisualStyleBackColor = true;
            this.btOpenFile.Click += new System.EventHandler(this.btOpenFile_Click);
            // 
            // UC_LanhDao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btOpenFile);
            this.Controls.Add(this.btChoose);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.comboDVNhan);
            this.Controls.Add(this.comboDVGui);
            this.Controls.Add(this.btCreate);
            this.Controls.Add(this.btCancelProcess);
            this.Controls.Add(this.maskDate);
            this.Controls.Add(this.btApproval);
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
            this.Controls.Add(this.dataTabDaDuyet);
            this.Controls.Add(this.dataTabChuaDuyet);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UC_LanhDao";
            this.Size = new System.Drawing.Size(1579, 640);
            this.Load += new System.EventHandler(this.UC_LanhDao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTabDaDuyet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTabChuaDuyet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCancelProcess;
        private System.Windows.Forms.MaskedTextBox maskDate;
        private System.Windows.Forms.Button btApproval;
        private System.Windows.Forms.Label lbFileName;
        private System.Windows.Forms.TextBox txtTrichYeu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLoaiVB;
        private System.Windows.Forms.TextBox txtKyHieu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDSCV;
        private System.Windows.Forms.TextBox txtSoCV;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataTabDaDuyet;
        private System.Windows.Forms.DataGridView dataTabChuaDuyet;
        private System.Windows.Forms.Button btCreate;
        private System.Windows.Forms.ComboBox comboDVNhan;
        private System.Windows.Forms.ComboBox comboDVGui;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btChoose;
        private System.Windows.Forms.Button btOpenFile;
    }
}
