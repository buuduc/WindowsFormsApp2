namespace WindowsFormsApp2
{
    partial class BangTuyChinh
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BangTuyChinh));
            this.congViec_NhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsnv_dbDataSet = new WindowsFormsApp2.dsnv_dbDataSet();
            this.danhsachnhanvienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.danhsachnhanvienTableAdapter = new WindowsFormsApp2.dsnv_dbDataSetTableAdapters.DanhsachnhanvienTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp2.dsnv_dbDataSetTableAdapters.TableAdapterManager();
            this.thongtincongviecBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thongtincongviecTableAdapter = new WindowsFormsApp2.dsnv_dbDataSetTableAdapters.ThongtincongviecTableAdapter();
            this.thongtinnhanvienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thongtinnhanvienTableAdapter = new WindowsFormsApp2.dsnv_dbDataSetTableAdapters.ThongtinnhanvienTableAdapter();
            this.congViec_NhanVienTableAdapter = new WindowsFormsApp2.dsnv_dbDataSetTableAdapters.CongViec_NhanVienTableAdapter();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHoten = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGioitinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgaysinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNoisinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrangthai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVitri = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChuyennganh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrinhdo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgaythuviec = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayhopdong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNoilamviec = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoaiHopdong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhichu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bindingNavigator2 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton10 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton11 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton12 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton13 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton14 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.congViec_NhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsnv_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhsachnhanvienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongtincongviecBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongtinnhanvienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).BeginInit();
            this.bindingNavigator2.SuspendLayout();
            this.SuspendLayout();
            // 
            // congViec_NhanVienBindingSource
            // 
            this.congViec_NhanVienBindingSource.DataMember = "CongViec_NhanVien";
            this.congViec_NhanVienBindingSource.DataSource = this.dsnv_dbDataSet;
            // 
            // dsnv_dbDataSet
            // 
            this.dsnv_dbDataSet.DataSetName = "dsnv_dbDataSet";
            this.dsnv_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // danhsachnhanvienBindingSource
            // 
            this.danhsachnhanvienBindingSource.DataMember = "Danhsachnhanvien";
            this.danhsachnhanvienBindingSource.DataSource = this.dsnv_dbDataSet;
            // 
            // danhsachnhanvienTableAdapter
            // 
            this.danhsachnhanvienTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DanhsachnhanvienTableAdapter = this.danhsachnhanvienTableAdapter;
            this.tableAdapterManager.HinhanhTableAdapter = null;
            this.tableAdapterManager.ThongtincongviecTableAdapter = null;
            this.tableAdapterManager.ThongtinnhanvienTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp2.dsnv_dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // thongtincongviecBindingSource
            // 
            this.thongtincongviecBindingSource.DataMember = "DanhsachnhanvienThongtincongviec";
            this.thongtincongviecBindingSource.DataSource = this.danhsachnhanvienBindingSource;
            // 
            // thongtincongviecTableAdapter
            // 
            this.thongtincongviecTableAdapter.ClearBeforeFill = true;
            // 
            // thongtinnhanvienBindingSource
            // 
            this.thongtinnhanvienBindingSource.DataMember = "DanhsachnhanvienThongtinnhanvien";
            this.thongtinnhanvienBindingSource.DataSource = this.danhsachnhanvienBindingSource;
            // 
            // thongtinnhanvienTableAdapter
            // 
            this.thongtinnhanvienTableAdapter.ClearBeforeFill = true;
            // 
            // congViec_NhanVienTableAdapter
            // 
            this.congViec_NhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.congViec_NhanVienBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(622, 300);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaso,
            this.colSTT,
            this.colHoten,
            this.colGioitinh,
            this.colNgaysinh,
            this.colNoisinh,
            this.colTrangthai,
            this.colVitri,
            this.colChuyennganh,
            this.colTrinhdo,
            this.colNgaythuviec,
            this.colNgayhopdong,
            this.colNoilamviec,
            this.colLoaiHopdong,
            this.colGhichu});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colMaso
            // 
            this.colMaso.FieldName = "Maso";
            this.colMaso.Name = "colMaso";
            this.colMaso.Visible = true;
            this.colMaso.VisibleIndex = 0;
            // 
            // colSTT
            // 
            this.colSTT.FieldName = "STT";
            this.colSTT.Name = "colSTT";
            this.colSTT.Visible = true;
            this.colSTT.VisibleIndex = 1;
            // 
            // colHoten
            // 
            this.colHoten.FieldName = "Hoten";
            this.colHoten.Name = "colHoten";
            this.colHoten.Visible = true;
            this.colHoten.VisibleIndex = 2;
            // 
            // colGioitinh
            // 
            this.colGioitinh.FieldName = "Gioitinh";
            this.colGioitinh.Name = "colGioitinh";
            this.colGioitinh.Visible = true;
            this.colGioitinh.VisibleIndex = 3;
            // 
            // colNgaysinh
            // 
            this.colNgaysinh.FieldName = "Ngaysinh";
            this.colNgaysinh.Name = "colNgaysinh";
            this.colNgaysinh.Visible = true;
            this.colNgaysinh.VisibleIndex = 4;
            // 
            // colNoisinh
            // 
            this.colNoisinh.FieldName = "Noisinh";
            this.colNoisinh.Name = "colNoisinh";
            this.colNoisinh.Visible = true;
            this.colNoisinh.VisibleIndex = 5;
            // 
            // colTrangthai
            // 
            this.colTrangthai.FieldName = "Trangthai";
            this.colTrangthai.Name = "colTrangthai";
            this.colTrangthai.Visible = true;
            this.colTrangthai.VisibleIndex = 6;
            // 
            // colVitri
            // 
            this.colVitri.FieldName = "Vitri";
            this.colVitri.Name = "colVitri";
            this.colVitri.Visible = true;
            this.colVitri.VisibleIndex = 7;
            // 
            // colChuyennganh
            // 
            this.colChuyennganh.FieldName = "Chuyennganh";
            this.colChuyennganh.Name = "colChuyennganh";
            this.colChuyennganh.Visible = true;
            this.colChuyennganh.VisibleIndex = 8;
            // 
            // colTrinhdo
            // 
            this.colTrinhdo.FieldName = "Trinhdo";
            this.colTrinhdo.Name = "colTrinhdo";
            this.colTrinhdo.Visible = true;
            this.colTrinhdo.VisibleIndex = 9;
            // 
            // colNgaythuviec
            // 
            this.colNgaythuviec.FieldName = "Ngaythuviec";
            this.colNgaythuviec.Name = "colNgaythuviec";
            this.colNgaythuviec.Visible = true;
            this.colNgaythuviec.VisibleIndex = 10;
            // 
            // colNgayhopdong
            // 
            this.colNgayhopdong.FieldName = "Ngayhopdong";
            this.colNgayhopdong.Name = "colNgayhopdong";
            this.colNgayhopdong.Visible = true;
            this.colNgayhopdong.VisibleIndex = 11;
            // 
            // colNoilamviec
            // 
            this.colNoilamviec.FieldName = "Noilamviec";
            this.colNoilamviec.Name = "colNoilamviec";
            this.colNoilamviec.Visible = true;
            this.colNoilamviec.VisibleIndex = 12;
            // 
            // colLoaiHopdong
            // 
            this.colLoaiHopdong.FieldName = "LoaiHopdong";
            this.colLoaiHopdong.Name = "colLoaiHopdong";
            this.colLoaiHopdong.Visible = true;
            this.colLoaiHopdong.VisibleIndex = 13;
            // 
            // colGhichu
            // 
            this.colGhichu.FieldName = "Ghichu";
            this.colGhichu.Name = "colGhichu";
            this.colGhichu.Visible = true;
            this.colGhichu.VisibleIndex = 14;
            // 
            // bindingNavigator2
            // 
            this.bindingNavigator2.AddNewItem = this.toolStripButton8;
            this.bindingNavigator2.BindingSource = this.congViec_NhanVienBindingSource;
            this.bindingNavigator2.CountItem = this.toolStripLabel2;
            this.bindingNavigator2.DeleteItem = this.toolStripButton9;
            this.bindingNavigator2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton10,
            this.toolStripButton11,
            this.toolStripSeparator4,
            this.toolStripTextBox2,
            this.toolStripLabel2,
            this.toolStripSeparator5,
            this.toolStripButton12,
            this.toolStripButton13,
            this.toolStripSeparator6,
            this.toolStripButton8,
            this.toolStripButton9,
            this.toolStripButton14});
            this.bindingNavigator2.Location = new System.Drawing.Point(0, 275);
            this.bindingNavigator2.MoveFirstItem = this.toolStripButton10;
            this.bindingNavigator2.MoveLastItem = this.toolStripButton13;
            this.bindingNavigator2.MoveNextItem = this.toolStripButton12;
            this.bindingNavigator2.MovePreviousItem = this.toolStripButton11;
            this.bindingNavigator2.Name = "bindingNavigator2";
            this.bindingNavigator2.PositionItem = this.toolStripTextBox2;
            this.bindingNavigator2.Size = new System.Drawing.Size(622, 25);
            this.bindingNavigator2.TabIndex = 5;
            this.bindingNavigator2.Text = "bindingNavigator1";
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.RightToLeftAutoMirrorImage = true;
            this.toolStripButton8.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton8.Text = "Add new";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel2.Text = "of {0}";
            this.toolStripLabel2.ToolTipText = "Total number of items";
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton9.Image")));
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.RightToLeftAutoMirrorImage = true;
            this.toolStripButton9.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton9.Text = "Delete";
            // 
            // toolStripButton10
            // 
            this.toolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton10.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton10.Image")));
            this.toolStripButton10.Name = "toolStripButton10";
            this.toolStripButton10.RightToLeftAutoMirrorImage = true;
            this.toolStripButton10.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton10.Text = "Move first";
            // 
            // toolStripButton11
            // 
            this.toolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton11.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton11.Image")));
            this.toolStripButton11.Name = "toolStripButton11";
            this.toolStripButton11.RightToLeftAutoMirrorImage = true;
            this.toolStripButton11.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton11.Text = "Move previous";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.AccessibleName = "Position";
            this.toolStripTextBox2.AutoSize = false;
            this.toolStripTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox2.Text = "0";
            this.toolStripTextBox2.ToolTipText = "Current position";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton12
            // 
            this.toolStripButton12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton12.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton12.Image")));
            this.toolStripButton12.Name = "toolStripButton12";
            this.toolStripButton12.RightToLeftAutoMirrorImage = true;
            this.toolStripButton12.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton12.Text = "Move next";
            // 
            // toolStripButton13
            // 
            this.toolStripButton13.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton13.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton13.Image")));
            this.toolStripButton13.Name = "toolStripButton13";
            this.toolStripButton13.RightToLeftAutoMirrorImage = true;
            this.toolStripButton13.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton13.Text = "Move last";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton14
            // 
            this.toolStripButton14.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton14.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton14.Image")));
            this.toolStripButton14.Name = "toolStripButton14";
            this.toolStripButton14.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton14.Text = "Save Data";
            this.toolStripButton14.Click += new System.EventHandler(this.toolStripButton14_Click);
            // 
            // BangTuyChinh
            // 
            this.Controls.Add(this.bindingNavigator2);
            this.Controls.Add(this.gridControl1);
            this.Name = "BangTuyChinh";
            this.Size = new System.Drawing.Size(622, 300);
            ((System.ComponentModel.ISupportInitialize)(this.congViec_NhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsnv_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhsachnhanvienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongtincongviecBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongtinnhanvienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).EndInit();
            this.bindingNavigator2.ResumeLayout(false);
            this.bindingNavigator2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource danhsachnhanvienBindingSource;
        private dsnv_dbDataSet dsnv_dbDataSet;
        private dsnv_dbDataSetTableAdapters.DanhsachnhanvienTableAdapter danhsachnhanvienTableAdapter;
        private dsnv_dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource thongtinnhanvienBindingSource;
        private System.Windows.Forms.BindingSource thongtincongviecBindingSource;
        private dsnv_dbDataSetTableAdapters.ThongtincongviecTableAdapter thongtincongviecTableAdapter;
        private dsnv_dbDataSetTableAdapters.ThongtinnhanvienTableAdapter thongtinnhanvienTableAdapter;
        private System.Windows.Forms.BindingSource congViec_NhanVienBindingSource;
        private dsnv_dbDataSetTableAdapters.CongViec_NhanVienTableAdapter congViec_NhanVienTableAdapter;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaso;
        private DevExpress.XtraGrid.Columns.GridColumn colSTT;
        private DevExpress.XtraGrid.Columns.GridColumn colHoten;
        private DevExpress.XtraGrid.Columns.GridColumn colGioitinh;
        private DevExpress.XtraGrid.Columns.GridColumn colNgaysinh;
        private DevExpress.XtraGrid.Columns.GridColumn colNoisinh;
        private DevExpress.XtraGrid.Columns.GridColumn colTrangthai;
        private DevExpress.XtraGrid.Columns.GridColumn colVitri;
        private DevExpress.XtraGrid.Columns.GridColumn colChuyennganh;
        private DevExpress.XtraGrid.Columns.GridColumn colTrinhdo;
        private DevExpress.XtraGrid.Columns.GridColumn colNgaythuviec;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayhopdong;
        private DevExpress.XtraGrid.Columns.GridColumn colNoilamviec;
        private DevExpress.XtraGrid.Columns.GridColumn colLoaiHopdong;
        private DevExpress.XtraGrid.Columns.GridColumn colGhichu;
        private System.Windows.Forms.BindingNavigator bindingNavigator2;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton toolStripButton9;
        private System.Windows.Forms.ToolStripButton toolStripButton10;
        private System.Windows.Forms.ToolStripButton toolStripButton11;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripButton12;
        private System.Windows.Forms.ToolStripButton toolStripButton13;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton toolStripButton14;
    }
}
