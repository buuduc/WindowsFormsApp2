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
            this.danhsachnhanvienTableAdapter.Fill(this.dsnv_dbDataSet.Danhsachnhanvien);
            this.thongtincongviecTableAdapter.Fill(this.dsnv_dbDataSet.Thongtincongviec);
            this.thongtinnhanvienTableAdapter.Fill(this.dsnv_dbDataSet.Thongtinnhanvien);
            //gridView1.Columns.Add(dsnv_dbDataSet.Thongtinnhanvien.Columns.)
            //DataColumn a = dsnv_dbDataSet.Thongtinnhanvien.ChuyennganhColumn;
            dsnv_dbDataSet.DanhsachnhanvienDataTable a = new dsnv_dbDataSet.DanhsachnhanvienDataTable();
            this.danhsachnhanvienTableAdapter.Get_STT(a);
            //his.danhsachnhanvienTableAdapter.Getcot.
            

        }
    }
}
