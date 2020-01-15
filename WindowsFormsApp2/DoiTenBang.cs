using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class DoiTenBang : DevExpress.XtraEditors.XtraForm
    {
        public bool check = false;
        public DoiTenBang()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (TenBang.Text != "")
            {
                this.check = true;
                this.Close();
            }
            else MessageBox.Show("Tên bảng không được để trống");
        }
        public string TenThayDoi
        {
            get { return TenBang.Text; }
            set { TenBang.Text = value; }
        }
    }
}
