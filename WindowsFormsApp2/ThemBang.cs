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
    public partial class ThemBang : Form
    { 
        private bool check = false;
        public ThemBang()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {


        }
        public string Ten_Bang 
        {
            get { return TenBang.Text; }
        }
        public bool CheckDialog
        {
            get { return this.check; }
            set { this.check = value; }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {   if (TenBang.Text != "")
            {
                this.check = true;
                this.Close();
            }
            else MessageBox.Show("Tên bảng không được để trống");
        }
    }
}
