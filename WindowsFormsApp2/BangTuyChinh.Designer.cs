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
            ((System.ComponentModel.ISupportInitialize)(this.congViec_NhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsnv_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhsachnhanvienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongtincongviecBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongtinnhanvienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
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
            // BangTuyChinh
            // 
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
            this.ResumeLayout(false);

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
    }
}
