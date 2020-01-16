using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class ThongTinNhanVien_New : Form
    {
        public ThongTinNhanVien_New()
        {
            InitializeComponent();
        }
        public int Position { get; set; }
        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsnv_dbDataSet.CongViec_NhanVien' table. You can move, or remove it, as needed.
            this.congViec_NhanVienTableAdapter.Fill(this.dsnv_dbDataSet.CongViec_NhanVien);
            congViec_NhanVienBindingSource.Position = this.Position;

        }
        protected virtual bool IsFileLocked(FileInfo file)
        {
            try
            {
                using (FileStream stream = file.Open(FileMode.Open, FileAccess.Read, FileShare.None))
                {
                    stream.Close();
                }
            }
            catch (IOException)
            {
                //the file is unavailable because it is:
                //still being written to
                //or being processed by another thread
                //or does not exist (has already been processed)
                return true;
            }

            //file is not locked
            return false;
        }
        private static string diachi;
        private void SavePicture()
        {
            String maso = masoTextEdit.Text;
            diachi = "E:/Database/Hinhanh/" + maso + ".png";
            bool checkin = IsFileLocked(new FileInfo(diachi));
            if (System.IO.File.Exists(diachi) == true & checkin == false)
            {
                System.IO.File.Delete(diachi);
                pictureEdit1.Image.Save(diachi);

            }
            else if (System.IO.File.Exists(diachi) == true & checkin == true)
            { }
            else
            {
                pictureEdit1.Image.Save(diachi);
            }



        }
        public delegate void Truyenchocha();
        public Truyenchocha truyenData;
        private void congViec_NhanVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            SavePicture();
            this.Validate();
            this.congViec_NhanVienBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsnv_dbDataSet);
            truyenData();
        }

        private void pictureTextEdit_EditValueChanged(object sender, EventArgs e)
        {

            if (pictureTextEdit.Text == "")
            {
                pictureEdit1.Image = Image.FromFile("E:/Database/Hinhanh/Admin.png");
            }
            else
            {
                pictureEdit1.Image = Image.FromFile(pictureTextEdit.Text);
            }

        }

        private void masoTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
