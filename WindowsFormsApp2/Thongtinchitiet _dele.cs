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
    public partial class Thongtinchitiet_dele : Form
    {
        public int k;
        public String diachi;
        public static Form2 a;
        public Thongtinchitiet_dele(int k)
        {
            this.k = k;
            InitializeComponent();
        }
        public delegate void Truyenchocha();
        public Truyenchocha truyenData;
        public void danhsachnhanvienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            SavePicture();
            this.Validate();
            this.danhsachnhanvienBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsnv_dbDataSet);
            //
            this.thongtincongviecBindingSource.EndEdit();
            this.thongtincongviecTableAdapter.Update(this.dsnv_dbDataSet);
            //
            this.thongtinnhanvienBindingSource.EndEdit();
            this.thongtinnhanvienTableAdapter.Update(this.dsnv_dbDataSet);
            //
            this.hinhanhBindingSource.EndEdit();
            this.hinhanhTableAdapter.Update(this.dsnv_dbDataSet);
            // 
            truyenData();
            
            //// TODO: This line of code loads data into the 'dsnv_dbDataSet.Thongtinnhanvien' table. You can move, or remove it, as needed.
            //thongtinnhanvienTableAdapter.Fill(this.dsnv_dbDataSet.Thongtinnhanvien);
            //// TODO: This line of code loads data into the 'dsnv_dbDataSet.Thongtincongviec' table. You can move, or remove it, as needed.
            //thongtincongviecTableAdapter.Fill(this.dsnv_dbDataSet.Thongtincongviec);
            //// TODO: This line of code loads data into the 'dsnv_dbDataSet.Danhsachnhanvien' table. You can move, or remove it, as needed.
            //danhsachnhanvienTableAdapter.Fill(this.dsnv_dbDataSet.Danhsachnhanvien);
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
        private void SavePicture()
        {
            String maso = masoTextEdit.Text;
            this.diachi = "E:/Database/Hinhanh/" + maso + ".png";
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
            

            pictureTextBox.Text = diachi;
            
        }
        private void Thongtinchitiet_dele_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsnv_dbDataSet.Hinhanh' table. You can move, or remove it, as needed.
            this.hinhanhTableAdapter.Fill(this.dsnv_dbDataSet.Hinhanh);
            // TODO: This line of code loads data into the 'dsnv_dbDataSet.Thongtincongviec' table. You can move, or remove it, as needed.
            this.thongtincongviecTableAdapter.Fill(this.dsnv_dbDataSet.Thongtincongviec);
            // TODO: This line of code loads data into the 'dsnv_dbDataSet.Thongtinnhanvien' table. You can move, or remove it, as needed.
            this.thongtinnhanvienTableAdapter.Fill(this.dsnv_dbDataSet.Thongtinnhanvien);
            // TODO: This line of code loads data into the 'dsnv_dbDataSet.Danhsachnhanvien' table. You can move, or remove it, as needed.
            this.danhsachnhanvienTableAdapter.Fill(this.dsnv_dbDataSet.Danhsachnhanvien);
            //
            danhsachnhanvienBindingSource.Position = System.Convert.ToInt32(this.k);
            this.ADDROW();
        }
        private void ADDROW()
        {

            int p = this.hinhanhBindingSource.List.Count;
            if (dsnv_dbDataSet.Hinhanh.FindByMaso(masoTextEdit.Text) == null)
            {
                DataRow workRow = dsnv_dbDataSet.Hinhanh.NewRow();
                workRow[0] = masoTextEdit.Text;
                dsnv_dbDataSet.Hinhanh.Rows.Add(workRow);
                this.hinhanhBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dsnv_dbDataSet);
            }

            if (dsnv_dbDataSet.Thongtincongviec.FindByMaso(masoTextEdit.Text) == null)
            {
                DataRow workRow = dsnv_dbDataSet.Thongtincongviec.NewRow();
                workRow[0] = masoTextEdit.Text;
                dsnv_dbDataSet.Thongtincongviec.Rows.Add(workRow);
                this.thongtincongviecBindingSource.EndEdit();
                this.thongtincongviecTableAdapter.Update(this.dsnv_dbDataSet);
            }
            if (dsnv_dbDataSet.Thongtinnhanvien.FindByMaso(masoTextEdit.Text) == null)
            {
                DataRow workRow = dsnv_dbDataSet.Thongtinnhanvien.NewRow();
                workRow[0] = masoTextEdit.Text;
                dsnv_dbDataSet.Thongtinnhanvien.Rows.Add(workRow);
                this.thongtinnhanvienBindingSource.EndEdit();
                this.thongtinnhanvienTableAdapter.Update(this.dsnv_dbDataSet);
            }




            

        }

        private void pictureTextBox_TextChanged(object sender, EventArgs e)
        {
            if (pictureTextBox.Text == "")
            {
                pictureEdit1.Image = Image.FromFile("E:/Database/Hinhanh/Admin.png");
            }
            else
            {
                pictureEdit1.Image = Image.FromFile(pictureTextBox.Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureEdit1.LoadImage();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn muốn xoá nhân viên này ? \n Bạn không thể phục hồi nếu đã xoá !",
                         "Cảnh báo !", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    {
                        danhsachnhanvienTableAdapter.DeleteQuery(masoTextEdit.Text);
                        truyenData();
                        MessageBox.Show("Xoá thành công");
                        this.Close();
                    }
                    break;
                case DialogResult.No:
                    break;
            }
            
        }
    }
}
