using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class BangTuyChinh : UserControl
    {
        public BangTuyChinh()
        {
            InitializeComponent();
            //this.thongtinnhanvienTableAdapter.Fill(this.dsnv_dbDataSet.Thongtinnhanvien);
            // TODO: This line of code loads data into the 'dsnv_dbDataSet.Thongtincongviec' table. You can move, or remove it, as needed.
            //this.thongtincongviecTableAdapter.Fill(this.dsnv_dbDataSet.Thongtincongviec);
            // TODO: This line of code loads data into the 'dsnv_dbDataSet.Danhsachnhanvien' table. You can move, or remove it, as needed.
            //this.danhsachnhanvienTableAdapter.Fill(this.dsnv_dbDataSet.Danhsachnhanvien);
            //this.thongtincongviecTableAdapter.Fill(this.dsnv_dbDataSet.Thongtincongviec);
            //this.thongtinnhanvienTableAdapter.Fill(this.dsnv_dbDataSet.Thongtinnhanvien);
            this.congViec_NhanVienTableAdapter.Fill(this.dsnv_dbDataSet.CongViec_NhanVien);
            //gridView1.Columns.Add(dsnv_dbDataSet.Thongtinnhanvien.Columns.)
            //DataColumn a = dsnv_dbDataSet.Thongtinnhanvien.ChuyennganhColumn;
            //dsnv_dbDataSet.DanhsachnhanvienDataTable a = new dsnv_dbDataSet.DanhsachnhanvienDataTable();
            //DataTable a= this.danhsachnhanvienTableAdapter.Get_
            //his.danhsachnhanvienTableAdapter.Getcot.
            this.Dock = System.Windows.Forms.DockStyle.Fill;
            //add a new row  
            //gridView1.AddNewRow();
            
            //gridView1.Columns.AddVisible("MyFieldName");
            //set a new row cell value. The static GridControl.NewItemRowHandle field allows you to retrieve the added row  
            //gridView1.SetRowCellValue(gridControl1.NewItemRowHandle, gridView1.Columns["Name"], "Please enter new value");
        }

        private void gridControl1_Click(object sender, System.EventArgs e)
        {

        }
    }
}
