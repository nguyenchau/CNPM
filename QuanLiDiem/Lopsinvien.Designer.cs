namespace QuanLiDiem
{
    partial class Lopsinhvien
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.dtgsinhvien = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.maSVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.danTocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noiSinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maLopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinhVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDDataSet = new QuanLiDiem.QLDDataSet();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.txttimsv = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.cboLop = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btnxoa = new DevComponents.DotNetBar.ButtonX();
            this.btnluusv = new DevComponents.DotNetBar.ButtonX();
            this.btnthemsv = new DevComponents.DotNetBar.ButtonX();
            this.txtdantoc = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtnoisinh = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtgioitinh = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dateTimengaysinh = new System.Windows.Forms.DateTimePicker();
            this.txttensv = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtmasv = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.btnluulop = new DevComponents.DotNetBar.ButtonX();
            this.btnxoalop = new DevComponents.DotNetBar.ButtonX();
            this.btnthemlop = new DevComponents.DotNetBar.ButtonX();
            this.txttenlop = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtmalop = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.sinhVienTableAdapter = new QuanLiDiem.QLDDataSetTableAdapters.SinhVienTableAdapter();
            this.btnThoatxl = new DevComponents.DotNetBar.ButtonX();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgsinhvien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDDataSet)).BeginInit();
            this.groupPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.dtgsinhvien);
            this.panelEx1.Controls.Add(this.groupPanel1);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(885, 403);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            this.panelEx1.Click += new System.EventHandler(this.panelEx1_Click);
            // 
            // dtgsinhvien
            // 
            this.dtgsinhvien.AllowUserToAddRows = false;
            this.dtgsinhvien.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgsinhvien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgsinhvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgsinhvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSVDataGridViewTextBoxColumn,
            this.hoTenDataGridViewTextBoxColumn,
            this.ngaySinhDataGridViewTextBoxColumn,
            this.gioiTinhDataGridViewTextBoxColumn,
            this.danTocDataGridViewTextBoxColumn,
            this.noiSinhDataGridViewTextBoxColumn,
            this.maLopDataGridViewTextBoxColumn});
            this.dtgsinhvien.DataSource = this.sinhVienBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgsinhvien.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgsinhvien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dtgsinhvien.Location = new System.Drawing.Point(70, 198);
            this.dtgsinhvien.Name = "dtgsinhvien";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgsinhvien.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgsinhvien.Size = new System.Drawing.Size(698, 213);
            this.dtgsinhvien.TabIndex = 1;
            // 
            // maSVDataGridViewTextBoxColumn
            // 
            this.maSVDataGridViewTextBoxColumn.DataPropertyName = "MaSV";
            this.maSVDataGridViewTextBoxColumn.HeaderText = "Mã sinh viên";
            this.maSVDataGridViewTextBoxColumn.Name = "maSVDataGridViewTextBoxColumn";
            // 
            // hoTenDataGridViewTextBoxColumn
            // 
            this.hoTenDataGridViewTextBoxColumn.DataPropertyName = "HoTen";
            this.hoTenDataGridViewTextBoxColumn.HeaderText = "Họ và tên";
            this.hoTenDataGridViewTextBoxColumn.Name = "hoTenDataGridViewTextBoxColumn";
            this.hoTenDataGridViewTextBoxColumn.Width = 180;
            // 
            // ngaySinhDataGridViewTextBoxColumn
            // 
            this.ngaySinhDataGridViewTextBoxColumn.DataPropertyName = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.HeaderText = "Ngày Sinh";
            this.ngaySinhDataGridViewTextBoxColumn.Name = "ngaySinhDataGridViewTextBoxColumn";
            // 
            // gioiTinhDataGridViewTextBoxColumn
            // 
            this.gioiTinhDataGridViewTextBoxColumn.DataPropertyName = "GioiTinh";
            this.gioiTinhDataGridViewTextBoxColumn.HeaderText = "Giới Tính";
            this.gioiTinhDataGridViewTextBoxColumn.Name = "gioiTinhDataGridViewTextBoxColumn";
            this.gioiTinhDataGridViewTextBoxColumn.Width = 80;
            // 
            // danTocDataGridViewTextBoxColumn
            // 
            this.danTocDataGridViewTextBoxColumn.DataPropertyName = "DanToc";
            this.danTocDataGridViewTextBoxColumn.HeaderText = "Dân tộc";
            this.danTocDataGridViewTextBoxColumn.Name = "danTocDataGridViewTextBoxColumn";
            // 
            // noiSinhDataGridViewTextBoxColumn
            // 
            this.noiSinhDataGridViewTextBoxColumn.DataPropertyName = "NoiSinh";
            this.noiSinhDataGridViewTextBoxColumn.HeaderText = "Nơi sinh";
            this.noiSinhDataGridViewTextBoxColumn.Name = "noiSinhDataGridViewTextBoxColumn";
            // 
            // maLopDataGridViewTextBoxColumn
            // 
            this.maLopDataGridViewTextBoxColumn.DataPropertyName = "MaLop";
            this.maLopDataGridViewTextBoxColumn.HeaderText = "Mã Lớp";
            this.maLopDataGridViewTextBoxColumn.Name = "maLopDataGridViewTextBoxColumn";
            // 
            // sinhVienBindingSource
            // 
            this.sinhVienBindingSource.DataMember = "SinhVien";
            this.sinhVienBindingSource.DataSource = this.qLDDataSet;
            // 
            // qLDDataSet
            // 
            this.qLDDataSet.DataSetName = "QLDDataSet";
            this.qLDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.btnThoatxl);
            this.groupPanel1.Controls.Add(this.txttimsv);
            this.groupPanel1.Controls.Add(this.labelX10);
            this.groupPanel1.Controls.Add(this.labelX9);
            this.groupPanel1.Controls.Add(this.cboLop);
            this.groupPanel1.Controls.Add(this.btnxoa);
            this.groupPanel1.Controls.Add(this.btnluusv);
            this.groupPanel1.Controls.Add(this.btnthemsv);
            this.groupPanel1.Controls.Add(this.txtdantoc);
            this.groupPanel1.Controls.Add(this.txtnoisinh);
            this.groupPanel1.Controls.Add(this.txtgioitinh);
            this.groupPanel1.Controls.Add(this.dateTimengaysinh);
            this.groupPanel1.Controls.Add(this.txttensv);
            this.groupPanel1.Controls.Add(this.txtmasv);
            this.groupPanel1.Controls.Add(this.labelX8);
            this.groupPanel1.Controls.Add(this.labelX7);
            this.groupPanel1.Controls.Add(this.labelX6);
            this.groupPanel1.Controls.Add(this.labelX5);
            this.groupPanel1.Controls.Add(this.labelX4);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.btnluulop);
            this.groupPanel1.Controls.Add(this.btnxoalop);
            this.groupPanel1.Controls.Add(this.btnthemlop);
            this.groupPanel1.Controls.Add(this.txttenlop);
            this.groupPanel1.Controls.Add(this.txtmalop);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupPanel1.Location = new System.Drawing.Point(70, 0);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(695, 195);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 0;
            this.groupPanel1.Text = "Cập nhật thông tin lớp - thông tin sinh viên";
            // 
            // txttimsv
            // 
            // 
            // 
            // 
            this.txttimsv.Border.Class = "TextBoxBorder";
            this.txttimsv.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txttimsv.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txttimsv.Location = new System.Drawing.Point(466, 140);
            this.txttimsv.Name = "txttimsv";
            this.txttimsv.Size = new System.Drawing.Size(124, 23);
            this.txttimsv.TabIndex = 25;
            this.txttimsv.TextChanged += new System.EventHandler(this.txttimsv_TextChanged);
            // 
            // labelX10
            // 
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX10.Location = new System.Drawing.Point(316, 140);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(144, 23);
            this.labelX10.TabIndex = 24;
            this.labelX10.Text = "Tìm kiếm sinh viên:";
            // 
            // labelX9
            // 
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX9.Location = new System.Drawing.Point(3, 12);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(99, 23);
            this.labelX9.TabIndex = 23;
            this.labelX9.Text = "Danh sách lớp:";
            // 
            // cboLop
            // 
            this.cboLop.DisplayMember = "Text";
            this.cboLop.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboLop.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboLop.FormattingEnabled = true;
            this.cboLop.ItemHeight = 17;
            this.cboLop.Location = new System.Drawing.Point(3, 36);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(121, 23);
            this.cboLop.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboLop.TabIndex = 22;
            this.cboLop.SelectedIndexChanged += new System.EventHandler(this.cboLop_SelectedIndexChanged);
            // 
            // btnxoa
            // 
            this.btnxoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnxoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnxoa.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnxoa.Location = new System.Drawing.Point(211, 140);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(73, 23);
            this.btnxoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnxoa.TabIndex = 21;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnluusv
            // 
            this.btnluusv.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnluusv.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnluusv.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnluusv.Location = new System.Drawing.Point(108, 140);
            this.btnluusv.Name = "btnluusv";
            this.btnluusv.Size = new System.Drawing.Size(73, 23);
            this.btnluusv.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnluusv.TabIndex = 20;
            this.btnluusv.Text = "Lưu lại";
            this.btnluusv.Click += new System.EventHandler(this.btnluusv_Click);
            // 
            // btnthemsv
            // 
            this.btnthemsv.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnthemsv.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnthemsv.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnthemsv.Location = new System.Drawing.Point(3, 140);
            this.btnthemsv.Name = "btnthemsv";
            this.btnthemsv.Size = new System.Drawing.Size(73, 23);
            this.btnthemsv.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnthemsv.TabIndex = 19;
            this.btnthemsv.Text = "Thêm mới";
            this.btnthemsv.Click += new System.EventHandler(this.btnthemsv_Click);
            // 
            // txtdantoc
            // 
            // 
            // 
            // 
            this.txtdantoc.Border.Class = "TextBoxBorder";
            this.txtdantoc.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtdantoc.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtdantoc.Location = new System.Drawing.Point(596, 94);
            this.txtdantoc.Name = "txtdantoc";
            this.txtdantoc.Size = new System.Drawing.Size(87, 23);
            this.txtdantoc.TabIndex = 18;
            // 
            // txtnoisinh
            // 
            // 
            // 
            // 
            this.txtnoisinh.Border.Class = "TextBoxBorder";
            this.txtnoisinh.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtnoisinh.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtnoisinh.Location = new System.Drawing.Point(491, 94);
            this.txtnoisinh.Name = "txtnoisinh";
            this.txtnoisinh.Size = new System.Drawing.Size(99, 23);
            this.txtnoisinh.TabIndex = 17;
            // 
            // txtgioitinh
            // 
            // 
            // 
            // 
            this.txtgioitinh.Border.Class = "TextBoxBorder";
            this.txtgioitinh.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtgioitinh.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtgioitinh.Location = new System.Drawing.Point(414, 94);
            this.txtgioitinh.Name = "txtgioitinh";
            this.txtgioitinh.Size = new System.Drawing.Size(69, 23);
            this.txtgioitinh.TabIndex = 16;
            // 
            // dateTimengaysinh
            // 
            this.dateTimengaysinh.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateTimengaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimengaysinh.Location = new System.Drawing.Point(278, 94);
            this.dateTimengaysinh.Name = "dateTimengaysinh";
            this.dateTimengaysinh.Size = new System.Drawing.Size(127, 23);
            this.dateTimengaysinh.TabIndex = 15;
            // 
            // txttensv
            // 
            // 
            // 
            // 
            this.txttensv.Border.Class = "TextBoxBorder";
            this.txttensv.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txttensv.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txttensv.Location = new System.Drawing.Point(108, 94);
            this.txttensv.Name = "txttensv";
            this.txttensv.Size = new System.Drawing.Size(162, 23);
            this.txttensv.TabIndex = 14;
            // 
            // txtmasv
            // 
            // 
            // 
            // 
            this.txtmasv.Border.Class = "TextBoxBorder";
            this.txtmasv.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtmasv.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtmasv.Location = new System.Drawing.Point(3, 94);
            this.txtmasv.Name = "txtmasv";
            this.txtmasv.Size = new System.Drawing.Size(99, 23);
            this.txtmasv.TabIndex = 13;
            // 
            // labelX8
            // 
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX8.Location = new System.Drawing.Point(596, 65);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(99, 23);
            this.labelX8.TabIndex = 12;
            this.labelX8.Text = "Dân tộc:";
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX7.Location = new System.Drawing.Point(491, 65);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(99, 23);
            this.labelX7.TabIndex = 11;
            this.labelX7.Text = "Nơi sinh:";
            this.labelX7.Click += new System.EventHandler(this.labelX7_Click);
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX6.Location = new System.Drawing.Point(407, 65);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(99, 23);
            this.labelX6.TabIndex = 10;
            this.labelX6.Text = "Giới tính:";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX5.Location = new System.Drawing.Point(273, 65);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(99, 23);
            this.labelX5.TabIndex = 9;
            this.labelX5.Text = "Ngày sinh:";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX4.Location = new System.Drawing.Point(108, 65);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(99, 23);
            this.labelX4.TabIndex = 8;
            this.labelX4.Text = "Tên sinh viên:";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX3.Location = new System.Drawing.Point(3, 65);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(99, 23);
            this.labelX3.TabIndex = 7;
            this.labelX3.Text = "Mã sinh viên:";
            // 
            // btnluulop
            // 
            this.btnluulop.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnluulop.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnluulop.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnluulop.Location = new System.Drawing.Point(509, 36);
            this.btnluulop.Name = "btnluulop";
            this.btnluulop.Size = new System.Drawing.Size(73, 23);
            this.btnluulop.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnluulop.TabIndex = 6;
            this.btnluulop.Text = "Lưu lại";
            this.btnluulop.Click += new System.EventHandler(this.buttonX3_Click);
            // 
            // btnxoalop
            // 
            this.btnxoalop.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnxoalop.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnxoalop.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnxoalop.Location = new System.Drawing.Point(605, 36);
            this.btnxoalop.Name = "btnxoalop";
            this.btnxoalop.Size = new System.Drawing.Size(73, 23);
            this.btnxoalop.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnxoalop.TabIndex = 5;
            this.btnxoalop.Text = "Xóa";
            this.btnxoalop.Click += new System.EventHandler(this.btnxoalop_Click);
            // 
            // btnthemlop
            // 
            this.btnthemlop.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnthemlop.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnthemlop.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnthemlop.Location = new System.Drawing.Point(413, 36);
            this.btnthemlop.Name = "btnthemlop";
            this.btnthemlop.Size = new System.Drawing.Size(73, 23);
            this.btnthemlop.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnthemlop.TabIndex = 4;
            this.btnthemlop.Text = "Thêm mới";
            this.btnthemlop.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // txttenlop
            // 
            // 
            // 
            // 
            this.txttenlop.Border.Class = "TextBoxBorder";
            this.txttenlop.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txttenlop.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txttenlop.Location = new System.Drawing.Point(253, 36);
            this.txttenlop.Name = "txttenlop";
            this.txttenlop.Size = new System.Drawing.Size(140, 23);
            this.txttenlop.TabIndex = 3;
            // 
            // txtmalop
            // 
            // 
            // 
            // 
            this.txtmalop.Border.Class = "TextBoxBorder";
            this.txtmalop.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtmalop.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtmalop.Location = new System.Drawing.Point(139, 36);
            this.txtmalop.Name = "txtmalop";
            this.txtmalop.Size = new System.Drawing.Size(99, 23);
            this.txtmalop.TabIndex = 2;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX2.Location = new System.Drawing.Point(253, 12);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(99, 23);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "Tên lớp:";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX1.Location = new System.Drawing.Point(139, 12);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(99, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Mã lớp:";
            // 
            // sinhVienTableAdapter
            // 
            this.sinhVienTableAdapter.ClearBeforeFill = true;
            // 
            // btnThoatxl
            // 
            this.btnThoatxl.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThoatxl.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThoatxl.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoatxl.Location = new System.Drawing.Point(613, 140);
            this.btnThoatxl.Name = "btnThoatxl";
            this.btnThoatxl.Size = new System.Drawing.Size(73, 23);
            this.btnThoatxl.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThoatxl.TabIndex = 26;
            this.btnThoatxl.Text = "Thoát";
            this.btnThoatxl.Click += new System.EventHandler(this.btnThoatxl_Click);
            // 
            // Lopsinhvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 403);
            this.Controls.Add(this.panelEx1);
            this.Name = "Lopsinhvien";
            this.Text = "Xử lí dữ liệu Lớp - Sinh viên";
            this.Load += new System.EventHandler(this.Lopsinhvien_Load);
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgsinhvien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDDataSet)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.ButtonX btnthemlop;
        private DevComponents.DotNetBar.Controls.TextBoxX txttenlop;
        private DevComponents.DotNetBar.Controls.TextBoxX txtmalop;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX btnluulop;
        private DevComponents.DotNetBar.ButtonX btnxoalop;
        private DevComponents.DotNetBar.Controls.TextBoxX txtgioitinh;
        private System.Windows.Forms.DateTimePicker dateTimengaysinh;
        private DevComponents.DotNetBar.Controls.TextBoxX txttensv;
        private DevComponents.DotNetBar.Controls.TextBoxX txtmasv;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.DataGridViewX dtgsinhvien;
        private DevComponents.DotNetBar.ButtonX btnxoa;
        private DevComponents.DotNetBar.ButtonX btnluusv;
        private DevComponents.DotNetBar.ButtonX btnthemsv;
        private DevComponents.DotNetBar.Controls.TextBoxX txtdantoc;
        private DevComponents.DotNetBar.Controls.TextBoxX txtnoisinh;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboLop;
        private QLDDataSet qLDDataSet;
        private System.Windows.Forms.BindingSource sinhVienBindingSource;
        private QLDDataSetTableAdapters.SinhVienTableAdapter sinhVienTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn danTocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noiSinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLopDataGridViewTextBoxColumn;
        private DevComponents.DotNetBar.Controls.TextBoxX txttimsv;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.ButtonX btnThoatxl;
    }
}