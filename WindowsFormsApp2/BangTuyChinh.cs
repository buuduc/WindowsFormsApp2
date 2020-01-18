using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class BangTuyChinh : UserControl
    {
        public BangTuyChinh()
        {
            InitializeComponent();
            
            this.congViec_NhanVienTableAdapter.Fill(this.dsnv_dbDataSet.CongViec_NhanVien);
            this.Dock = System.Windows.Forms.DockStyle.Fill;
            
    
        }

        
        public int GetPositon
        {
            get { return congViec_NhanVienBindingSource.Position; }
        }

        private void toolStripButton14_Click(object sender, System.EventArgs e)
        {
            this.Validate();
            this.congViec_NhanVienBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsnv_dbDataSet);
        }
    }
    
}
